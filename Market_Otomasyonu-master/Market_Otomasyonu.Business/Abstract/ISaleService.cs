using Market_Otomasyonu.Entity.Entities;
using System.Linq.Expressions;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface ISaleService
	{
		void Add(Sale sale);

		void Update(Sale sale);

		void Delete(Sale sale);
		List<Sale> GetAll();

		Sale GetByID(int id);
		Sale GetByFilter(Expression<Func<Sale, bool>> filter);
		List<Sale> GetByFilterList(Expression<Func<Sale, bool>> filter);

	}
}
