namespace Market_Otomasyonu.UI
{
	partial class AddUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
			btnSifreyiGoster = new Button();
			label2 = new Label();
			label1 = new Label();
			txtSifre = new TextBox();
			txtKullaniciAdi = new TextBox();
			btnKayitOlustur = new Button();
			grpKullanıcıEkle = new GroupBox();
			cmbCalismaBirimi = new ComboBox();
			rdbKadin = new RadioButton();
			rdbErkek = new RadioButton();
			txtSoyadı = new TextBox();
			txtAd = new TextBox();
			label6 = new Label();
			lblGüvenlikSeviyesi = new Label();
			label7 = new Label();
			label8 = new Label();
			label3 = new Label();
			label5 = new Label();
			txtSifreTekrar = new TextBox();
			label4 = new Label();
			grpKullanıcıEkle.SuspendLayout();
			SuspendLayout();
			// 
			// btnSifreyiGoster
			// 
			btnSifreyiGoster.BackgroundImage = (Image)resources.GetObject("btnSifreyiGoster.BackgroundImage");
			btnSifreyiGoster.BackgroundImageLayout = ImageLayout.Stretch;
			btnSifreyiGoster.Location = new Point(264, 222);
			btnSifreyiGoster.Name = "btnSifreyiGoster";
			btnSifreyiGoster.Size = new Size(32, 23);
			btnSifreyiGoster.TabIndex = 10;
			btnSifreyiGoster.UseVisualStyleBackColor = true;
			btnSifreyiGoster.MouseDown += btnSifreyiGoster_MouseDown;
			btnSifreyiGoster.MouseUp += btnSifreyiGoster_MouseUp;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(144, 200);
			label2.Name = "label2";
			label2.Size = new Size(38, 19);
			label2.TabIndex = 8;
			label2.Text = "Şifre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(123, 137);
			label1.Name = "label1";
			label1.Size = new Size(89, 19);
			label1.TabIndex = 9;
			label1.Text = "Kullanıcı Adı";
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(76, 222);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.Size = new Size(182, 23);
			txtSifre.TabIndex = 6;
			txtSifre.TextChanged += txtSifre_TextChanged;
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(76, 159);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(182, 23);
			txtKullaniciAdi.TabIndex = 7;
			// 
			// btnKayitOlustur
			// 
			btnKayitOlustur.BackColor = Color.LawnGreen;
			btnKayitOlustur.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnKayitOlustur.Location = new Point(12, 496);
			btnKayitOlustur.Name = "btnKayitOlustur";
			btnKayitOlustur.Size = new Size(334, 49);
			btnKayitOlustur.TabIndex = 11;
			btnKayitOlustur.Text = "ÇALIŞAN EKLE";
			btnKayitOlustur.UseVisualStyleBackColor = false;
			btnKayitOlustur.Click += btnKayitOlustur_Click;
			// 
			// grpKullanıcıEkle
			// 
			grpKullanıcıEkle.Controls.Add(cmbCalismaBirimi);
			grpKullanıcıEkle.Controls.Add(rdbKadin);
			grpKullanıcıEkle.Controls.Add(rdbErkek);
			grpKullanıcıEkle.Controls.Add(txtSoyadı);
			grpKullanıcıEkle.Controls.Add(txtAd);
			grpKullanıcıEkle.Controls.Add(txtKullaniciAdi);
			grpKullanıcıEkle.Controls.Add(btnSifreyiGoster);
			grpKullanıcıEkle.Controls.Add(label6);
			grpKullanıcıEkle.Controls.Add(lblGüvenlikSeviyesi);
			grpKullanıcıEkle.Controls.Add(label7);
			grpKullanıcıEkle.Controls.Add(label8);
			grpKullanıcıEkle.Controls.Add(label3);
			grpKullanıcıEkle.Controls.Add(label2);
			grpKullanıcıEkle.Controls.Add(label5);
			grpKullanıcıEkle.Controls.Add(txtSifreTekrar);
			grpKullanıcıEkle.Controls.Add(label4);
			grpKullanıcıEkle.Controls.Add(txtSifre);
			grpKullanıcıEkle.Controls.Add(label1);
			grpKullanıcıEkle.Location = new Point(12, 12);
			grpKullanıcıEkle.Name = "grpKullanıcıEkle";
			grpKullanıcıEkle.Size = new Size(334, 478);
			grpKullanıcıEkle.TabIndex = 12;
			grpKullanıcıEkle.TabStop = false;
			grpKullanıcıEkle.Text = "Kullanıcı Ekle";
			grpKullanıcıEkle.Enter += grpKullanıcıEkle_Enter;
			// 
			// cmbCalismaBirimi
			// 
			cmbCalismaBirimi.FormattingEnabled = true;
			cmbCalismaBirimi.Location = new Point(76, 363);
			cmbCalismaBirimi.Name = "cmbCalismaBirimi";
			cmbCalismaBirimi.Size = new Size(182, 23);
			cmbCalismaBirimi.TabIndex = 12;
			// 
			// rdbKadin
			// 
			rdbKadin.AutoSize = true;
			rdbKadin.Location = new Point(203, 432);
			rdbKadin.Name = "rdbKadin";
			rdbKadin.Size = new Size(55, 19);
			rdbKadin.TabIndex = 11;
			rdbKadin.TabStop = true;
			rdbKadin.Text = "Kadın";
			rdbKadin.UseVisualStyleBackColor = true;
			// 
			// rdbErkek
			// 
			rdbErkek.AutoSize = true;
			rdbErkek.Location = new Point(76, 432);
			rdbErkek.Name = "rdbErkek";
			rdbErkek.Size = new Size(53, 19);
			rdbErkek.TabIndex = 11;
			rdbErkek.TabStop = true;
			rdbErkek.Text = "Erkek";
			rdbErkek.UseVisualStyleBackColor = true;
			// 
			// txtSoyadı
			// 
			txtSoyadı.Location = new Point(76, 98);
			txtSoyadı.Name = "txtSoyadı";
			txtSoyadı.Size = new Size(182, 23);
			txtSoyadı.TabIndex = 7;
			// 
			// txtAd
			// 
			txtAd.Location = new Point(76, 37);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(182, 23);
			txtAd.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label6.Location = new Point(132, 403);
			label6.Name = "label6";
			label6.Size = new Size(59, 19);
			label6.TabIndex = 8;
			label6.Text = "Cinsiyet";
			// 
			// lblGüvenlikSeviyesi
			// 
			lblGüvenlikSeviyesi.AutoSize = true;
			lblGüvenlikSeviyesi.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point);
			lblGüvenlikSeviyesi.Location = new Point(172, 248);
			lblGüvenlikSeviyesi.Name = "lblGüvenlikSeviyesi";
			lblGüvenlikSeviyesi.Size = new Size(0, 14);
			lblGüvenlikSeviyesi.TabIndex = 8;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label7.Location = new Point(76, 248);
			label7.Name = "label7";
			label7.Size = new Size(90, 14);
			label7.TabIndex = 8;
			label7.Text = "Güvenlik Seviyesi";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label8.Location = new Point(109, 341);
			label8.Name = "label8";
			label8.Size = new Size(103, 19);
			label8.TabIndex = 8;
			label8.Text = "Çalışma Birimi";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(123, 277);
			label3.Name = "label3";
			label3.Size = new Size(82, 19);
			label3.TabIndex = 8;
			label3.Text = "Şifre Tekrar";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(140, 76);
			label5.Name = "label5";
			label5.Size = new Size(51, 19);
			label5.TabIndex = 9;
			label5.Text = "Soyadı";
			// 
			// txtSifreTekrar
			// 
			txtSifreTekrar.Location = new Point(76, 299);
			txtSifreTekrar.Name = "txtSifreTekrar";
			txtSifreTekrar.PasswordChar = '*';
			txtSifreTekrar.Size = new Size(182, 23);
			txtSifreTekrar.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(152, 15);
			label4.Name = "label4";
			label4.Size = new Size(30, 19);
			label4.TabIndex = 9;
			label4.Text = "Adı";
			// 
			// AddUsers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(365, 557);
			Controls.Add(grpKullanıcıEkle);
			Controls.Add(btnKayitOlustur);
			Name = "AddUsers";
			Text = "AddUsers";
			Load += AddUsers_Load;
			grpKullanıcıEkle.ResumeLayout(false);
			grpKullanıcıEkle.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button btnSifreyiGoster;
		private Label label2;
		private Label label1;
		private TextBox txtSifre;
		private TextBox txtKullaniciAdi;
		private Button btnKayitOlustur;
		private GroupBox grpKullanıcıEkle;
		private TextBox txtSoyadı;
		private TextBox txtAd;
		private Label label3;
		private Label label5;
		private TextBox txtSifreTekrar;
		private Label label4;
		private RadioButton rdbKadin;
		private RadioButton rdbErkek;
		private Label label6;
		private Label lblGüvenlikSeviyesi;
		private Label label7;
		private ComboBox cmbCalismaBirimi;
		private Label label8;
	}
}