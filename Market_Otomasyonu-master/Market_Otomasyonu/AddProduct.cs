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
				MessageBox.Show("L�tfen t�m alanlar� doldurun.");
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
				MessageBox.Show("��lem ba�ar�l�!");
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
				MessageBox.Show("��lem ba�ar�l�!");
				GetAllProducts();
				Helper.Clean(grpUrunEkle.Controls);
				DisableButton();
			}
			else
			{
				MessageBox.Show("L�tfen bir �r�n se�iniz!");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{

				if (selectedProduct != null)
				{
					_productService.Delete(selectedProduct);
					MessageBox.Show("Silme i�lemi Ba�ar�yla Ger�ekle�ti");
					GetAllProducts();
					DisableButton();
				}
				else
				{
					MessageBox.Show("�lgili �r�n Bulunamad�");
				}
			}
		}
		private void DisableButton()
		{
			btnGuncelle.Enabled = false;
			btnSil.Enabled = false;
			btnSat�saKapat.Enabled = false;
			btnSat��aA�.Enabled = false;
			btnKaydet.Enabled = true;
		}
		private void EnableButton()
		{
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
			btnSat�saKapat.Enabled = true;
			btnSat��aA�.Enabled = true;
			btnKaydet.Enabled = false;
		}

		private void btnSat��aA�_Click(object sender, EventArgs e)
		{
			_productService.ProductStatusChangeOpenSale(selectedProduct.ProductID);
			GetAllProducts();
			MessageBox.Show("�r�n Durumu Sat��a A��k Olarak Atand�...");
			Helper.Clean(grpUrunEkle.Controls);
		}

		private void btnSat�saKapat_Click(object sender, EventArgs e)
		{
			_productService.ProductStatusChangeCloseSale(selectedProduct.ProductID);
			GetAllProducts();
			MessageBox.Show("�r�n Durumu Sat��a Kapal� Olarak Atand�...");
			Helper.Clean(grpUrunEkle.Controls);
		}


	}
}