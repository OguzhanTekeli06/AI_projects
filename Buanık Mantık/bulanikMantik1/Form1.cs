using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bulanikMantik1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem kural1 = kural_listesi.Items.Add("K1");
            kural1.SubItems.Add("Hassas");
            kural1.SubItems.Add("Küçük");
            kural1.SubItems.Add("Küçük");
            kural1.SubItems.Add("Hassas");
            kural1.SubItems.Add("Kısa");
            kural1.SubItems.Add("Çok Az");

            ListViewItem kural2 = kural_listesi.Items.Add("K2");
            kural2.SubItems.Add("Hassas");
            kural2.SubItems.Add("Küçük");
            kural2.SubItems.Add("Orta");
            kural2.SubItems.Add("Normal Hassas");
            kural2.SubItems.Add("Kısa");
            kural2.SubItems.Add("Az");

            ListViewItem kural3 = kural_listesi.Items.Add("K3");
            kural3.SubItems.Add("Hassas");
            kural3.SubItems.Add("Küçük");
            kural3.SubItems.Add("Büyük");
            kural3.SubItems.Add("Orta");
            kural3.SubItems.Add("Normal Kısa");
            kural3.SubItems.Add("Orta");

            ListViewItem kural4 = kural_listesi.Items.Add("K4");
            kural4.SubItems.Add("Hassas");
            kural4.SubItems.Add("Orta");
            kural4.SubItems.Add("Küçük");
            kural4.SubItems.Add("Hassas");
            kural4.SubItems.Add("Kısa");
            kural4.SubItems.Add("Orta");

            ListViewItem kural5 = kural_listesi.Items.Add("K5");
            kural5.SubItems.Add("Hassas");
            kural5.SubItems.Add("Orta");
            kural5.SubItems.Add("Orta");
            kural5.SubItems.Add("Normal Hassas");
            kural5.SubItems.Add("Normal Kısa");
            kural5.SubItems.Add("Orta");

            ListViewItem kural6 = kural_listesi.Items.Add("K6");
            kural6.SubItems.Add("Hassas");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Büyük");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Fazla");

            ListViewItem kural7 = kural_listesi.Items.Add("K7");
            kural7.SubItems.Add("Hassas");
            kural7.SubItems.Add("Büyük");
            kural7.SubItems.Add("Küçük");
            kural7.SubItems.Add("Normal Hassas");
            kural7.SubItems.Add("Normal Kısa");
            kural7.SubItems.Add("Orta");

            ListViewItem kural8 = kural_listesi.Items.Add("K8");
            kural8.SubItems.Add("Hassas");
            kural8.SubItems.Add("Büyük");
            kural8.SubItems.Add("Orta");
            kural8.SubItems.Add("Normal Hassas");
            kural8.SubItems.Add("Orta");
            kural8.SubItems.Add("Fazla");

            ListViewItem kural9 = kural_listesi.Items.Add("K9");
            kural9.SubItems.Add("Hassas");
            kural9.SubItems.Add("Büyük");
            kural9.SubItems.Add("Büyük");
            kural9.SubItems.Add("Orta");
            kural9.SubItems.Add("Normal Uzun");
            kural9.SubItems.Add("Fazla");

            ListViewItem kural10 = kural_listesi.Items.Add("K10");
            kural10.SubItems.Add("Orta");
            kural10.SubItems.Add("Küçük");
            kural10.SubItems.Add("Küçük");
            kural10.SubItems.Add("Normal Hassas");
            kural10.SubItems.Add("Normal Kısa");
            kural10.SubItems.Add("Az");

            ListViewItem kural11 = kural_listesi.Items.Add("K11");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Küçük");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Kısa");
            kural11.SubItems.Add("Orta");

            ListViewItem kural12 = kural_listesi.Items.Add("K12");
            kural12.SubItems.Add("Orta");
            kural12.SubItems.Add("Küçük");
            kural12.SubItems.Add("Büyük");
            kural12.SubItems.Add("Normal Güçlü");
            kural12.SubItems.Add("Orta");
            kural12.SubItems.Add("Fazla");

            ListViewItem kural13 = kural_listesi.Items.Add("K13");
            kural13.SubItems.Add("Orta");
            kural13.SubItems.Add("Orta");
            kural13.SubItems.Add("Küçük");
            kural13.SubItems.Add("Normal Hassas");
            kural13.SubItems.Add("Normal Kısa");
            kural13.SubItems.Add("Orta");

            ListViewItem kural14 = kural_listesi.Items.Add("K14");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");

            ListViewItem kural15 = kural_listesi.Items.Add("K15");
            kural15.SubItems.Add("Orta");
            kural15.SubItems.Add("Orta");
            kural15.SubItems.Add("Büyük");
            kural15.SubItems.Add("Hassas");
            kural15.SubItems.Add("Uzun");
            kural15.SubItems.Add("Fazla");

            ListViewItem kural16 = kural_listesi.Items.Add("K16");
            kural16.SubItems.Add("Orta");
            kural16.SubItems.Add("Büyük");
            kural16.SubItems.Add("Küçük");
            kural16.SubItems.Add("Hassas");
            kural16.SubItems.Add("Orta");
            kural16.SubItems.Add("Orta");

            ListViewItem kural17 = kural_listesi.Items.Add("K17");
            kural17.SubItems.Add("Orta");
            kural17.SubItems.Add("Büyük");
            kural17.SubItems.Add("Orta");
            kural17.SubItems.Add("Hassas");
            kural17.SubItems.Add("Normal Uzun");
            kural17.SubItems.Add("Fazla");

            ListViewItem kural18 = kural_listesi.Items.Add("K18");
            kural18.SubItems.Add("Orta");
            kural18.SubItems.Add("Büyük");
            kural18.SubItems.Add("Büyük");
            kural18.SubItems.Add("Hassas");
            kural18.SubItems.Add("Uzun");
            kural18.SubItems.Add("Çok Fazla");

            ListViewItem kural19 = kural_listesi.Items.Add("K19");
            kural19.SubItems.Add("Sağlam");
            kural19.SubItems.Add("Küçük");
            kural19.SubItems.Add("Küçük");
            kural19.SubItems.Add("Orta");
            kural19.SubItems.Add("Orta");
            kural19.SubItems.Add("Az");

            ListViewItem kural20 = kural_listesi.Items.Add("K20");
            kural20.SubItems.Add("Sağlam");
            kural20.SubItems.Add("Küçük");
            kural20.SubItems.Add("Orta");
            kural20.SubItems.Add("Normal Güçlü");
            kural20.SubItems.Add("Orta");
            kural20.SubItems.Add("Orta");

            ListViewItem kural21 = kural_listesi.Items.Add("K21");
            kural21.SubItems.Add("Sağlam");
            kural21.SubItems.Add("Küçük");
            kural21.SubItems.Add("Büyük");
            kural21.SubItems.Add("Güçlü");
            kural21.SubItems.Add("Normal Uzun");
            kural21.SubItems.Add("Fazla");

            ListViewItem kural22 = kural_listesi.Items.Add("K22");
            kural22.SubItems.Add("Sağlam");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Küçük");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Orta");

            ListViewItem kural23 = kural_listesi.Items.Add("K23");
            kural23.SubItems.Add("Sağlam");
            kural23.SubItems.Add("Orta");
            kural23.SubItems.Add("Orta");
            kural23.SubItems.Add("Normal Güçlü");
            kural23.SubItems.Add("Normal Uzun");
            kural23.SubItems.Add("Orta");

            ListViewItem kural24 = kural_listesi.Items.Add("K24");
            kural24.SubItems.Add("Sağlam");
            kural24.SubItems.Add("Orta");
            kural24.SubItems.Add("Büyük");
            kural24.SubItems.Add("Güçlü");
            kural24.SubItems.Add("Orta");
            kural24.SubItems.Add("Çok Fazla");

            ListViewItem kural25 = kural_listesi.Items.Add("K25");
            kural25.SubItems.Add("Sağlam");
            kural25.SubItems.Add("Büyük");
            kural25.SubItems.Add("Küçük");
            kural25.SubItems.Add("Normal Güçlü");
            kural25.SubItems.Add("Normal Uzun");
            kural25.SubItems.Add("Fazla");

            ListViewItem kural26 = kural_listesi.Items.Add("K26");
            kural26.SubItems.Add("Sağlam");
            kural26.SubItems.Add("Büyük");
            kural26.SubItems.Add("Orta");
            kural26.SubItems.Add("Normal Güçlü");
            kural26.SubItems.Add("Uzun");
            kural26.SubItems.Add("Fazla");

            ListViewItem kural27 = kural_listesi.Items.Add("K27");
            kural27.SubItems.Add("Sağlam");
            kural27.SubItems.Add("Büyük");
            kural27.SubItems.Add("Büyük");
            kural27.SubItems.Add("Güçlü");
            kural27.SubItems.Add("Uzun");
            kural27.SubItems.Add("Çok Fazla");

        }

        public double hassasiyet, miktar, kirlilik;
        
        
        public List<double> maxlar_Donus = new List<double>();
        public List<double> ortancalar_donus = new List<double>();
        public List<double> maxlar_Sure = new List<double>();
        public List<double> ortancalar_sure = new List<double>();
        public List<double> maxlar_Deterjan = new List<double>();
        public List<double> ortancalar_deterjan = new List<double>();
    
        Bulanik_Mantik bulanik_mantik;

        public List<double> min = new List<double>();
        public List<double> mamdani_Sonucu = new List<double>();
        public List<double> max = new List<double>();
        private void buton(object sender, EventArgs e)
        {
            Mamdami.Items.Clear();
            hassasiyet = Convert.ToDouble(hassasiyet_deger_girisi.Value);
            miktar = Convert.ToDouble(miktar_deger_girisi.Value);
            kirlilik = Convert.ToDouble(kirlilik_deger_girisi.Value);
            bulanik_mantik = new Bulanik_Mantik(hassasiyet, miktar, kirlilik);
            bulanik_mantik.Hassasiyet_Kontrolu();
            bulanik_mantik.Miktar_kontrolu();
            bulanik_mantik.Kirlilik_kontrolu();
            Uzman_kural_secimi();
            Mamdami.Items.Clear();
            for (int i = 0; i < min.Count(); i++)
            {
                Mamdami.Items.Add(min[i].ToString());
            }
            if (maxlar_Donus != null)
            {
                Donus_hizini_kont_et();
            }
            if (maxlar_Sure != null)
            {
                Zaman_kont_et();
            }
            if (maxlar_Deterjan != null)
            {
                Deterjan_kont_et();
            }

            string[] miktarKumeleri = bulanik_mantik.MiktarKumesiniGetir();
            string[] kirlilikKumeleri = bulanik_mantik.KirlilikKumesiniGetir();
            string[] hassaslikKumeleri = bulanik_mantik.HassaslikKumesiniGetir();

            lblHassaslikKume.Text = string.Join(" , ", hassaslikKumeleri);
            lblMiktarKume.Text = string.Join(" , ", miktarKumeleri);
            lblKirlilikKume.Text = string.Join(" , ", kirlilikKumeleri);


            donushizisonuc.Text = bulanik_mantik.Durulama(maxlar_Donus, ortancalar_donus).ToString();
            sure_baslik.Text = bulanik_mantik.Durulama(maxlar_Sure, ortancalar_sure).ToString();
            materialSingleLineTextField3.Text = bulanik_mantik.Durulama(maxlar_Deterjan, ortancalar_deterjan).ToString();
        }


        public List<string> donus_hizi_uyelik_degeri = new List<string>();
        public List<string> sure_uyelik_degeri = new List<string>();
        public List<string> deterjan_miktai_uyelik_degeri = new List<string>();
        public void Uzman_kural_secimi()
        {

            for (int i = 0; i < bulanik_mantik.Hassas.Count(); i++)
            {
                for (int j = 0; j < bulanik_mantik.Mik.Count(); j++)
                {
                    for (int k = 0; k < bulanik_mantik.Kir.Count(); k++)
                    {
                        for (int l = 0; l < 27; l++)
                        {
                            if (bulanik_mantik.Hassas[i] == kural_listesi.Items[l].SubItems[1].Text && bulanik_mantik.Mik[j] == kural_listesi.Items[l].SubItems[2].Text && bulanik_mantik.Kir[k] == kural_listesi.Items[l].SubItems[3].Text)
                            {
                                mamdani_Sonucu.Add(bulanik_mantik.Hassasiyet_mamdani(bulanik_mantik.Hassas[i]));
                                mamdani_Sonucu.Add(bulanik_mantik.Miktar_mamdani(bulanik_mantik.Mik[j]));
                                mamdani_Sonucu.Add(bulanik_mantik.Kirlilik_mamdani(bulanik_mantik.Kir[k]));
                                min.Add(bulanik_mantik.Min_arama(mamdani_Sonucu));
                                mamdani_Sonucu.Clear();
                                kural_listesi.Items[l].Selected = true;
                                kural_listesi.Items[l].ForeColor = Color.White;
                                kural_listesi.Items[l].BackColor = Color.DarkBlue;
                                donus_hizi_uyelik_degeri.Add(kural_listesi.Items[l].SubItems[4].Text);
                                sure_uyelik_degeri.Add(kural_listesi.Items[l].SubItems[5].Text);
                                deterjan_miktai_uyelik_degeri.Add(kural_listesi.Items[l].SubItems[6].Text);
                            }
                        }
                    }
                }
            }
        }

        List<string> donusHiziTur = new List<string>();
        List<string> SureTur = new List<string>();
        List<string> DeterjanTur = new List<string>();
        public void Donus_hizini_kont_et()                // üyelik dercelerini hesaplar. kuralların
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (donus_hizi_uyelik_degeri[i] == donus_hizi_uyelik_degeri[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlar_Donus.Add(bulanik_mantik.Max_arama(max));
                        donusHiziTur.Add(donus_hizi_uyelik_degeri[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < donusHiziTur.Count(); i++)
            {
                ortancalar_donus.Add(bulanik_mantik.Donus_hızı_Ortanca(donusHiziTur[i]));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Zaman_kont_et()
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (sure_uyelik_degeri[i] == sure_uyelik_degeri[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlar_Sure.Add(bulanik_mantik.Max_arama(max));
                        SureTur.Add(sure_uyelik_degeri[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < SureTur.Count(); i++)
            {
                ortancalar_sure.Add(bulanik_mantik.Sure_Ortanca(SureTur[i]));
            }
        }

       
        public void Deterjan_kont_et()
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (deterjan_miktai_uyelik_degeri[i] == deterjan_miktai_uyelik_degeri[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlar_Deterjan.Add(bulanik_mantik.Max_arama(max));
                        DeterjanTur.Add(deterjan_miktai_uyelik_degeri[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < DeterjanTur.Count(); i++)
            {
                ortancalar_deterjan.Add(bulanik_mantik.Deretjan_Ortanca(DeterjanTur[i]));
            }
        }


      
       
    }


}