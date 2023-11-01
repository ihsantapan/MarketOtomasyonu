using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Market_Otomasyonu.Entity.Enums;

namespace Market_Otomasyonu.Data.SeedData
{
	public class SeedAppUser : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder
				.HasData(
				new AppUser()
				{
					UserID = 1,
					Name = "Enes",
					Surname = "Fevzi",
					Username = "enesfevzi",
					Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
				
					Gender = "Erkek",
					RoleID = 1,
				}
				);
			builder
				.HasData(
				new AppUser()
				{
					UserID = 2,
					Name = "İhsan",
					Surname = "Tapan",
					Username = "ihsantapan",
					Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					WorkUnit = WorkUnit.Depo,
					Gender = "Erkek",
					RoleID = 2,
				}
				); 
			builder
				.HasData(
				new AppUser()
				{
					UserID = 3,
					Name = "Ebru",
					Surname = "Çevik",
					Username = "ebrucevik",
					Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					WorkUnit = WorkUnit.Kasa,
					Gender = "Kadın",
					RoleID = 2,
				}
				);
		}
	}
}
