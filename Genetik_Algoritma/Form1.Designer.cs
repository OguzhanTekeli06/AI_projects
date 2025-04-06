namespace Genetik_Algoritma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.baslat_btn = new System.Windows.Forms.Button();
            this.grafik1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kromozomUzunlugu_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.populasyonBoyutu_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caprazlamaOrani_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mutasyonOrani_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seckinlikOrani_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxJenerasyonSayisi_txtbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.temizle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslat_btn
            // 
            this.baslat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat_btn.Location = new System.Drawing.Point(16, 492);
            this.baslat_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslat_btn.Name = "baslat_btn";
            this.baslat_btn.Size = new System.Drawing.Size(195, 75);
            this.baslat_btn.TabIndex = 0;
            this.baslat_btn.Text = "BAŞLAT";
            this.baslat_btn.UseVisualStyleBackColor = true;
            this.baslat_btn.Click += new System.EventHandler(this.baslat_btn_Click);
            // 
            // grafik1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafik1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafik1.Legends.Add(legend1);
            this.grafik1.Location = new System.Drawing.Point(221, 15);
            this.grafik1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafik1.Name = "grafik1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafik1.Series.Add(series1);
            this.grafik1.Size = new System.Drawing.Size(1100, 635);
            this.grafik1.TabIndex = 1;
            this.grafik1.Text = "grafik1";
            // 
            // kromozomUzunlugu_txtbx
            // 
            this.kromozomUzunlugu_txtbx.Location = new System.Drawing.Point(16, 82);
            this.kromozomUzunlugu_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kromozomUzunlugu_txtbx.Name = "kromozomUzunlugu_txtbx";
            this.kromozomUzunlugu_txtbx.Size = new System.Drawing.Size(193, 22);
            this.kromozomUzunlugu_txtbx.TabIndex = 3;
            this.kromozomUzunlugu_txtbx.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kromozom Uzunluğu";
            // 
            // populasyonBoyutu_txtbx
            // 
            this.populasyonBoyutu_txtbx.Location = new System.Drawing.Point(16, 144);
            this.populasyonBoyutu_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.populasyonBoyutu_txtbx.Name = "populasyonBoyutu_txtbx";
            this.populasyonBoyutu_txtbx.Size = new System.Drawing.Size(193, 22);
            this.populasyonBoyutu_txtbx.TabIndex = 3;
            this.populasyonBoyutu_txtbx.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Popülasyon Boyutu";
            // 
            // caprazlamaOrani_txtbx
            // 
            this.caprazlamaOrani_txtbx.Location = new System.Drawing.Point(16, 209);
            this.caprazlamaOrani_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caprazlamaOrani_txtbx.Name = "caprazlamaOrani_txtbx";
            this.caprazlamaOrani_txtbx.Size = new System.Drawing.Size(193, 22);
            this.caprazlamaOrani_txtbx.TabIndex = 3;
            this.caprazlamaOrani_txtbx.Text = "0,8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çaprazlama Oranı";
            // 
            // mutasyonOrani_txtbx
            // 
            this.mutasyonOrani_txtbx.Location = new System.Drawing.Point(16, 278);
            this.mutasyonOrani_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutasyonOrani_txtbx.Name = "mutasyonOrani_txtbx";
            this.mutasyonOrani_txtbx.Size = new System.Drawing.Size(193, 22);
            this.mutasyonOrani_txtbx.TabIndex = 3;
            this.mutasyonOrani_txtbx.Text = "0,03";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mutasyon Oranı";
            // 
            // seckinlikOrani_txtbx
            // 
            this.seckinlikOrani_txtbx.Location = new System.Drawing.Point(16, 347);
            this.seckinlikOrani_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seckinlikOrani_txtbx.Name = "seckinlikOrani_txtbx";
            this.seckinlikOrani_txtbx.Size = new System.Drawing.Size(193, 22);
            this.seckinlikOrani_txtbx.TabIndex = 3;
            this.seckinlikOrani_txtbx.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seçkinlik Oranı";
            // 
            // maxJenerasyonSayisi_txtbx
            // 
            this.maxJenerasyonSayisi_txtbx.Location = new System.Drawing.Point(16, 416);
            this.maxJenerasyonSayisi_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxJenerasyonSayisi_txtbx.Name = "maxJenerasyonSayisi_txtbx";
            this.maxJenerasyonSayisi_txtbx.Size = new System.Drawing.Size(193, 22);
            this.maxJenerasyonSayisi_txtbx.TabIndex = 3;
            this.maxJenerasyonSayisi_txtbx.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max. Jenerasyon Sayısı";
            // 
            // temizle_btn
            // 
            this.temizle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle_btn.Location = new System.Drawing.Point(16, 575);
            this.temizle_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(195, 75);
            this.temizle_btn.TabIndex = 0;
            this.temizle_btn.Text = "TEMİZLE";
            this.temizle_btn.UseVisualStyleBackColor = true;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1337, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxJenerasyonSayisi_txtbx);
            this.Controls.Add(this.seckinlikOrani_txtbx);
            this.Controls.Add(this.mutasyonOrani_txtbx);
            this.Controls.Add(this.caprazlamaOrani_txtbx);
            this.Controls.Add(this.populasyonBoyutu_txtbx);
            this.Controls.Add(this.kromozomUzunlugu_txtbx);
            this.Controls.Add(this.grafik1);
            this.Controls.Add(this.temizle_btn);
            this.Controls.Add(this.baslat_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslat_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik1;
        private System.Windows.Forms.TextBox kromozomUzunlugu_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox populasyonBoyutu_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caprazlamaOrani_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mutasyonOrani_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seckinlikOrani_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxJenerasyonSayisi_txtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button temizle_btn;
    }
}

