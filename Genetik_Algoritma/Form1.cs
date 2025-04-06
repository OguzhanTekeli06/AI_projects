using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Genetik_Algoritma
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private int KromozomUzunlugu;
        private int PopulasyonBoyutu;
        private double CaprazlamaOrani;
        private double MutasyonOrani;
        private double SeckinlikOrani;
        private int SeckinlikAdedi;
        private int MaxJenerasyonSayisi;

        private List<double[]> populasyon; // Popülasyon
        private List<double> uygunlukDegeri; // Popülasyonun uygunluk değerleri
        private readonly Func<double, double, double> AmacFonksiyonu = (x, y) => Math.Pow(x, 2) + Math.Pow(y, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void baslat_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(kromozomUzunlugu_txtbx.Text, out _)
                || !int.TryParse(populasyonBoyutu_txtbx.Text, out _)
                || !double.TryParse(caprazlamaOrani_txtbx.Text, out _)
                || !double.TryParse(mutasyonOrani_txtbx.Text, out _)
                || !double.TryParse(seckinlikOrani_txtbx.Text, out _)
                || !int.TryParse(maxJenerasyonSayisi_txtbx.Text, out _))
            {
                MessageBox.Show("Geçersiz değerler. Lütfen doğru değerler giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KromozomUzunlugu = int.Parse(kromozomUzunlugu_txtbx.Text);
                PopulasyonBoyutu = int.Parse(populasyonBoyutu_txtbx.Text);
                CaprazlamaOrani = double.Parse(caprazlamaOrani_txtbx.Text);
                MutasyonOrani = double.Parse(mutasyonOrani_txtbx.Text);
                SeckinlikOrani = double.Parse(seckinlikOrani_txtbx.Text);
                SeckinlikAdedi = (int)(PopulasyonBoyutu * SeckinlikOrani);
                MaxJenerasyonSayisi = int.Parse(maxJenerasyonSayisi_txtbx.Text);

                PopulasyonuOlustur();

                int generation = 0;
                while (generation < MaxJenerasyonSayisi) // Maksimum jenerasyon sayısına kadar döngü
                {
                    PopulasyonuHesapla(); // Popülasyonun uygunluk değerlerini hesapla
                    var bestSolution = populasyon[uygunlukDegeri.IndexOf(uygunlukDegeri.Min())]; // En iyi çözümü bul
                    GrafigiGoster(generation, uygunlukDegeri.Min()); // Yakınsama grafiğini güncelle

                    if (uygunlukDegeri.Min() < 0.001) // Hedefe ulaşıldıysa döngüyü sonlandır
                        break;

                    List<double[]> yeniPopulasyon = new List<double[]>();

                    var seckinPopulasyon = populasyon
        .Select((kromozom, index) => new { Chromosome = kromozom, Index = index })
        .OrderBy(item => uygunlukDegeri[item.Index])
        .Take(SeckinlikAdedi)
        .Select(item => item.Chromosome)
        .ToList();

                    yeniPopulasyon.AddRange(seckinPopulasyon);

                    while (yeniPopulasyon.Count < PopulasyonBoyutu)
                    {
                        var parent1 = SelectParent();
                        var parent2 = SelectParent(); 

                        var children = Caprazla(parent1, parent2);
                        Mutasyon(children[0]); 
                        Mutasyon(children[1]);

                        yeniPopulasyon.Add(children[0]);
                        yeniPopulasyon.Add(children[1]);
                    }

                    populasyon = yeniPopulasyon;
                    generation++;
                }

                var bestResult = populasyon[uygunlukDegeri.IndexOf(uygunlukDegeri.Min())]; 
                double bestFitness = uygunlukDegeri.Min();
                double x = bestResult[0];
                double y = bestResult[1];

                MessageBox.Show($"En iyi çözüm: f({x}, {y}) = {bestFitness}");
            }
        }
        private void PopulasyonuOlustur()
        {
            populasyon = new List<double[]>();

            for (int i = 0; i < PopulasyonBoyutu; i++)
            {
                double[] kromozom = new double[KromozomUzunlugu];
                for (int j = 0; j < KromozomUzunlugu; j++)
                {
                    kromozom[j] = random.NextDouble() * 20 - 10;
                }
                populasyon.Add(kromozom);
            }
        }
        private void PopulasyonuHesapla()
        {
            uygunlukDegeri = new List<double>();
            foreach (var chromosome in populasyon)
            {
                double x = chromosome[0];
                double y = chromosome[1];
                double fitness = AmacFonksiyonu(x, y);
                uygunlukDegeri.Add(fitness);
            }
        }
        private double[] SelectParent()
        {
            int index1 = random.Next(PopulasyonBoyutu);
            int index2 = random.Next(PopulasyonBoyutu);
            return uygunlukDegeri[index1] < uygunlukDegeri[index2] ? populasyon[index1] : populasyon[index2];
        }

        private double[][] Caprazla(double[] parent1, double[] parent2)
        {
            if (random.NextDouble() < CaprazlamaOrani) 
            {
                int caprazlamaNoktasi = KromozomUzunlugu / 2; 
                var child1 = parent1.Take(caprazlamaNoktasi).Concat(parent2.Skip(caprazlamaNoktasi)).ToArray();
                var child2 = parent2.Take(caprazlamaNoktasi).Concat(parent1.Skip(caprazlamaNoktasi)).ToArray(); 
                return new[] { child1, child2 };

            }
            else
            {
                return new[] { parent1, parent2 };
            }
        }
        private void Mutasyon(double[] chromosome)
        {
            for (int i = 0; i < KromozomUzunlugu; i++)
            {
                if (random.NextDouble() < MutasyonOrani)
                {
                    chromosome[i] += (random.NextDouble() - 0.5);
                }
            }
        }
        private void GrafigiGoster(int generation, double bestFitness)
        {
            grafik1.Series[0].Points.AddXY(generation, bestFitness);
            grafik1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
        private void temizle_btn_Click(object sender, EventArgs e)
        {
            grafik1.Series[0].Points.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafik1.ChartAreas[0].AxisX.Title = "Jenerasyon"; 
            grafik1.ChartAreas[0].AxisY.Title = "Uygunluk Değeri"; 
            grafik1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            grafik1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            grafik1.Series[0].Color = Color.Red;
            grafik1.Series[0].BorderWidth = 2;
        }
    }
}
