using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.UI.Extensions;

namespace Market_Otomasyonu.UI
{
	public partial class UserPanel : Form
	{
		private AppUser _user;
		private readonly RoleService _roleService;
		private readonly ProductService _productService;

		public UserPanel(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_roleService = new RoleService();
			_productService = new ProductService();
		}
		private void UserPanel_Load(object sender, EventArgs e)
		{
			var role = _roleService.GetByRoleAdmin();
			if (_user.RoleID == role.RoleID)
			{
				btnKullaniciPaneli.Visible = true;

			}
			else
			{
				btnKullaniciPaneli.Visible = false;

			}
			if (_productService.BoolProductListWithLess20Stock())
			{
				DialogResult dr = MessageBox.Show("Stok Sayısı 20 den az olan ürünler var bakmak ister misin ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (dr == DialogResult.Yes)
				{
					StockControl stockControl = new StockControl();
					this.Hide();
					stockControl.ShowDialog();
					this.Show();
				}

			}

		}
		private void btnRapor_Click(object sender, EventArgs e)
		{
			Report report = new Report();
			this.Hide();
			report.ShowDialog();
			this.Show();
		}

		private void btnUrunEkle_Click(object sender, EventArgs e)
		{
			AddProduct addProduct = new AddProduct();
			this.Hide();
			addProduct.ShowDialog();
			this.Show();
		}

		private void btnKategoriEkle_Click(object sender, EventArgs e)
		{
			AddCategory addCategory = new AddCategory();
			this.Hide();
			addCategory.ShowDialog();
			this.Show();
		}

		private void btnSatisEkrani_Click(object sender, EventArgs e)
		{
			SaleScreen saleScreen = new SaleScreen();
			this.Hide();
			saleScreen.ShowDialog();
			this.Show();
		}

		private void btnKullaniciPaneli_Click(object sender, EventArgs e)
		{
			UserPanelSetting userPanelSetting = new UserPanelSetting();
			this.Hide();
			userPanelSetting.ShowDialog();
			this.Show();
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
	}
}
