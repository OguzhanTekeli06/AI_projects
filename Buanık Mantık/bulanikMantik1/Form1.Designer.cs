namespace bulanikMantik1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hassasiyet_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.hassasiyet_deger_girisi = new System.Windows.Forms.NumericUpDown();
            this.miktar_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.miktar_deger_girisi = new System.Windows.Forms.NumericUpDown();
            this.kirlilik_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.kirlilik_deger_girisi = new System.Windows.Forms.NumericUpDown();
            this.agirlikli_ort_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.Mamdami = new System.Windows.Forms.ListBox();
            this.donus_hizi_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.zaman_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.deterjan_mik_baslik = new MaterialSkin.Controls.MaterialLabel();
            this.donushizisonuc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sure_baslik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.hesapla_butonum = new MaterialSkin.Controls.MaterialRaisedButton();
            this.kural_listesi = new System.Windows.Forms.ListView();
            this.Kural = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hassaslık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mıktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kirlilık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DönüşHızı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Süre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeterjanMiktarı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grafikler = new System.Windows.Forms.PictureBox();
            this.lblHassaslikKume = new System.Windows.Forms.Label();
            this.lblMiktarKume = new System.Windows.Forms.Label();
            this.lblKirlilikKume = new System.Windows.Forms.Label();
            this.kume_baslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hassasiyet_deger_girisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miktar_deger_girisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirlilik_deger_girisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // hassasiyet_baslik
            // 
            this.hassasiyet_baslik.AutoSize = true;
            this.hassasiyet_baslik.Depth = 0;
            this.hassasiyet_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.hassasiyet_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hassasiyet_baslik.Location = new System.Drawing.Point(6, 36);
            this.hassasiyet_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.hassasiyet_baslik.Name = "hassasiyet_baslik";
            this.hassasiyet_baslik.Size = new System.Drawing.Size(114, 24);
            this.hassasiyet_baslik.TabIndex = 1;
            this.hassasiyet_baslik.Text = "Hassasiyet :";
            // 
            // hassasiyet_deger_girisi
            // 
            this.hassasiyet_deger_girisi.DecimalPlaces = 2;
            this.hassasiyet_deger_girisi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hassasiyet_deger_girisi.Location = new System.Drawing.Point(102, 36);
            this.hassasiyet_deger_girisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hassasiyet_deger_girisi.Name = "hassasiyet_deger_girisi";
            this.hassasiyet_deger_girisi.Size = new System.Drawing.Size(120, 35);
            this.hassasiyet_deger_girisi.TabIndex = 2;
            this.hassasiyet_deger_girisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hassasiyet_deger_girisi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // miktar_baslik
            // 
            this.miktar_baslik.AutoSize = true;
            this.miktar_baslik.Depth = 0;
            this.miktar_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.miktar_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.miktar_baslik.Location = new System.Drawing.Point(36, 63);
            this.miktar_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.miktar_baslik.Name = "miktar_baslik";
            this.miktar_baslik.Size = new System.Drawing.Size(74, 24);
            this.miktar_baslik.TabIndex = 1;
            this.miktar_baslik.Text = "Miktar :";
            // 
            // miktar_deger_girisi
            // 
            this.miktar_deger_girisi.DecimalPlaces = 2;
            this.miktar_deger_girisi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.miktar_deger_girisi.Location = new System.Drawing.Point(102, 64);
            this.miktar_deger_girisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.miktar_deger_girisi.Name = "miktar_deger_girisi";
            this.miktar_deger_girisi.Size = new System.Drawing.Size(120, 35);
            this.miktar_deger_girisi.TabIndex = 2;
            this.miktar_deger_girisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miktar_deger_girisi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // kirlilik_baslik
            // 
            this.kirlilik_baslik.AutoSize = true;
            this.kirlilik_baslik.Depth = 0;
            this.kirlilik_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.kirlilik_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kirlilik_baslik.Location = new System.Drawing.Point(37, 92);
            this.kirlilik_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.kirlilik_baslik.Name = "kirlilik_baslik";
            this.kirlilik_baslik.Size = new System.Drawing.Size(73, 24);
            this.kirlilik_baslik.TabIndex = 1;
            this.kirlilik_baslik.Text = "Kirlilik :";
            // 
            // kirlilik_deger_girisi
            // 
            this.kirlilik_deger_girisi.DecimalPlaces = 2;
            this.kirlilik_deger_girisi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kirlilik_deger_girisi.Location = new System.Drawing.Point(102, 93);
            this.kirlilik_deger_girisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kirlilik_deger_girisi.Name = "kirlilik_deger_girisi";
            this.kirlilik_deger_girisi.Size = new System.Drawing.Size(120, 35);
            this.kirlilik_deger_girisi.TabIndex = 2;
            this.kirlilik_deger_girisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kirlilik_deger_girisi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // agirlikli_ort_baslik
            // 
            this.agirlikli_ort_baslik.AutoSize = true;
            this.agirlikli_ort_baslik.Depth = 0;
            this.agirlikli_ort_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.agirlikli_ort_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.agirlikli_ort_baslik.Location = new System.Drawing.Point(35, 41);
            this.agirlikli_ort_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.agirlikli_ort_baslik.Name = "agirlikli_ort_baslik";
            this.agirlikli_ort_baslik.Size = new System.Drawing.Size(177, 24);
            this.agirlikli_ort_baslik.TabIndex = 3;
            this.agirlikli_ort_baslik.Text = "Ağırlıklı Ortalamalar";
            // 
            // Mamdami
            // 
            this.Mamdami.FormattingEnabled = true;
            this.Mamdami.ItemHeight = 24;
            this.Mamdami.Location = new System.Drawing.Point(15, 28);
            this.Mamdami.Name = "Mamdami";
            this.Mamdami.Size = new System.Drawing.Size(333, 148);
            this.Mamdami.TabIndex = 4;
            // 
            // donus_hizi_baslik
            // 
            this.donus_hizi_baslik.AutoSize = true;
            this.donus_hizi_baslik.Depth = 0;
            this.donus_hizi_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.donus_hizi_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.donus_hizi_baslik.Location = new System.Drawing.Point(69, 83);
            this.donus_hizi_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.donus_hizi_baslik.Name = "donus_hizi_baslik";
            this.donus_hizi_baslik.Size = new System.Drawing.Size(111, 24);
            this.donus_hizi_baslik.TabIndex = 1;
            this.donus_hizi_baslik.Text = "Dönüş Hızı :";
            // 
            // zaman_baslik
            // 
            this.zaman_baslik.AutoSize = true;
            this.zaman_baslik.Depth = 0;
            this.zaman_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.zaman_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zaman_baslik.Location = new System.Drawing.Point(96, 111);
            this.zaman_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.zaman_baslik.Name = "zaman_baslik";
            this.zaman_baslik.Size = new System.Drawing.Size(78, 24);
            this.zaman_baslik.TabIndex = 1;
            this.zaman_baslik.Text = "Zaman :";
            // 
            // deterjan_mik_baslik
            // 
            this.deterjan_mik_baslik.AutoSize = true;
            this.deterjan_mik_baslik.Depth = 0;
            this.deterjan_mik_baslik.Font = new System.Drawing.Font("Roboto", 11F);
            this.deterjan_mik_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deterjan_mik_baslik.Location = new System.Drawing.Point(35, 140);
            this.deterjan_mik_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.deterjan_mik_baslik.Name = "deterjan_mik_baslik";
            this.deterjan_mik_baslik.Size = new System.Drawing.Size(153, 24);
            this.deterjan_mik_baslik.TabIndex = 1;
            this.deterjan_mik_baslik.Text = "Deterjan Miktarı :";
            // 
            // donushizisonuc
            // 
            this.donushizisonuc.BackColor = System.Drawing.Color.White;
            this.donushizisonuc.Depth = 0;
            this.donushizisonuc.Enabled = false;
            this.donushizisonuc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donushizisonuc.ForeColor = System.Drawing.Color.White;
            this.donushizisonuc.Hint = "";
            this.donushizisonuc.Location = new System.Drawing.Point(192, 80);
            this.donushizisonuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.donushizisonuc.Name = "donushizisonuc";
            this.donushizisonuc.PasswordChar = '\0';
            this.donushizisonuc.SelectedText = "";
            this.donushizisonuc.SelectionLength = 0;
            this.donushizisonuc.SelectionStart = 0;
            this.donushizisonuc.Size = new System.Drawing.Size(201, 28);
            this.donushizisonuc.TabIndex = 5;
            this.donushizisonuc.Text = "donuş hızı..";
            this.donushizisonuc.UseSystemPasswordChar = false;
            // 
            // sure_baslik
            // 
            this.sure_baslik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sure_baslik.Depth = 0;
            this.sure_baslik.Enabled = false;
            this.sure_baslik.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.sure_baslik.ForeColor = System.Drawing.Color.White;
            this.sure_baslik.Hint = "";
            this.sure_baslik.Location = new System.Drawing.Point(192, 107);
            this.sure_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.sure_baslik.Name = "sure_baslik";
            this.sure_baslik.PasswordChar = '\0';
            this.sure_baslik.SelectedText = "";
            this.sure_baslik.SelectionLength = 0;
            this.sure_baslik.SelectionStart = 0;
            this.sure_baslik.Size = new System.Drawing.Size(201, 28);
            this.sure_baslik.TabIndex = 5;
            this.sure_baslik.Text = "süre..";
            this.sure_baslik.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Enabled = false;
            this.materialSingleLineTextField3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.materialSingleLineTextField3.ForeColor = System.Drawing.Color.White;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(192, 137);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(201, 28);
            this.materialSingleLineTextField3.TabIndex = 5;
            this.materialSingleLineTextField3.Text = "deterjan miktarı..";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // hesapla_butonum
            // 
            this.hesapla_butonum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hesapla_butonum.Depth = 0;
            this.hesapla_butonum.ForeColor = System.Drawing.Color.LightCoral;
            this.hesapla_butonum.Location = new System.Drawing.Point(28, 146);
            this.hesapla_butonum.MouseState = MaterialSkin.MouseState.HOVER;
            this.hesapla_butonum.Name = "hesapla_butonum";
            this.hesapla_butonum.Primary = true;
            this.hesapla_butonum.Size = new System.Drawing.Size(355, 42);
            this.hesapla_butonum.TabIndex = 6;
            this.hesapla_butonum.Text = "HESAPLA";
            this.hesapla_butonum.UseVisualStyleBackColor = false;
            this.hesapla_butonum.Click += new System.EventHandler(this.buton);
            // 
            // kural_listesi
            // 
            this.kural_listesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kural_listesi.BackColor = System.Drawing.Color.Gainsboro;
            this.kural_listesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kural,
            this.Hassaslık,
            this.Mıktar,
            this.Kirlilık,
            this.DönüşHızı,
            this.Süre,
            this.DeterjanMiktarı});
            this.kural_listesi.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kural_listesi.HideSelection = false;
            this.kural_listesi.Location = new System.Drawing.Point(26, 298);
            this.kural_listesi.Margin = new System.Windows.Forms.Padding(2);
            this.kural_listesi.Name = "kural_listesi";
            this.kural_listesi.Size = new System.Drawing.Size(693, 409);
            this.kural_listesi.TabIndex = 7;
            this.kural_listesi.UseCompatibleStateImageBehavior = false;
            this.kural_listesi.View = System.Windows.Forms.View.Details;
            // 
            // Kural
            // 
            this.Kural.Text = "Kural No ";
            this.Kural.Width = 78;
            // 
            // Hassaslık
            // 
            this.Hassaslık.Text = "Hassasiyet";
            this.Hassaslık.Width = 104;
            // 
            // Mıktar
            // 
            this.Mıktar.Text = "Miktar";
            this.Mıktar.Width = 86;
            // 
            // Kirlilık
            // 
            this.Kirlilık.Text = "Kirlilık";
            this.Kirlilık.Width = 77;
            // 
            // DönüşHızı
            // 
            this.DönüşHızı.Text = "Dönüş Hızı";
            this.DönüşHızı.Width = 119;
            // 
            // Süre
            // 
            this.Süre.Text = "Zaman";
            this.Süre.Width = 90;
            // 
            // DeterjanMiktarı
            // 
            this.DeterjanMiktarı.Text = "Deterjan Miktarı";
            this.DeterjanMiktarı.Width = 132;
            // 
            // grafikler
            // 
            this.grafikler.Image = ((System.Drawing.Image)(resources.GetObject("grafikler.Image")));
            this.grafikler.Location = new System.Drawing.Point(49, 25);
            this.grafikler.Name = "grafikler";
            this.grafikler.Size = new System.Drawing.Size(455, 370);
            this.grafikler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grafikler.TabIndex = 8;
            this.grafikler.TabStop = false;
            // 
            // lblHassaslikKume
            // 
            this.lblHassaslikKume.AutoSize = true;
            this.lblHassaslikKume.BackColor = System.Drawing.Color.White;
            this.lblHassaslikKume.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHassaslikKume.Location = new System.Drawing.Point(250, 45);
            this.lblHassaslikKume.Name = "lblHassaslikKume";
            this.lblHassaslikKume.Size = new System.Drawing.Size(174, 21);
            this.lblHassaslikKume.TabIndex = 9;
            this.lblHassaslikKume.Text = "hassasiyet kümesi";
            // 
            // lblMiktarKume
            // 
            this.lblMiktarKume.AutoSize = true;
            this.lblMiktarKume.BackColor = System.Drawing.Color.White;
            this.lblMiktarKume.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiktarKume.Location = new System.Drawing.Point(250, 77);
            this.lblMiktarKume.Name = "lblMiktarKume";
            this.lblMiktarKume.Size = new System.Drawing.Size(141, 21);
            this.lblMiktarKume.TabIndex = 10;
            this.lblMiktarKume.Text = "miktar kümesi";
            // 
            // lblKirlilikKume
            // 
            this.lblKirlilikKume.AutoSize = true;
            this.lblKirlilikKume.BackColor = System.Drawing.Color.White;
            this.lblKirlilikKume.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKirlilikKume.Location = new System.Drawing.Point(250, 104);
            this.lblKirlilikKume.Name = "lblKirlilikKume";
            this.lblKirlilikKume.Size = new System.Drawing.Size(146, 21);
            this.lblKirlilikKume.TabIndex = 11;
            this.lblKirlilikKume.Text = "kirlilik kümesi";
            // 
            // kume_baslik
            // 
            this.kume_baslik.AutoSize = true;
            this.kume_baslik.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kume_baslik.Location = new System.Drawing.Point(260, 10);
            this.kume_baslik.Name = "kume_baslik";
            this.kume_baslik.Size = new System.Drawing.Size(94, 21);
            this.kume_baslik.TabIndex = 13;
            this.kume_baslik.Text = "Kümeler ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.sure_baslik);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField3);
            this.groupBox1.Controls.Add(this.donus_hizi_baslik);
            this.groupBox1.Controls.Add(this.donushizisonuc);
            this.groupBox1.Controls.Add(this.agirlikli_ort_baslik);
            this.groupBox1.Controls.Add(this.zaman_baslik);
            this.groupBox1.Controls.Add(this.deterjan_mik_baslik);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 208);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durulaştırma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.hassasiyet_baslik);
            this.groupBox2.Controls.Add(this.miktar_baslik);
            this.groupBox2.Controls.Add(this.kume_baslik);
            this.groupBox2.Controls.Add(this.kirlilik_baslik);
            this.groupBox2.Controls.Add(this.hassasiyet_deger_girisi);
            this.groupBox2.Controls.Add(this.hesapla_butonum);
            this.groupBox2.Controls.Add(this.lblKirlilikKume);
            this.groupBox2.Controls.Add(this.miktar_deger_girisi);
            this.groupBox2.Controls.Add(this.lblMiktarKume);
            this.groupBox2.Controls.Add(this.kirlilik_deger_girisi);
            this.groupBox2.Controls.Add(this.lblHassaslikKume);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 208);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş Değeleri";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.Mamdami);
            this.groupBox3.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(932, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 208);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesaplamalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÇAMAŞIR MAKİNESİ PROJESİ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.grafikler);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(746, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 409);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GRAFİKLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1331, 746);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kural_listesi);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bulanık Mantık Çamaşır Makinesi   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hassasiyet_deger_girisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miktar_deger_girisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirlilik_deger_girisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel hassasiyet_baslik;
        private System.Windows.Forms.NumericUpDown hassasiyet_deger_girisi;
        private MaterialSkin.Controls.MaterialLabel miktar_baslik;
        private System.Windows.Forms.NumericUpDown miktar_deger_girisi;
        private MaterialSkin.Controls.MaterialLabel kirlilik_baslik;
        private System.Windows.Forms.NumericUpDown kirlilik_deger_girisi;
        private MaterialSkin.Controls.MaterialLabel agirlikli_ort_baslik;
        private System.Windows.Forms.ListBox Mamdami;
        private MaterialSkin.Controls.MaterialLabel donus_hizi_baslik;
        private MaterialSkin.Controls.MaterialLabel zaman_baslik;
        private MaterialSkin.Controls.MaterialLabel deterjan_mik_baslik;
        private MaterialSkin.Controls.MaterialSingleLineTextField donushizisonuc;
        private MaterialSkin.Controls.MaterialSingleLineTextField sure_baslik;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialRaisedButton hesapla_butonum;
        private System.Windows.Forms.ListView kural_listesi;
        private System.Windows.Forms.ColumnHeader Hassaslık;
        private System.Windows.Forms.ColumnHeader Mıktar;
        private System.Windows.Forms.ColumnHeader Kirlilık;
        private System.Windows.Forms.ColumnHeader DönüşHızı;
        private System.Windows.Forms.ColumnHeader Süre;
        private System.Windows.Forms.ColumnHeader DeterjanMiktarı;
        private System.Windows.Forms.ColumnHeader Kural;
        private System.Windows.Forms.PictureBox grafikler;
        private System.Windows.Forms.Label lblHassaslikKume;
        private System.Windows.Forms.Label lblMiktarKume;
        private System.Windows.Forms.Label lblKirlilikKume;
        private System.Windows.Forms.Label kume_baslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
