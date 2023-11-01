using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Market_Otomasyonu.Data.SeedData
{
	public class SeedAppRole : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.HasData(new AppRole() { RoleID = 1, RoleName = "Admin" });
			builder.HasData(new AppRole() { RoleID = 2, RoleName = "Worker" });
		}
	}
}
