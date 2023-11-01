using Market_Otomasyonu.Business.Abstract;
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
	public partial class StockControl : Form
	{
		private readonly ProductService _productService;
		private readonly CategoryService _categoryService;
		public StockControl()
		{
			_productService = new ProductService();
			_categoryService = new CategoryService();
			InitializeComponent();
		}
		private void StockControl_Load(object sender, EventArgs e)
		{
			GetAllProducts();
			DisableButton();
		}

		Product selectedProduct;
		private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag;
				nmrStokAdedi.Value = selectedProduct.Stock;
				EnableButton();
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag;
				int updatedProductStock = (int)nmrStokAdedi.Value;
				selectedProduct.Stock = updatedProductStock;
				_productService.Update(selectedProduct);
				MessageBox.Show("Güncelleme işlemi Başarıyla Gerçekleşti");
				GetAllProducts();
				Helper.Clean(grpStokAdedi.Controls);
				DisableButton();
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz");
			}
		}

		
		private void GetAllProducts()
		{
			lstUrunler.Items.Clear();

			var products = _productService.GetProductListWithLess20Stock();

			foreach (var item in products)
			{
				ListViewItem lv = new ListViewItem(item.ProductID.ToString());
				lv.SubItems.Add(item.Name);
				Category category = _categoryService.GetByIDCategory(item.CategoryID);
				if (category != null)
				{
					lv.SubItems.Add(category.Name);
				}

				lv.SubItems.Add(item.Brand);
				lv.SubItems.Add(item.Unit.ToString());
				lv.SubItems.Add(item.SalePrice.ToString());
				lv.SubItems.Add(item.PurchasePrice.ToString());
				lv.SubItems.Add(item.TaxRatio.ToString());
				lv.SubItems.Add(item.Quantity.ToString());
				lv.SubItems.Add(item.Stock.ToString());
				lv.SubItems.Add(item.ExpirationDate.ToString());
				lv.SubItems.Add(item.IsContinued.ToString());
				lstUrunler.Items.Add(lv);
				lv.Tag = item;
			}
		}
		private void DisableButton()
		{
			btnGuncelle.Enabled = false;

		}
		private void EnableButton()
		{
			btnGuncelle.Enabled = true;

		}
	}
}
