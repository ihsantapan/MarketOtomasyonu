using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.Entity.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.SeedData
{
	public class SeedProducts : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData
				(
				 new Product { ProductID = 1, CategoryID = 2, Name = "Su (500mL)", Brand = "Erikli", SalePrice = 5M, TaxRatio = 0.01M, PurchasePrice = 6.80M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 2, CategoryID = 2, Name = "Su (1,5L)", Brand = "Erikli", SalePrice = 52M, TaxRatio = 0.01M, PurchasePrice = 71.8M, Quantity = 6, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 3, CategoryID = 2, Name = "Kola (1L)", Brand = "Coca-Cola", SalePrice = 18.7M, TaxRatio = 0.01M, PurchasePrice = 28.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 4, CategoryID = 3, Name = "İthal Muz", Brand = "", SalePrice = 41.49M, TaxRatio = 0.01M, PurchasePrice = 52.99M, Quantity = 1, Unit = Unit.Kilogram, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 5, CategoryID = 3, Name = "Salkım Domates", Brand = "", SalePrice = 27.79M, TaxRatio = 0.01M, PurchasePrice = 32.99M, Quantity = 1, Unit = Unit.Kilogram, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 6, CategoryID = 3, Name = "Kuru Soğan", Brand = "", SalePrice = 24.00M, TaxRatio = 0.01M, PurchasePrice = 26.49M, Quantity = 1, Unit = Unit.Kilogram, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 7, CategoryID = 4, Name = "Ekmek", Brand = "", SalePrice = 6.0M, TaxRatio = 0.01M, PurchasePrice = 6.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 8, CategoryID = 4, Name = "Simit", Brand = "", SalePrice = 4.50M, TaxRatio = 0.01M, PurchasePrice = 7.5M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 9, CategoryID = 4, Name = "Peynirli Poğaça", Brand = "", SalePrice = 6.50M, TaxRatio = 0.01M, PurchasePrice = 11.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 10, CategoryID = 5, Name = "Pirinç (1kg)", Brand = "Yayla", SalePrice = 69.00M, TaxRatio = 0.01M, PurchasePrice = 76.90M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 11, CategoryID = 5, Name = "Un (1kg)", Brand = "Sinangil", SalePrice = 16.99M, TaxRatio = 0.01M, PurchasePrice = 21.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 12, CategoryID = 5, Name = "Ayçiçek Yağı", Brand = "Komili", SalePrice = 80.00M, TaxRatio = 0.01M, PurchasePrice = 119.90M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 13, CategoryID = 6, Name = "Süt", Brand = "İçim (1L)", SalePrice = 29.99M, TaxRatio = 0.01M, PurchasePrice = 34.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 14, CategoryID = 6, Name = "Beyaz Peynir (450g)", Brand = "Tahsildaroğlu", SalePrice = 148.00M, TaxRatio = 0.01M, PurchasePrice = 174.95M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 15, CategoryID = 6, Name = "Yoğurt (750g)", Brand = "Pınar", SalePrice = 39.99M, TaxRatio = 0.01M, PurchasePrice = 43.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 16, CategoryID = 7, Name = "Yumurta (10'lu)", Brand = "CP", SalePrice = 65.00M, TaxRatio = 0.01M, PurchasePrice = 73.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 17, CategoryID = 7, Name = "Sucuk (220g)", Brand = "Cumhuriyet", SalePrice = 140.00M, TaxRatio = 0.01M, PurchasePrice = 176.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 18, CategoryID = 7, Name = "Bal (460g)", Brand = "Balparmak", SalePrice = 140.00M, TaxRatio = 0.01M, PurchasePrice = 196.80M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 19, CategoryID = 8, Name = "Lay's Klasik (107g)", Brand = "Lay's", SalePrice = 19.00M, TaxRatio = 0.01M, PurchasePrice = 23.99M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 20, CategoryID = 8, Name = "Karışık Kuruyemiş (180g)", Brand = "Peyman", SalePrice = 62.49M, TaxRatio = 0.01M, PurchasePrice = 87.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 21, CategoryID = 8, Name = "Çikolatalı Gofret", Brand = "Ülker", SalePrice = 4.5M, TaxRatio = 0.01M, PurchasePrice = 5.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 22, CategoryID = 9, Name = "Signal White Now Gold", Brand = "Signal", SalePrice = 130.00M, TaxRatio = 0.1M, PurchasePrice = 133.11M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 23, CategoryID = 9, Name = "Şampuan", Brand = "Elidor", SalePrice = 84.99M, TaxRatio = 0.1M, PurchasePrice = 103.50M, Quantity = 1, Unit = Unit.Adet, Stock = 100, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 24, CategoryID = 9, Name = "Sıvı El Sabunu", Brand = "Dove", SalePrice = 80.00M, TaxRatio = 0.1M, PurchasePrice = 90.56M, Quantity = 1, Unit = Unit.Adet, Stock = 18, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },


				 new Product { ProductID = 25, CategoryID = 10, Name = "Domestos Dağ Esintisi", Brand = "Domestos", SalePrice = 33.49M, TaxRatio = 0.2M, PurchasePrice = 39.50M, Quantity = 1, Unit = Unit.Adet, Stock = 25, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 26, CategoryID = 10, Name = "Tuvalet Kağıdı (16'lı)", Brand = "Solo", SalePrice = 130.00M, TaxRatio = 0.2M, PurchasePrice = 164.39M, Quantity = 1, Unit = Unit.Adet, Stock = 10, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" },

				 new Product { ProductID = 27, CategoryID = 10, Name = "Finish Quantum (40'lı)", Brand = "Finish", SalePrice = 54.00M, TaxRatio = 0.2M, PurchasePrice = 71.10M, Quantity = 1, Unit = Unit.Adet, Stock = 15, ExpirationDate = new DateTime(2025, 09, 26), IsContinued = "Satışa Açık" }


				);
		}
	}
}
