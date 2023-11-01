using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Concrete
{
	public class SaleService : ISaleService
	{
		private readonly SaleRepository _saleRepository;
        public SaleService()
        {
            _saleRepository = new SaleRepository();
        }
        public void Add(Sale sale)
		{
			_saleRepository.Add(sale);
		}

		public void Delete(Sale sale)
		{
			_saleRepository.Delete(sale);
		}

		public List<Sale> GetAll()
		{
			return _saleRepository.GetAll();
		}

		public Sale GetByFilter(Expression<Func<Sale, bool>> filter)
		{
			return _saleRepository.GetByFilter(filter);
		}

		public List<Sale> GetByFilterList(Expression<Func<Sale, bool>> filter)
		{
			return _saleRepository.GetByFilterList(filter);
		}

		public Sale GetByID(int id)
		{
			return _saleRepository.GetByID(id);
		}

		public void Update(Sale sale)
		{
			_saleRepository.Update(sale);	
		}
	}
}
