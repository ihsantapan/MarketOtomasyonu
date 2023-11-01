using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class Market
	{
        public Market()
        {
            Products = new List<Product>();
        }
        public int MarketID { get; set; }
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Adress { get; set; }

        //Navigation Prop
        public virtual ICollection<Product> Products { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public AppUser User { get; set; }

    }
}
