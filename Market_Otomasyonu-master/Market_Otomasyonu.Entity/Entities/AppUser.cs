using Market_Otomasyonu.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class AppUser
	{
        public AppUser()
        {
            Markets = new List<Market>();
        }
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
		public string Gender { get; set; }
		public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string IsWorking { get; set; } = "Çalışıyor";
        public WorkUnit? WorkUnit { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

		//Navigation prop
		public virtual  ICollection<Market> Markets { get; set; }

		[ForeignKey("AppRole")]
		public virtual int RoleID { get; set; }
		public AppRole AppRole { get; set; }
	}
}
