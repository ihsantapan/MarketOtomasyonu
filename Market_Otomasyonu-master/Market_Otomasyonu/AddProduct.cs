using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.Entity.Enums;
using Market_Otomasyonu.UI.Extensions;

namespace Market_Otomasyonu
{
	public partial class AddProduct : Form
	{

		private readonly ProductService _productService;
		private readonly CategoryService _categoryService;

		public AddProduct()
		{
			_productService = new ProductService();
			_categoryService = new CategoryService();
			InitializeComponent();
		}
		private void AddProduct_Load(object sender, EventArgs e)
		{
			AddCategoriesToCombobox();
			AddUnitsToCombobox();
			GetAllProducts();
			DisableButton();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (Helper.CheckAreaAddProduct(grpUrunEkle.Controls))
			{
				MessageBox.Show("Lütfen tüm alanlarý doldurun.");
				return;
			}
			else
			{
				Product product = new Product();
				product.Name = txtUrunAdi.Text;
				var category = (Category)cmbKategori.SelectedItem;
				product.CategoryID = category.CategoryID;
				if (txtMarka.Text == string.Empty)
				{
					product.Brand = "Belirtilmedi";
				}
				else
				{
					product.Brand = txtMarka.Text;
				}
				product.Unit = (Unit)cmbBirim.SelectedItem;
				product.TaxRatio = nmrVergiOrani.Value;
				product.PurchasePrice = nmrAlisFiyati.Value;
				product.SalePrice = nmrSatisFiyati.Value + ((product.TaxRatio * nmrSatisFiyati.Value) / 100);
				product.Quantity = nmrPakettekiUrunSayisi.Value;
				product.ExpirationDate = dtSonKullanmaTarihi.Value;
				product.Stock = (int)nmrStokAdedi.Value;

				_productService.Add(product);
				MessageBox.Show("Ýþlem baþarýlý!");
				GetAllProducts();
				Helper.Clean(grpUrunEkle.Controls);
			}
		}


		private void GetAllProducts()
		{
			lstUrunler.Items.Clear();

			var products = _productService.GetAll();

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
		private void AddCategoriesToCombobox()
		{
			var categories = _categoryService.GetCategoryWithCategoryActive();

			foreach (var item in categories)
			{
				cmbKategori.Items.Add(item);
			}
		}
		private void AddUnitsToCombobox()
		{
			foreach (Unit item in Enum.GetValues(typeof(Unit)))
			{
				cmbBirim.Items.Add(item);
			}
		}
		Product selectedProduct;
		private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag; ;
				Category category = _categoryService.GetByIDCategory(selectedProduct.CategoryID);
				txtUrunAdi.Text = selectedProduct.Name;
				cmbKategori.SelectedItem = category;
				txtMarka.Text = selectedProduct.Brand;
				cmbBirim.SelectedItem = selectedProduct.Unit;
				nmrAlisFiyati.Value = selectedProduct.SalePrice;
				nmrStokAdedi.Value = selectedProduct.Stock;
				nmrSatisFiyati.Value = selectedProduct.PurchasePrice;
				nmrVergiOrani.Value = selectedProduct.TaxRatio;
				nmrPakettekiUrunSayisi.Value = selectedProduct.Quantity;
				dtSonKullanmaTarihi.Value = selectedProduct.ExpirationDate;
				EnableButton();
			}
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag;

				selectedProduct.Name = txtUrunAdi.Text;

				var category = (Category)cmbKategori.SelectedItem;
				selectedProduct.CategoryID = category.CategoryID;

				selectedProduct.Unit = (Unit)cmbBirim.SelectedItem;
				selectedProduct.SalePrice = nmrAlisFiyati.Value;
				selectedProduct.Brand = txtMarka.Text;
				selectedProduct.Stock = (int)nmrStokAdedi.Value;
				selectedProduct.PurchasePrice = nmrSatisFiyati.Value;
				selectedProduct.TaxRatio = nmrVergiOrani.Value;
				selectedProduct.Quantity = nmrPakettekiUrunSayisi.Value;
				selectedProduct.ExpirationDate = dtSonKullanmaTarihi.Value;

				_productService.Update(selectedProduct);
				MessageBox.Show("Ýþlem baþarýlý!");
				GetAllProducts();
				Helper.Clean(grpUrunEkle.Controls);
				DisableButton();
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz!");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{

				if (selectedProduct != null)
				{
					_productService.Delete(selectedProduct);
					MessageBox.Show("Silme iþlemi Baþarýyla Gerçekleþti");
					GetAllProducts();
					DisableButton();
				}
				else
				{
					MessageBox.Show("Ýlgili Ürün Bulunamadý");
				}
			}
		}
		private void DisableButton()
		{
			btnGuncelle.Enabled = false;
			btnSil.Enabled = false;
			btnSatýsaKapat.Enabled = false;
			btnSatýþaAç.Enabled = false;
			btnKaydet.Enabled = true;
		}
		private void EnableButton()
		{
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
			btnSatýsaKapat.Enabled = true;
			btnSatýþaAç.Enabled = true;
			btnKaydet.Enabled = false;
		}

		private void btnSatýþaAç_Click(object sender, EventArgs e)
		{
			_productService.ProductStatusChangeOpenSale(selectedProduct.ProductID);
			GetAllProducts();
			MessageBox.Show("Ürün Durumu Satýþa Açýk Olarak Atandý...");
			Helper.Clean(grpUrunEkle.Controls);
		}

		private void btnSatýsaKapat_Click(object sender, EventArgs e)
		{
			_productService.ProductStatusChangeCloseSale(selectedProduct.ProductID);
			GetAllProducts();
			MessageBox.Show("Ürün Durumu Satýþa Kapalý Olarak Atandý...");
			Helper.Clean(grpUrunEkle.Controls);
		}


	}
}