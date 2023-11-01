using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Business.Concrete;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Market_Otomasyonu.UI
{
	public partial class UserPanelSetting : Form
	{
		private readonly AppUserService _appUserService;
		public UserPanelSetting()
		{
			_appUserService = new AppUserService();
			InitializeComponent();
		}

		private void UserPanelSetting_Load(object sender, EventArgs e)
		{
			AddUserToList();
			AddWorkUnitsToCombobox();
			DisableButton();
		}
		private void AddUserToList()
		{
			lstKisiler.Items.Clear();
			var users = _appUserService.GetAll();
			foreach (var user in users)
			{
				ListViewItem item = new ListViewItem();
				item.Text = user.Name;
				item.SubItems.Add(user.Surname);
				item.SubItems.Add(user.WorkUnit.ToString());
				item.SubItems.Add(user.IsWorking.ToString());
				item.Tag = user;
				lstKisiler.Items.Add(item);
			}
		}
		AppUser selectedUser;
		private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstKisiler.SelectedItems.Count > 0)
			{
				selectedUser = (AppUser)lstKisiler.SelectedItems[0].Tag;
				txtAd.Text = selectedUser.Name;
				txtSoyad.Text = selectedUser.Surname;
				txtKullanıcıAdı.Text = selectedUser.Username;
				cmbCalismaBirimi.SelectedItem = selectedUser.WorkUnit;
				EnableButton();
			}
		}
		private void AddWorkUnitsToCombobox()
		{
			foreach (WorkUnit item in Enum.GetValues(typeof(WorkUnit)))
			{
				cmbCalismaBirimi.Items.Add(item);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstKisiler.SelectedItems.Count > 0)
			{
				selectedUser = (AppUser)lstKisiler.SelectedItems[0].Tag;

				selectedUser.Name = txtAd.Text;
				selectedUser.Surname = txtSoyad.Text;
				selectedUser.Username = txtKullanıcıAdı.Text;
				selectedUser.WorkUnit = (WorkUnit)cmbCalismaBirimi.SelectedItem;
				_appUserService.UpdateUser(selectedUser);
				MessageBox.Show("İşlem başarılı!");
				AddUserToList();
				Helper.Clean(grpKullaniciBilgileri.Controls);
				DisableButton();

			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz!");
			}
		}

		private void btnAktifYap_Click(object sender, EventArgs e)
		{
			_appUserService.AppUserStatusChangeWorking(selectedUser.UserID);
			AddUserToList();
			MessageBox.Show("Kullanıcı Durumu Çalışıyor Olarak Atandı...");
			Helper.Clean(grpKullaniciBilgileri.Controls);
			DisableButton();
		}

		private void btnPasifYap_Click(object sender, EventArgs e)
		{
			_appUserService.AppUserStatusChangeNotWorking(selectedUser.UserID);
			MessageBox.Show("Kullanıcı Durumu Çalışmıyor Olarak Atandı...");
			AddUserToList();
			Helper.Clean(grpKullaniciBilgileri.Controls);
			DisableButton();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstKisiler.SelectedItems.Count > 0)
			{

				if (selectedUser != null)
				{
					_appUserService.DeleteUser(selectedUser);
					MessageBox.Show("Silme işlemi Başarıyla Gerçekleşti");
					AddUserToList();
					DisableButton();
				}
				else
				{
					MessageBox.Show("İlgili Ürün Bulunamadı");
				}
			}
		}
		private void DisableButton()
		{
			btnGuncelle.Enabled = false;
			btnSil.Enabled = false;
			btnPasifYap.Enabled = false;
			btnAktifYap.Enabled = false;

		}
		private void EnableButton()
		{
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
			btnPasifYap.Enabled = true;
			btnAktifYap.Enabled = true;
		}

		private void btnKullaniciEkle_Click(object sender, EventArgs e)
		{
			AddUsers addUsers = new AddUsers();
			this.Hide();
			addUsers.ShowDialog();
			this.Show();
		}
	}
}
