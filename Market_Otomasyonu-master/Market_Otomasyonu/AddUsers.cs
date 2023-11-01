using FluentValidation.Results;
using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Business.ValidationRules;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.Entity.Enums;
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
	public partial class AddUsers : Form
	{
		private readonly AppUserService _userService;
		private readonly RoleService _roleService;
		public AddUsers()
		{
			_userService = new AppUserService();
			_roleService = new RoleService();
			InitializeComponent();
		}
		private void AddUsers_Load(object sender, EventArgs e)
		{
			AddWorkUnitsToCombobox();
		}

		private void btnKayitOlustur_Click(object sender, EventArgs e)
		{
			if (_userService.IsUserExist(txtAd.Text, txtSoyadı.Text))
			{
				MessageBox.Show("Böyle bir Kişi veritabanında mevcut");
			}
			if (Helper.CheckAreaAddUser(grpKullanıcıEkle.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}
			else
			{
				var role = _roleService.GetByFilter(x => x.RoleName == "Worker");
				if (_userService.ArePasswordsMatching(_userService.PasswordHash(txtSifre.Text), _userService.PasswordHash(txtSifreTekrar.Text)))
				{
					var user = new AppUser()
					{
						Name = txtAd.Text,
						Surname = txtSoyadı.Text,
						Username = txtKullaniciAdi.Text,
						Password = txtSifre.Text,
						ConfirmPassword = txtSifreTekrar.Text,
						WorkUnit = (WorkUnit)cmbCalismaBirimi.SelectedItem,
						Gender = (rdbErkek.Checked ? "Erkek" : (rdbKadin.Checked ? "Kadın" : string.Empty)),
						CreatedDate = DateTime.Now,
						RoleID = role.RoleID
					};
					AppUserValidator _rules = new AppUserValidator();
					ValidationResult result = _rules.Validate(user);
					user.Password = _userService.PasswordHash(user.Password);
					user.ConfirmPassword = _userService.PasswordHash(user.ConfirmPassword);
					if (result.IsValid)
					{
						_userService.Add(user);
						MessageBox.Show("Tebrikler Kayıt İşleminiz Başarılı");
						Helper.Clean(grpKullanıcıEkle.Controls);

					}
					else
					{
						foreach (var item in result.Errors)
						{

							MessageBox.Show(item.ErrorMessage, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;

						}
					}
				}
				else
				{
					MessageBox.Show("Şifreler Eşleşmiyor");
				}
			}

		}

		private void txtSifre_TextChanged(object sender, EventArgs e)
		{
			lblGüvenlikSeviyesi.Text = _userService.CheckPasswordStrength(txtSifre.Text);
		}

		private void btnSifreyiGoster_MouseUp(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = '*';
			txtSifreTekrar.PasswordChar = '*';
		}

		private void btnSifreyiGoster_MouseDown(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = default;
			txtSifreTekrar.PasswordChar = default;
		}

		private void grpKullanıcıEkle_Enter(object sender, EventArgs e)
		{

		}


		private void AddWorkUnitsToCombobox()
		{
			foreach (WorkUnit item in Enum.GetValues(typeof(WorkUnit)))
			{
				cmbCalismaBirimi.Items.Add(item);
			}
		}
	}
}
