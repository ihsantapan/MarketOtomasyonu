using Market_Otomasyonu.Data.Context;
using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Repository
{
	public class SaleRepository
	{
		protected readonly AppDbContext _context;
		public SaleRepository()
		{
			_context = new AppDbContext();
		}
		public void Add(Sale sale)
		{
			_context.Sales.Add(sale);
			_context.SaveChanges();
		}


		public void Update(Sale sale)
		{
			_context.Sales.Update(sale);
			_context.SaveChanges();
		}

		public void Delete(Sale sale)
		{
			_context.Sales.Remove(sale);
			_context.SaveChanges();

		}
		public List<Sale> GetAll()
		{
			return _context.Set<Sale>().ToList();
		}

		public Sale GetByID(int id)
		{
			return _context.Set<Sale>().Find(id);
		}

		public Sale GetByFilter(Expression<Func<Sale, bool>> filter)
		{
			return _context.Set<Sale>().First(filter);
		}

		public List<Sale> GetByFilterList(Expression<Func<Sale, bool>> filter)
		{
			return _context.Set<Sale>().Where(filter).ToList();
		}


	}
}
