using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class Category
	{
        public Category()
        {
            Products= new List<Product>();  
        }
        public int CategoryID { get; set; }
        public string Name { get; set; }
		public string IsActive { get; set; } = "Aktif";

		//Navigation Prop
		public virtual ICollection<Product> Products { get; set;}

		public override string ToString()
		{
			return $"{Name}";
		}
	}
}
