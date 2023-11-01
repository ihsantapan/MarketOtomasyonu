using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Data.Repository;
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
	public partial class AddCategory : Form
	{
		private readonly CategoryService _categoryService;
		private readonly ProductService _productService;
		public AddCategory()
		{
			_categoryService = new CategoryService();
			_productService = new ProductService();
			InitializeComponent();
		}
		private void AddCategory_Load(object sender, EventArgs e)
		{
			GetAllCategories();
			DisableButton();
		}
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (_categoryService.IsCategoryExist(txtKategoriAdi.Text))
			{
				MessageBox.Show("Böyle bir kategori mevcut");
			}
			else
			{
				if (Helper.CheckArea(grpKategoriEkle.Controls))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.");
					return;
				}

				var category = new Category()
				{
					Name = txtKategoriAdi.Text,
				};
				_categoryService.AddCategory(category);
				MessageBox.Show("Kaydetme İşlemi Başarılı");
				GetAllCategories();
				Helper.Clean(grpKategoriEkle.Controls);
			}

		}
		private void GetAllCategories()
		{
			lstKategoriler.Items.Clear();
			var categories = _categoryService.GetAllCategory();
			foreach (var category in categories)
			{
				ListViewItem item = new ListViewItem(category.Name);
				item.SubItems.Add(category.IsActive);
				item.Tag = category;
				lstKategoriler.Items.Add(item);
			}
		}

		Category selectedCategory;
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{
				selectedCategory = (Category)lstKategoriler.SelectedItems[0].Tag;
				string updatedCategoryName = txtKategoriAdi.Text;
				selectedCategory.Name = updatedCategoryName;
				_categoryService.UpdateCategory(selectedCategory);

				MessageBox.Show("Güncelleme işlemi Başarıyla Gerçekleşti");
				GetAllCategories();
				Helper.Clean(grpKategoriEkle.Controls);
				DisableButton();
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{

				if (selectedCategory != null)
				{
					DialogResult dr = MessageBox.Show("Kategoriye bağlı olan ürünlerin kategorisi sıfırlanacaktır Emin Misiniz? Dilerseniz Pasif Hale Getirebilirsiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (dr == DialogResult.Yes)
					{
						_productService.ChangeProductCategoryToNull(selectedCategory.CategoryID);
						_categoryService.DeleteCategory(selectedCategory);
						MessageBox.Show("Silme işlemi Başarıyla Gerçekleşti");
						GetAllCategories();
						DisableButton();
						Helper.Clean(grpKategoriEkle.Controls);
					}
					else
					{
						return;
					}



				}
				else
				{
					MessageBox.Show("İlgili Ürün Bulunamadı");
				}
			}
		}

		private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{
				selectedCategory = (Category)lstKategoriler.SelectedItems[0].Tag;
				txtKategoriAdi.Text = selectedCategory.Name;
				EnableButton();
			}
		}
		private void DisableButton()
		{
			btnGuncelle.Enabled = false;
			btnSil.Enabled = false;
			btnKaydet.Enabled = true;
			btnAktifYap.Enabled = false;
			btnPasifYap.Enabled = false;
		}
		private void EnableButton()
		{
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
			btnKaydet.Enabled = false;
			btnAktifYap.Enabled = true;
			btnPasifYap.Enabled = true;
		}

		private void btnAktifYap_Click(object sender, EventArgs e)
		{
			_categoryService.CategoryStatusChangeActive(selectedCategory.CategoryID);
			GetAllCategories();
			MessageBox.Show("Kategori Durumu Aktif Olarak Atandı...");
			Helper.Clean(grpKategoriEkle.Controls);
			DisableButton();
		}

		private void btnPasifYap_Click(object sender, EventArgs e)
		{
			_categoryService.CategoryStatusChangeDisable(selectedCategory.CategoryID);
			GetAllCategories();
			MessageBox.Show("Kategori Durumu Pasif Olarak Atandı...");
			Helper.Clean(grpKategoriEkle.Controls);
			DisableButton();
		}

		
	}
}
