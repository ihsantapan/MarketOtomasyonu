using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu.UI
{
	public partial class LoginPage : Form
	{
		private readonly AppUserService _userService;
		public LoginPage()
		{
			_userService = new AppUserService();
			InitializeComponent();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			if (Helper.CheckArea(grpGirisPaneli.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}
			var result = _userService.AuthenticateUser(txtKullaniciAdi.Text, _userService.PasswordHash(txtSifre.Text));
			if (result == "Giriş Başarılı")
			{
				var user = _userService.GetByFilterUser(X => X.Username == txtKullaniciAdi.Text && X.Password == _userService.PasswordHash(txtSifre.Text));
				if (user != null)
				{
					if (user.IsWorking == "Çalışıyor")
					{
						UserPanel userpanel = new UserPanel(user);
						this.Hide();
						userpanel.ShowDialog();
					}
					else
					{
						MessageBox.Show("Kullanıcı Şuan Çalışıyor Olarak Göünmüyor...");
					}

				}
			}
			if (result == "Şifre Yanlış")
			{
				MessageBox.Show("Lütfen şifrenizi kontrol ediniz");

			}
			if (result == "Kullanıcı Bulunamadı")
			{
				MessageBox.Show("Böyle bir kullanıcı bulunamadı");

			}
		}

		private void btnSifreyiGoster_MouseUp(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = '*';
		}

		private void btnSifreyiGoster_MouseDown(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = default;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "enesfevzi";
			txtSifre.Text = "*123456ASas*";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "ihsantapan";
			txtSifre.Text = "*123456ASas*";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "ebrucevik";
			txtSifre.Text = "*123456ASas*";
		}

		private void btnUygulamayiKapat_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Uygulama Kapatılacak Emin Misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{
				Application.Exit();
			}
			else
			{
				return;
			}

		}

		private void LoginPage_Load(object sender, EventArgs e)
		{
			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
		}
	}
}
