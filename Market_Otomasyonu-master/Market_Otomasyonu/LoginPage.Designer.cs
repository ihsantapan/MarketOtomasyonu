namespace Market_Otomasyonu.UI
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			grpGirisPaneli = new GroupBox();
			pictureBox1 = new PictureBox();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			btnSifreyiGoster = new Button();
			label2 = new Label();
			label1 = new Label();
			txtSifre = new TextBox();
			txtKullaniciAdi = new TextBox();
			btnGirisYap = new Button();
			btnUygulamayiKapat = new Button();
			grpGirisPaneli.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// grpGirisPaneli
			// 
			grpGirisPaneli.Controls.Add(pictureBox1);
			grpGirisPaneli.Controls.Add(button3);
			grpGirisPaneli.Controls.Add(button2);
			grpGirisPaneli.Controls.Add(button1);
			grpGirisPaneli.Controls.Add(btnSifreyiGoster);
			grpGirisPaneli.Controls.Add(label2);
			grpGirisPaneli.Controls.Add(label1);
			grpGirisPaneli.Controls.Add(txtSifre);
			grpGirisPaneli.Controls.Add(txtKullaniciAdi);
			grpGirisPaneli.Location = new Point(12, 12);
			grpGirisPaneli.Name = "grpGirisPaneli";
			grpGirisPaneli.Size = new Size(612, 215);
			grpGirisPaneli.TabIndex = 0;
			grpGirisPaneli.TabStop = false;
			grpGirisPaneli.Text = "Giriş Paneli";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(305, 9);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(307, 200);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// button3
			// 
			button3.Location = new Point(6, 142);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 3;
			button3.Text = "ebru";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(6, 113);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "ihsan";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(6, 84);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "enes";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btnSifreyiGoster
			// 
			btnSifreyiGoster.BackgroundImage = (Image)resources.GetObject("btnSifreyiGoster.BackgroundImage");
			btnSifreyiGoster.BackgroundImageLayout = ImageLayout.Stretch;
			btnSifreyiGoster.Location = new Point(250, 171);
			btnSifreyiGoster.Name = "btnSifreyiGoster";
			btnSifreyiGoster.Size = new Size(32, 23);
			btnSifreyiGoster.TabIndex = 2;
			btnSifreyiGoster.UseVisualStyleBackColor = true;
			btnSifreyiGoster.MouseDown += btnSifreyiGoster_MouseDown;
			btnSifreyiGoster.MouseUp += btnSifreyiGoster_MouseUp;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(119, 135);
			label2.Name = "label2";
			label2.Size = new Size(63, 33);
			label2.TabIndex = 1;
			label2.Text = "Şifre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(78, 19);
			label1.Name = "label1";
			label1.Size = new Size(148, 33);
			label1.TabIndex = 1;
			label1.Text = "Kullanıcı Adı";
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(62, 171);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.Size = new Size(182, 23);
			txtSifre.TabIndex = 0;
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(62, 55);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(182, 23);
			txtKullaniciAdi.TabIndex = 0;
			// 
			// btnGirisYap
			// 
			btnGirisYap.BackColor = Color.SpringGreen;
			btnGirisYap.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnGirisYap.Location = new Point(12, 233);
			btnGirisYap.Name = "btnGirisYap";
			btnGirisYap.Size = new Size(282, 49);
			btnGirisYap.TabIndex = 5;
			btnGirisYap.Text = "GİRİŞ YAP";
			btnGirisYap.UseVisualStyleBackColor = false;
			btnGirisYap.Click += btnGirisYap_Click;
			// 
			// btnUygulamayiKapat
			// 
			btnUygulamayiKapat.BackColor = Color.Transparent;
			btnUygulamayiKapat.BackgroundImage = (Image)resources.GetObject("btnUygulamayiKapat.BackgroundImage");
			btnUygulamayiKapat.BackgroundImageLayout = ImageLayout.Stretch;
			btnUygulamayiKapat.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnUygulamayiKapat.Location = new Point(574, 233);
			btnUygulamayiKapat.Name = "btnUygulamayiKapat";
			btnUygulamayiKapat.Size = new Size(48, 49);
			btnUygulamayiKapat.TabIndex = 5;
			btnUygulamayiKapat.UseVisualStyleBackColor = false;
			btnUygulamayiKapat.Click += btnUygulamayiKapat_Click;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 293);
			Controls.Add(btnUygulamayiKapat);
			Controls.Add(btnGirisYap);
			Controls.Add(grpGirisPaneli);
			Name = "LoginPage";
			Text = "LoginPage";
			Load += LoginPage_Load;
			grpGirisPaneli.ResumeLayout(false);
			grpGirisPaneli.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpGirisPaneli;
		private TextBox txtKullaniciAdi;
		private Label label1;
		private Label label2;
		private TextBox txtSifre;
		private Button btnGirisYap;
		private Button btnSifreyiGoster;
		private Button button1;
		private Button button3;
		private Button button2;
		private PictureBox pictureBox1;
		private Button btnUygulamayiKapat;
	}
}