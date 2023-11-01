namespace Market_Otomasyonu.UI
{
	partial class UserPanelSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanelSetting));
			lstKisiler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			btnSil = new Button();
			btnAktifYap = new Button();
			grpKullaniciBilgileri = new GroupBox();
			cmbCalismaBirimi = new ComboBox();
			txtAd = new TextBox();
			label4 = new Label();
			btnPasifYap = new Button();
			txtKullanıcıAdı = new TextBox();
			txtSoyad = new TextBox();
			label1 = new Label();
			label10 = new Label();
			label2 = new Label();
			label11 = new Label();
			btnGuncelle = new Button();
			btnKullaniciEkle = new Button();
			grpKullaniciBilgileri.SuspendLayout();
			SuspendLayout();
			// 
			// lstKisiler
			// 
			lstKisiler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			lstKisiler.FullRowSelect = true;
			lstKisiler.GridLines = true;
			lstKisiler.Location = new Point(12, 281);
			lstKisiler.Name = "lstKisiler";
			lstKisiler.Size = new Size(612, 298);
			lstKisiler.TabIndex = 0;
			lstKisiler.UseCompatibleStateImageBehavior = false;
			lstKisiler.View = View.Details;
			lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Adı";
			columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Soyadı";
			columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Birimi";
			columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Çalışıyor Mu ?";
			columnHeader4.Width = 150;
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.Red;
			btnSil.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
			btnSil.Location = new Point(381, 221);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(60, 36);
			btnSil.TabIndex = 5;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			// 
			// btnAktifYap
			// 
			btnAktifYap.BackColor = Color.Orange;
			btnAktifYap.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAktifYap.Location = new Point(218, 41);
			btnAktifYap.Name = "btnAktifYap";
			btnAktifYap.Size = new Size(103, 37);
			btnAktifYap.TabIndex = 6;
			btnAktifYap.Text = "Aktif Yap";
			btnAktifYap.UseVisualStyleBackColor = false;
			btnAktifYap.Click += btnAktifYap_Click;
			// 
			// grpKullaniciBilgileri
			// 
			grpKullaniciBilgileri.Controls.Add(cmbCalismaBirimi);
			grpKullaniciBilgileri.Controls.Add(txtAd);
			grpKullaniciBilgileri.Controls.Add(btnSil);
			grpKullaniciBilgileri.Controls.Add(label4);
			grpKullaniciBilgileri.Controls.Add(btnGuncelle);
			grpKullaniciBilgileri.Controls.Add(btnPasifYap);
			grpKullaniciBilgileri.Controls.Add(txtKullanıcıAdı);
			grpKullaniciBilgileri.Controls.Add(btnAktifYap);
			grpKullaniciBilgileri.Controls.Add(txtSoyad);
			grpKullaniciBilgileri.Controls.Add(label1);
			grpKullaniciBilgileri.Controls.Add(label10);
			grpKullaniciBilgileri.Controls.Add(label2);
			grpKullaniciBilgileri.Controls.Add(label11);
			grpKullaniciBilgileri.Location = new Point(12, 12);
			grpKullaniciBilgileri.Name = "grpKullaniciBilgileri";
			grpKullaniciBilgileri.Size = new Size(447, 263);
			grpKullaniciBilgileri.TabIndex = 10;
			grpKullaniciBilgileri.TabStop = false;
			grpKullaniciBilgileri.Text = "Bilgileri Güncelle";
			// 
			// cmbCalismaBirimi
			// 
			cmbCalismaBirimi.FormattingEnabled = true;
			cmbCalismaBirimi.Location = new Point(6, 196);
			cmbCalismaBirimi.Name = "cmbCalismaBirimi";
			cmbCalismaBirimi.Size = new Size(182, 23);
			cmbCalismaBirimi.TabIndex = 12;
			// 
			// txtAd
			// 
			txtAd.Location = new Point(6, 41);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(182, 23);
			txtAd.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(6, 19);
			label4.Name = "label4";
			label4.Size = new Size(30, 19);
			label4.TabIndex = 9;
			label4.Text = "Adı";
			// 
			// btnPasifYap
			// 
			btnPasifYap.BackColor = Color.Chartreuse;
			btnPasifYap.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnPasifYap.Location = new Point(327, 41);
			btnPasifYap.Name = "btnPasifYap";
			btnPasifYap.Size = new Size(103, 37);
			btnPasifYap.TabIndex = 6;
			btnPasifYap.Text = "Pasif Yap";
			btnPasifYap.UseVisualStyleBackColor = false;
			btnPasifYap.Click += btnPasifYap_Click;
			// 
			// txtKullanıcıAdı
			// 
			txtKullanıcıAdı.Location = new Point(6, 139);
			txtKullanıcıAdı.Name = "txtKullanıcıAdı";
			txtKullanıcıAdı.Size = new Size(182, 23);
			txtKullanıcıAdı.TabIndex = 7;
			// 
			// txtSoyad
			// 
			txtSoyad.Location = new Point(6, 90);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(182, 23);
			txtSoyad.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(6, 116);
			label1.Name = "label1";
			label1.Size = new Size(89, 19);
			label1.TabIndex = 9;
			label1.Text = "Kullanıcı Adı";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label10.Location = new Point(6, 68);
			label10.Name = "label10";
			label10.Size = new Size(51, 19);
			label10.TabIndex = 9;
			label10.Text = "Soyadı";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(218, 22);
			label2.Name = "label2";
			label2.Size = new Size(208, 15);
			label2.TabIndex = 8;
			label2.Text = "Çalışanın Durumunu Değiştirebilirsiniz";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label11.Location = new Point(6, 174);
			label11.Name = "label11";
			label11.Size = new Size(103, 19);
			label11.TabIndex = 8;
			label11.Text = "Çalışma Birimi";
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = Color.BurlyWood;
			btnGuncelle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
			btnGuncelle.Location = new Point(228, 221);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(147, 36);
			btnGuncelle.TabIndex = 6;
			btnGuncelle.Text = "Güncelle";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// btnKullaniciEkle
			// 
			btnKullaniciEkle.BackColor = Color.Transparent;
			btnKullaniciEkle.BackgroundImage = (Image)resources.GetObject("btnKullaniciEkle.BackgroundImage");
			btnKullaniciEkle.BackgroundImageLayout = ImageLayout.Stretch;
			btnKullaniciEkle.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnKullaniciEkle.Location = new Point(549, 12);
			btnKullaniciEkle.Name = "btnKullaniciEkle";
			btnKullaniciEkle.Size = new Size(65, 64);
			btnKullaniciEkle.TabIndex = 12;
			btnKullaniciEkle.UseVisualStyleBackColor = false;
			btnKullaniciEkle.Click += btnKullaniciEkle_Click;
			// 
			// UserPanelSetting
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(626, 587);
			Controls.Add(btnKullaniciEkle);
			Controls.Add(grpKullaniciBilgileri);
			Controls.Add(lstKisiler);
			Name = "UserPanelSetting";
			Text = "UserPanelSetting";
			Load += UserPanelSetting_Load;
			grpKullaniciBilgileri.ResumeLayout(false);
			grpKullaniciBilgileri.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ListView lstKisiler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Button btnSil;
		private Button btnAktifYap;
		private GroupBox grpKullaniciBilgileri;
		private Button btnPasifYap;
		private Button btnGuncelle;
		private ComboBox cmbCalismaBirimi;
		private TextBox txtAd;
		private Label label4;
		private TextBox txtKullanıcıAdı;
		private TextBox txtSoyad;
		private Label label1;
		private Label label10;
		private Label label11;
		private Label label2;
		private Button btnKullaniciEkle;
	}
}