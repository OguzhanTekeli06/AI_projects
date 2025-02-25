using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eightpuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                comboBox1.Items.Add(i);
            }
            dataGridView1.ReadOnly = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView2.ReadOnly = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = Color.LightGray;
            cellStyle.ForeColor = Color.Black;
            cellStyle.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle = cellStyle;
            dataGridView2.DefaultCellStyle = cellStyle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int shape = dataGridView1.RowCount;

            HashSet<int> basdegerler = new HashSet<int>();
            HashSet<int> bitdegerler = new HashSet<int>();
            int[,] baslangicMatrisi = new int[shape, shape];
            int[,] bitisMatrisi = new int[shape, shape];

            for (int i = 0; i < shape; i++)
            {
                for (int j = 0; j < shape; j++)
                {
                    int baslangicValue;
                    int bitisValue;
                    try
                    {
                        if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out baslangicValue) &&
                        int.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out bitisValue))
                        {
                            baslangicMatrisi[i, j] = baslangicValue;
                            basdegerler.Add(baslangicValue);
                            bitisMatrisi[i, j] = bitisValue;
                            bitdegerler.Add(bitisValue);
                        }
                        else
                        {
                            MessageBox.Show("Matrisler doğru şekilde girdiğinizden emin olun!");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Verdi Tabloyu Daha Dikkatli Giriniz!" + ex);
                    }
                }
            }
            if (basdegerler.Count != shape * shape || bitdegerler.Count != shape * shape)
            {
                MessageBox.Show("Matrisler doğru şekilde girdiğinizden emin olun!!");
                return;
            }

            solution solver = new solution(baslangicMatrisi, bitisMatrisi, shape);
            List<int[,]> sonuclar = solver.Coz();
            if (sonuclar == null)
            {
                MessageBox.Show("Çözülemedi");
                return;
            }
            label5.Text = "Minimum Adım Sayısı:" + sonuclar.Count.ToString();
            int k = 1;
            foreach (var item in sonuclar)
            {
                string itemstr = "";
                listBox1.Items.Add(k.ToString() + ".Adım --------");
                k++;
                for (int i = 0; i < shape; i++)
                {
                    for (int j = 0; j < shape; j++)
                    {
                        itemstr += (item[i, j] + " ");
                    }
                    listBox1.Items.Add(itemstr);
                    itemstr = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(comboBox1.SelectedItem);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            for (int i = 0; i < size; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Rows.Add();
                dataGridView2.Columns.Add("", "");
                dataGridView2.Rows.Add();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
