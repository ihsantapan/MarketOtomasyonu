using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class ShoppingCart
	{
		public int ShoppingCartID { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public decimal PurchasePrice { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal SalePrice { get; set; }
		public decimal Quantity { get; set; }

		// Navigation Prop
		public int ProductID { get; set; }
		public Product Product { get; set; }

		public int SaleID { get; set; }
		public Sale Sale { get; set; }
	}
}
