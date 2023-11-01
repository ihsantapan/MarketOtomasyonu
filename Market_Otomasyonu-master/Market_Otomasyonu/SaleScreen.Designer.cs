namespace Market_Otomasyonu.UI
{
	partial class SaleScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleScreen));
			grpUrunEkle = new GroupBox();
			nmrAdet = new NumericUpDown();
			label1 = new Label();
			txtUrunAra = new TextBox();
			lstArananUrunler = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			btnSiparisiTamamla = new Button();
			label6 = new Label();
			lstSiparisler = new ListView();
			columnHeader7 = new ColumnHeader();
			columnHeader14 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			columnHeader12 = new ColumnHeader();
			columnHeader1 = new ColumnHeader();
			columnHeader13 = new ColumnHeader();
			grpFiyatAlani = new GroupBox();
			label8 = new Label();
			lblToplamFiyat = new Label();
			lblToplamSatisAdedi = new Label();
			label7 = new Label();
			btnSiparisEkle = new Button();
			grpOdemeYontemi = new GroupBox();
			rdbKrediKarti = new RadioButton();
			rdbNakit = new RadioButton();
			btnSiparisSil = new Button();
			grpUrunAra = new GroupBox();
			grpUrunListesi = new GroupBox();
			pictureBox1 = new PictureBox();
			columnHeader6 = new ColumnHeader();
			grpUrunEkle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
			grpFiyatAlani.SuspendLayout();
			grpOdemeYontemi.SuspendLayout();
			grpUrunAra.SuspendLayout();
			grpUrunListesi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// grpUrunEkle
			// 
			grpUrunEkle.Controls.Add(nmrAdet);
			grpUrunEkle.Controls.Add(label1);
			grpUrunEkle.Location = new Point(431, 47);
			grpUrunEkle.Name = "grpUrunEkle";
			grpUrunEkle.Size = new Size(205, 77);
			grpUrunEkle.TabIndex = 11;
			grpUrunEkle.TabStop = false;
			grpUrunEkle.Text = "Ürün Ekleme Sayfası";
			// 
			// nmrAdet
			// 
			nmrAdet.Location = new Point(65, 31);
			nmrAdet.Name = "nmrAdet";
			nmrAdet.Size = new Size(120, 23);
			nmrAdet.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(17, 31);
			label1.Name = "label1";
			label1.Size = new Size(42, 19);
			label1.TabIndex = 0;
			label1.Text = "Adet";
			// 
			// txtUrunAra
			// 
			txtUrunAra.Location = new Point(106, 18);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(259, 23);
			txtUrunAra.TabIndex = 1;
			txtUrunAra.TextChanged += txtUrunAra_TextChanged;
			// 
			// lstArananUrunler
			// 
			lstArananUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4, columnHeader3, columnHeader6, columnHeader5 });
			lstArananUrunler.FullRowSelect = true;
			lstArananUrunler.GridLines = true;
			lstArananUrunler.Location = new Point(16, 47);
			lstArananUrunler.Name = "lstArananUrunler";
			lstArananUrunler.Size = new Size(395, 207);
			lstArananUrunler.TabIndex = 10;
			lstArananUrunler.UseCompatibleStateImageBehavior = false;
			lstArananUrunler.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Marka";
			columnHeader4.Width = 70;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Birimi";
			columnHeader3.Width = 70;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Fiyat";
			columnHeader5.Width = 70;
			// 
			// btnSiparisiTamamla
			// 
			btnSiparisiTamamla.BackColor = Color.SpringGreen;
			btnSiparisiTamamla.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnSiparisiTamamla.Location = new Point(1002, 527);
			btnSiparisiTamamla.Name = "btnSiparisiTamamla";
			btnSiparisiTamamla.Size = new Size(226, 122);
			btnSiparisiTamamla.TabIndex = 9;
			btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
			btnSiparisiTamamla.UseVisualStyleBackColor = false;
			btnSiparisiTamamla.Click += btnSiparisiTamamla_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(16, 18);
			label6.Name = "label6";
			label6.Size = new Size(71, 19);
			label6.TabIndex = 0;
			label6.Text = "Ürün Ara";
			// 
			// lstSiparisler
			// 
			lstSiparisler.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader14, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader1, columnHeader13 });
			lstSiparisler.FullRowSelect = true;
			lstSiparisler.GridLines = true;
			lstSiparisler.Location = new Point(6, 22);
			lstSiparisler.Name = "lstSiparisler";
			lstSiparisler.Size = new Size(931, 341);
			lstSiparisler.TabIndex = 12;
			lstSiparisler.UseCompatibleStateImageBehavior = false;
			lstSiparisler.View = View.Details;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Ürün Adı";
			columnHeader7.Width = 100;
			// 
			// columnHeader14
			// 
			columnHeader14.Text = "Marka";
			// 
			// columnHeader8
			// 
			columnHeader8.DisplayIndex = 3;
			columnHeader8.Text = "Kategori";
			columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			columnHeader9.DisplayIndex = 2;
			columnHeader9.Text = "Birimi";
			columnHeader9.Width = 100;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Birim Fiyatı";
			columnHeader10.Width = 100;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "Stok Adedi";
			columnHeader11.Width = 100;
			// 
			// columnHeader12
			// 
			columnHeader12.Text = "Son Kullanım Tarihi";
			columnHeader12.Width = 120;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Adet";
			columnHeader1.Width = 120;
			// 
			// columnHeader13
			// 
			columnHeader13.Text = "Toplam Fiyat";
			columnHeader13.Width = 120;
			// 
			// grpFiyatAlani
			// 
			grpFiyatAlani.Controls.Add(label8);
			grpFiyatAlani.Controls.Add(lblToplamFiyat);
			grpFiyatAlani.Controls.Add(lblToplamSatisAdedi);
			grpFiyatAlani.Controls.Add(label7);
			grpFiyatAlani.Location = new Point(996, 417);
			grpFiyatAlani.Name = "grpFiyatAlani";
			grpFiyatAlani.Size = new Size(232, 104);
			grpFiyatAlani.TabIndex = 13;
			grpFiyatAlani.TabStop = false;
			grpFiyatAlani.Text = "Tutar";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(6, 63);
			label8.Name = "label8";
			label8.Size = new Size(96, 19);
			label8.TabIndex = 0;
			label8.Text = "Toplam Fiyat";
			// 
			// lblToplamFiyat
			// 
			lblToplamFiyat.AutoSize = true;
			lblToplamFiyat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblToplamFiyat.Location = new Point(189, 63);
			lblToplamFiyat.Name = "lblToplamFiyat";
			lblToplamFiyat.Size = new Size(17, 19);
			lblToplamFiyat.TabIndex = 0;
			lblToplamFiyat.Text = "0";
			// 
			// lblToplamSatisAdedi
			// 
			lblToplamSatisAdedi.AutoSize = true;
			lblToplamSatisAdedi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblToplamSatisAdedi.Location = new Point(189, 29);
			lblToplamSatisAdedi.Name = "lblToplamSatisAdedi";
			lblToplamSatisAdedi.Size = new Size(17, 19);
			lblToplamSatisAdedi.TabIndex = 0;
			lblToplamSatisAdedi.Text = "0";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(6, 29);
			label7.Name = "label7";
			label7.Size = new Size(138, 19);
			label7.TabIndex = 0;
			label7.Text = "Toplam Satış Adedi";
			// 
			// btnSiparisEkle
			// 
			btnSiparisEkle.BackColor = Color.Chartreuse;
			btnSiparisEkle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSiparisEkle.Location = new Point(431, 211);
			btnSiparisEkle.Name = "btnSiparisEkle";
			btnSiparisEkle.Size = new Size(205, 43);
			btnSiparisEkle.TabIndex = 9;
			btnSiparisEkle.Text = "SİPARİŞ EKLE";
			btnSiparisEkle.UseVisualStyleBackColor = false;
			btnSiparisEkle.Click += btnSiparisEkle_Click;
			// 
			// grpOdemeYontemi
			// 
			grpOdemeYontemi.Controls.Add(rdbKrediKarti);
			grpOdemeYontemi.Controls.Add(rdbNakit);
			grpOdemeYontemi.Location = new Point(996, 335);
			grpOdemeYontemi.Name = "grpOdemeYontemi";
			grpOdemeYontemi.Size = new Size(232, 76);
			grpOdemeYontemi.TabIndex = 13;
			grpOdemeYontemi.TabStop = false;
			grpOdemeYontemi.Text = "Ödeme Yöntemi";
			// 
			// rdbKrediKarti
			// 
			rdbKrediKarti.AutoSize = true;
			rdbKrediKarti.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			rdbKrediKarti.Location = new Point(127, 32);
			rdbKrediKarti.Name = "rdbKrediKarti";
			rdbKrediKarti.Size = new Size(99, 23);
			rdbKrediKarti.TabIndex = 0;
			rdbKrediKarti.TabStop = true;
			rdbKrediKarti.Text = "Kredi Kartı";
			rdbKrediKarti.UseVisualStyleBackColor = true;
			// 
			// rdbNakit
			// 
			rdbNakit.AutoSize = true;
			rdbNakit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			rdbNakit.Location = new Point(6, 32);
			rdbNakit.Name = "rdbNakit";
			rdbNakit.Size = new Size(64, 23);
			rdbNakit.TabIndex = 0;
			rdbNakit.TabStop = true;
			rdbNakit.Text = "Nakit";
			rdbNakit.UseVisualStyleBackColor = true;
			// 
			// btnSiparisSil
			// 
			btnSiparisSil.BackColor = Color.Red;
			btnSiparisSil.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSiparisSil.Location = new Point(642, 211);
			btnSiparisSil.Name = "btnSiparisSil";
			btnSiparisSil.Size = new Size(203, 43);
			btnSiparisSil.TabIndex = 9;
			btnSiparisSil.Text = "SİPARİŞİ KALDIR";
			btnSiparisSil.UseVisualStyleBackColor = false;
			btnSiparisSil.Click += btnSiparisSil_Click;
			// 
			// grpUrunAra
			// 
			grpUrunAra.Controls.Add(label6);
			grpUrunAra.Controls.Add(txtUrunAra);
			grpUrunAra.Controls.Add(lstArananUrunler);
			grpUrunAra.Controls.Add(grpUrunEkle);
			grpUrunAra.Controls.Add(btnSiparisSil);
			grpUrunAra.Controls.Add(btnSiparisEkle);
			grpUrunAra.Location = new Point(12, 12);
			grpUrunAra.Name = "grpUrunAra";
			grpUrunAra.Size = new Size(858, 260);
			grpUrunAra.TabIndex = 14;
			grpUrunAra.TabStop = false;
			// 
			// grpUrunListesi
			// 
			grpUrunListesi.Controls.Add(lstSiparisler);
			grpUrunListesi.Location = new Point(12, 286);
			grpUrunListesi.Name = "grpUrunListesi";
			grpUrunListesi.Size = new Size(958, 374);
			grpUrunListesi.TabIndex = 15;
			grpUrunListesi.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(964, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(275, 268);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 16;
			pictureBox1.TabStop = false;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Stok Miktarı";
			columnHeader6.Width = 70;
			// 
			// SaleScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1251, 672);
			Controls.Add(pictureBox1);
			Controls.Add(grpUrunListesi);
			Controls.Add(grpUrunAra);
			Controls.Add(grpOdemeYontemi);
			Controls.Add(grpFiyatAlani);
			Controls.Add(btnSiparisiTamamla);
			Name = "SaleScreen";
			Text = "SaleScreen";
			Load += SaleScreen_Load;
			grpUrunEkle.ResumeLayout(false);
			grpUrunEkle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
			grpFiyatAlani.ResumeLayout(false);
			grpFiyatAlani.PerformLayout();
			grpOdemeYontemi.ResumeLayout(false);
			grpOdemeYontemi.PerformLayout();
			grpUrunAra.ResumeLayout(false);
			grpUrunAra.PerformLayout();
			grpUrunListesi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpUrunEkle;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Label label4;
		private NumericUpDown nmrStokAdedi;
		private NumericUpDown nmrBirimFiyat;
		private ComboBox cmbKategori;
		private ComboBox cmbBirim;
		private TextBox txtUrunAra;
		private ListView lstArananUrunler;
		private ColumnHeader columnHeader2;
		private Button btnSil;
		private Button btnGuncelle;
		private Button btnSiparisiTamamla;
		private Label label6;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ListView lstSiparisler;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private ColumnHeader columnHeader11;
		private ColumnHeader columnHeader12;
		private GroupBox grpFiyatAlani;
		private Label label7;
		private ColumnHeader columnHeader14;
		private Label label8;
		private Label lblToplamFiyat;
		private Label lblToplamSatisAdedi;
		private NumericUpDown nmrAdet;
		private Button btnSiparisEkle;
		private GroupBox grpOdemeYontemi;
		private RadioButton rdbKrediKarti;
		private RadioButton rdbNakit;
		private Button btnSiparisSil;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader13;
		private GroupBox grpUrunAra;
		private GroupBox grpUrunListesi;
		private PictureBox pictureBox1;
		private ColumnHeader columnHeader6;
	}
}