using Market_Otomasyonu.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class Product
	{
        public Product()
        {
			ShoppingCarts=new List<ShoppingCart>();

		}
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal TaxRatio { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Quantity { get; set; }
        public Unit Unit { get; set; }
        public int Stock { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string IsContinued { get; set; } = "Satışa Açık";

		//Navigation Prop
		public int CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<ShoppingCart> ShoppingCarts { get; set;}


    }
}
