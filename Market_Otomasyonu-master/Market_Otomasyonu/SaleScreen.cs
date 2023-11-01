using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Data.Context;
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
	public partial class SaleScreen : Form
	{
		private readonly ProductService _productService;
		private readonly SaleService _saleService;
		private readonly CategoryService _categoryService;
		private List<Product> selectedProducts = new List<Product>();
		public SaleScreen()
		{
			_productService = new ProductService();
			_categoryService = new CategoryService();
			_saleService = new SaleService();
			InitializeComponent();
		}

		private void SaleScreen_Load(object sender, EventArgs e)
		{
			GetAllProducts();
		}
		private void txtUrunAra_TextChanged(object sender, EventArgs e)
		{
			LoadProduct(txtUrunAra.Text);
		}

		private void LoadProduct(string searchword = "")
		{
			lstArananUrunler.Items.Clear();
			var products = _productService.GetAllProductWtihOpenSale();

			foreach (var product in products)
			{
				if (searchword == "" || product.Name.ToLower().Contains(searchword))
				{
					ListViewItem item = new ListViewItem(product.Name);
					Category category = _categoryService.GetByIDCategory(product.CategoryID);
					item.SubItems.Add(product.Brand);
					item.SubItems.Add(category.Name);
					item.Tag = product;
					lstArananUrunler.Items.Add(item);
				}
			}
		}
		decimal selectedProductQuantity;
		decimal totalSalesQuantity = 0;
		decimal totalSalesPrice = 0;
		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{
			if (nmrAdet.Value == 0)
			{
				MessageBox.Show("Lütfen önce bir ürün seçin ve miktar belirtin");
				return;
			}
			if (lstArananUrunler.SelectedItems.Count > 0)
			{
				//Product selectedProduct = lstArananUrunler.SelectedItems[0].Tag as Product;

				//decimal selectedQuantity = nmrAdet.Value;

				//bool productAlreadyInCart = false;
				//foreach (ListViewItem item in lstSiparisler.Items)
				//{
				//	Product cartProduct = item.Tag as Product;
				//	if (cartProduct.ProductID == selectedProduct.ProductID)
				//	{
				//		item.SubItems[7].Text = (decimal.Parse(item.SubItems[7].Text) + selectedQuantity).ToString();
				//		totalSalesQuantity += nmrAdet.Value;
				//		lblToplamSatisAdedi.Text = totalSalesQuantity.ToString();
				//		productAlreadyInCart = true;
				//		break;
				//	}
				//}
				Product selectedProduct = lstArananUrunler.SelectedItems[0].Tag as Product;
				decimal selectedQuantity = nmrAdet.Value;

				bool productAlreadyInCart = false;
				foreach (ListViewItem item in lstSiparisler.Items)
				{
					Product cartProduct = item.Tag as Product;
					if (cartProduct.ProductID == selectedProduct.ProductID)
					{
						decimal currentQuantity = decimal.Parse(item.SubItems[7].Text);
						decimal newQuantity = currentQuantity + selectedQuantity;

						// Stok kontrolü
						if (selectedProduct.Stock < newQuantity)
						{
							MessageBox.Show("Üzgünüz, stokta yeterli ürün bulunmamaktadır.");
							return;
						}

						item.SubItems[7].Text = newQuantity.ToString();
						totalSalesQuantity += selectedQuantity;
						lblToplamSatisAdedi.Text = totalSalesQuantity.ToString();
						productAlreadyInCart = true;
						break;
					}
				}

				if (!productAlreadyInCart)
				{
					if (selectedProduct.Stock < selectedQuantity)
					{
						MessageBox.Show("Üzgünüz, stokta yeterli ürün bulunmamaktadır.");
						return;
					}
					Category category = _categoryService.GetByIDCategory(selectedProduct.CategoryID);
					decimal productTotalPrice = selectedProduct.PurchasePrice * selectedQuantity;

					ListViewItem lv = new ListViewItem(selectedProduct.Name);
					lv.SubItems.Add(selectedProduct.Brand);
					lv.SubItems.Add(category.Name);
					lv.SubItems.Add(selectedProduct.Unit.ToString());
					lv.SubItems.Add(selectedProduct.PurchasePrice.ToString());
					lv.SubItems.Add(selectedProduct.Stock.ToString());
					lv.SubItems.Add(selectedProduct.ExpirationDate.ToString());
					lv.SubItems.Add(selectedQuantity.ToString());
					lv.Tag = selectedProduct;
					lv.SubItems.Add(productTotalPrice.ToString());

					selectedProducts.Add(selectedProduct);
					lstSiparisler.Items.Add(lv);

					totalSalesPrice += productTotalPrice;
					totalSalesQuantity += selectedQuantity;
					lblToplamFiyat.Text = totalSalesPrice.ToString();
					lblToplamSatisAdedi.Text = totalSalesQuantity.ToString();

				}
			}
		}
		private void btnSiparisiTamamla_Click(object sender, EventArgs e)
		{

			decimal unitPrice = 0;
			decimal quantity = 0;
			decimal profitPrice = 0;
			decimal totalSalePrice = 0;

			if (lstSiparisler.Items.Count == 0 || (rdbNakit.Checked == false && rdbKrediKarti.Checked == false))
			{
				MessageBox.Show("Lütfen sipariş listesine ekleme yapın veya bir ödeme yöntemi seçin");
			}
			else
			{
				var sale = new Sale();
				sale.SaleDate = DateTime.Now;
				sale.PaymentMethod = rdbKrediKarti.Checked ? PaymentMethod.CreditCard : PaymentMethod.Cash;
				var shoppingCarts = new List<ShoppingCart>();

				foreach (ListViewItem item in lstSiparisler.Items)
				{
					var saledProduct = item.Tag as Product;
					unitPrice = Convert.ToDecimal(item.SubItems[4].Text);
					quantity = Convert.ToDecimal(item.SubItems[7].Text);
					profitPrice = (saledProduct.SalePrice - saledProduct.PurchasePrice) * quantity;
					totalSalePrice += Convert.ToDecimal(item.SubItems[8].Text);
					saledProduct.Stock -= Convert.ToInt32(item.SubItems[7].Text);
					_productService.Update(saledProduct);

					var shoppingCart = new ShoppingCart
					{
						Name = saledProduct.Name,
						Brand = saledProduct.Brand,
						PurchasePrice = saledProduct.PurchasePrice,
						UnitPrice = unitPrice,
						SalePrice = saledProduct.SalePrice,
						Quantity = quantity,
						ProductID = saledProduct.ProductID,
						Sale = sale
					};
					shoppingCarts.Add(shoppingCart);
				}
				sale.Quantity = quantity;
				sale.TotalPrice = totalSalePrice;
				sale.ShoppingCarts = shoppingCarts;
				sale.ProfitPrice = profitPrice;
				_saleService.Add(sale);
				MessageBox.Show("Kaydetme İşlemi Başarılı");
			}


		}

		private void btnSiparisSil_Click(object sender, EventArgs e)
		{
			var selectedProduct = lstSiparisler.SelectedIndices[0];

			if (lstSiparisler.SelectedItems.Count > 0)
			{
				if (selectedProduct != null)
				{
					foreach (ListViewItem item in lstSiparisler.SelectedItems)
					{
						totalSalesQuantity -= Convert.ToDecimal(item.SubItems[7].Text);
						totalSalesPrice -= Convert.ToDecimal(item.SubItems[8].Text);

						lblToplamSatisAdedi.Text = totalSalesQuantity.ToString("0.00");
						lblToplamFiyat.Text = totalSalesPrice.ToString("0.00");
					}

					lstSiparisler.Items.RemoveAt(selectedProduct);
					MessageBox.Show("Silme işleminiz gerçekleşti");
				}
			}
			else
			{
				MessageBox.Show("Hata! Ürün bulunamadı!");
			}

		}


		private void GetAllProducts()
		{
			lstArananUrunler.Items.Clear();

			var products = _productService.GetAll();

			foreach (var item in products)
			{
				ListViewItem lv = new ListViewItem();
				lv.Text = item.Name;
				lv.SubItems.Add(item.Brand);
				lv.SubItems.Add(item.Unit.ToString());
				lv.SubItems.Add(item.Stock.ToString());
				lv.SubItems.Add(item.PurchasePrice.ToString());
				lv.Tag = item;
				lstArananUrunler.Items.Add(lv);
			}
		}


	}
}
