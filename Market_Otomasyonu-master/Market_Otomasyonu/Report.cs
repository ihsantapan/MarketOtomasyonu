using Market_Otomasyonu.Data.Context;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
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
	public partial class Report : Form
	{
		private readonly SaleRepository _saleRepository;
		private readonly AppDbContext _context;

		public Report()
		{
			_saleRepository = new SaleRepository();
			_context = new AppDbContext();
			InitializeComponent();
		}

		private void btnRaporla_Click(object sender, EventArgs e)
		{
			DateTime selectedDate = dateTimePickerGunlukRapor.Value.Date;
			int selectedDateYear = dateTimePickerGunlukRapor.Value.Year;

			var dailySales = _saleRepository
				.GetAll()
				.Where(sale => sale.SaleDate.Date == selectedDate);


			var saleIDs = dailySales.Select(sale => sale.SaleID).ToList();

			if (dailySales != null)
			{

				int dailyTotalSalesQuantity = dailySales.Sum(sale => (int)sale.Quantity);
				decimal dailyTotalRevenue = dailySales.Sum(sale => sale.TotalPrice);
				decimal dailyTotalProfit = dailySales.Sum(sale => sale.ProfitPrice);
				lblGunlukSatisAdedi.Text = dailyTotalSalesQuantity.ToString();
				lblGunlukCiro.Text = dailyTotalRevenue.ToString("C");
				lblGunlukKar.Text = dailyTotalProfit.ToString("C");
				lstSatışlar.Items.Clear();

				foreach (int saleID in saleIDs)
				{
					var sale = _saleRepository.GetByID(saleID); 

					if (sale != null)
					{
						ListViewItem lv = new ListViewItem(saleID.ToString());
						lv.SubItems.Add(sale.SaleDate.ToString("dd/MM/yyyy")); 
						lv.SubItems.Add(sale.TotalPrice.ToString("C"));
						lstSatışlar.Items.Add(lv);
					}
				}
			}
			else
			{

				MessageBox.Show("Belirtilen tarihe ait günlük veri bulunamadı.");
			}

			var YearSales = _saleRepository
				.GetAll()
				.Where(sale => sale.SaleDate.Date.Year == selectedDateYear);

			if (YearSales != null)
			{

				int yearTotalSalesQuantity = YearSales.Sum(sale => (int)sale.Quantity);
				decimal yearTotalRevenue = YearSales.Sum(sale => sale.TotalPrice);
				decimal yearTotalProfit = YearSales.Sum(sale => sale.ProfitPrice);
				lblYıllıkSatisAdedi.Text = yearTotalSalesQuantity.ToString();
				lblYıllıkCiro.Text = yearTotalRevenue.ToString("C");
				lblYıllıkKar.Text = yearTotalProfit.ToString("C");
					
			}
			else
			{

				MessageBox.Show("Belirtilen tarihe ait günlük veri bulunamadı.");
			}


		}

		private void lstSatışlar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstSatışlar.SelectedItems.Count > 0)
			{
				int selectedSaleID = int.Parse(lstSatışlar.SelectedItems[0].Text);

				var saleProducts = _context.ShoppingCarts
					.Where(sp => sp.Sale.SaleID == selectedSaleID)
					.ToList();


				lstGunlukSatisDetay.Items.Clear();


				foreach (var saleProduct in saleProducts)
				{
					ListViewItem lv = new ListViewItem(saleProduct.Name);
					lv.SubItems.Add(saleProduct.Brand);
					lv.SubItems.Add(saleProduct.UnitPrice.ToString("C"));
					lv.SubItems.Add(saleProduct.SalePrice.ToString("C"));
					lv.SubItems.Add(saleProduct.Quantity.ToString());

					lstGunlukSatisDetay.Items.Add(lv);
				}
			}
		}
	}
}
