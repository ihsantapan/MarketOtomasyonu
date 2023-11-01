using Market_Otomasyonu.Data.SeedData;
using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Context
{
	public class AppDbContext:DbContext
	{
		public DbSet<Sale> Sales { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<AppUser> Users { get; set; }
		public DbSet<AppRole> Roles { get; set; }
		public DbSet<Market> Markets { get; set; }
	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=MarketOtomasyonuDB;integrated security=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().
				HasOne(x => x.Category)
				.WithMany(x => x.Products)
				.HasForeignKey(product => product.CategoryID)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.ApplyConfiguration(new SeedCategories());
			modelBuilder.ApplyConfiguration(new SeedProducts());
			modelBuilder.ApplyConfiguration(new SeedAppRole());
			modelBuilder.ApplyConfiguration(new SeedAppUser());

			base.OnModelCreating(modelBuilder);
		}
	}
}
