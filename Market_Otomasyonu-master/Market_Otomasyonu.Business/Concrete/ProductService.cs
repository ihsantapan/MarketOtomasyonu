using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Concrete
{
	public class ProductService :IProductService
	{
		private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public void Add(Product product)
		{
			_productRepository.Add(product);
		}

		public void Delete(Product product)
		{
			_productRepository.Delete(product);
		}

		public List<Product> GetAll()
		{
			return _productRepository.GetAll();
		}

		public List<Product> GetAllProductWtihCategory()
		{
			return _productRepository.GetAllProductWtihCategory();
		}

		public List<Product> GetAllProductWtihOpenSale()
		{
			return _productRepository.GetByFilterList(x => x.IsContinued == "Satışa Açık");
		}

		public Product GetByFilter(Expression<Func<Product, bool>> filter)
		{
			return _productRepository.GetByFilter(filter);
		}

		public List<Product> GetByFilterList(Expression<Func<Product, bool>> filter)
		{
			return _productRepository.GetByFilterList(filter);
		}

		public Product GetByID(int id)
		{
			return _productRepository.GetByID(id);
		}

		public bool BoolProductListWithLess20Stock()
		{
			var product= _productRepository.GetProductListWithLess20Stock();
			if (product.Count == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public void ProductStatusChangeCloseSale(int id)
		{
			_productRepository.ProductStatusChangeCloseSale(id);
		}

		public void ProductStatusChangeOpenSale(int id)
		{
			_productRepository.ProductStatusChangeOpenSale(id);
		}

		public void Update(Product product)
		{
			_productRepository.Update(product);
		}

		public List<Product> GetProductListWithLess20Stock()
		{
			return _productRepository.GetProductListWithLess20Stock();
		}

		public void ChangeProductCategoryToNull(int categoryId)
		{
			_productRepository.ChangeProductCategoryToNull(categoryId);
		}
	}
}
