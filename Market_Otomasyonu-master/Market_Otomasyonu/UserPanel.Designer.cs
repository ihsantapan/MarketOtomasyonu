namespace Market_Otomasyonu.UI
{
	partial class UserPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
			btnRapor = new Button();
			btnUrunEkle = new Button();
			btnKategoriEkle = new Button();
			btnSatisEkrani = new Button();
			btnKullaniciPaneli = new Button();
			pictureBox1 = new PictureBox();
			btnUygulamayiKapat = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnRapor
			// 
			btnRapor.BackColor = Color.Yellow;
			btnRapor.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnRapor.Location = new Point(34, 35);
			btnRapor.Name = "btnRapor";
			btnRapor.Size = new Size(191, 75);
			btnRapor.TabIndex = 0;
			btnRapor.Text = "RAPOR";
			btnRapor.UseVisualStyleBackColor = false;
			btnRapor.Click += btnRapor_Click;
			// 
			// btnUrunEkle
			// 
			btnUrunEkle.BackColor = Color.Red;
			btnUrunEkle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnUrunEkle.Location = new Point(231, 35);
			btnUrunEkle.Name = "btnUrunEkle";
			btnUrunEkle.Size = new Size(191, 75);
			btnUrunEkle.TabIndex = 0;
			btnUrunEkle.Text = "ÜRÜN EKLE";
			btnUrunEkle.UseVisualStyleBackColor = false;
			btnUrunEkle.Click += btnUrunEkle_Click;
			// 
			// btnKategoriEkle
			// 
			btnKategoriEkle.BackColor = Color.Red;
			btnKategoriEkle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnKategoriEkle.Location = new Point(34, 129);
			btnKategoriEkle.Name = "btnKategoriEkle";
			btnKategoriEkle.Size = new Size(191, 75);
			btnKategoriEkle.TabIndex = 0;
			btnKategoriEkle.Text = "KATEGORİ EKLE";
			btnKategoriEkle.UseVisualStyleBackColor = false;
			btnKategoriEkle.Click += btnKategoriEkle_Click;
			// 
			// btnSatisEkrani
			// 
			btnSatisEkrani.BackColor = Color.Chartreuse;
			btnSatisEkrani.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnSatisEkrani.Location = new Point(231, 129);
			btnSatisEkrani.Name = "btnSatisEkrani";
			btnSatisEkrani.Size = new Size(191, 75);
			btnSatisEkrani.TabIndex = 0;
			btnSatisEkrani.Text = "SATIŞ EKRANI";
			btnSatisEkrani.UseVisualStyleBackColor = false;
			btnSatisEkrani.Click += btnSatisEkrani_Click;
			// 
			// btnKullaniciPaneli
			// 
			btnKullaniciPaneli.BackColor = Color.Orange;
			btnKullaniciPaneli.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnKullaniciPaneli.Location = new Point(128, 225);
			btnKullaniciPaneli.Name = "btnKullaniciPaneli";
			btnKullaniciPaneli.Size = new Size(191, 75);
			btnKullaniciPaneli.TabIndex = 0;
			btnKullaniciPaneli.Text = "KULLANICI PANELİ";
			btnKullaniciPaneli.UseVisualStyleBackColor = false;
			btnKullaniciPaneli.Click += btnKullaniciPaneli_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(474, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(115, 109);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// btnUygulamayiKapat
			// 
			btnUygulamayiKapat.BackColor = Color.Transparent;
			btnUygulamayiKapat.BackgroundImage = (Image)resources.GetObject("btnUygulamayiKapat.BackgroundImage");
			btnUygulamayiKapat.BackgroundImageLayout = ImageLayout.Stretch;
			btnUygulamayiKapat.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnUygulamayiKapat.Location = new Point(531, 251);
			btnUygulamayiKapat.Name = "btnUygulamayiKapat";
			btnUygulamayiKapat.Size = new Size(48, 49);
			btnUygulamayiKapat.TabIndex = 6;
			btnUygulamayiKapat.UseVisualStyleBackColor = false;
			btnUygulamayiKapat.Click += btnUygulamayiKapat_Click;
			// 
			// UserPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(591, 310);
			Controls.Add(btnUygulamayiKapat);
			Controls.Add(pictureBox1);
			Controls.Add(btnSatisEkrani);
			Controls.Add(btnKategoriEkle);
			Controls.Add(btnUrunEkle);
			Controls.Add(btnKullaniciPaneli);
			Controls.Add(btnRapor);
			Name = "UserPanel";
			Text = "UserPanel";
			Load += UserPanel_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnRapor;
		private Button btnUrunEkle;
		private Button btnKategoriEkle;
		private Button btnSatisEkrani;
		private Button btnKullaniciPaneli;
		private PictureBox pictureBox1;
		private Button btnUygulamayiKapat;
	}
}