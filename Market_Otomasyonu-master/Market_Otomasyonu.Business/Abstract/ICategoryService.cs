using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface ICategoryService
	{
		void AddCategory(Category category);
		void UpdateCategory(Category category);
		void DeleteCategory(Category category);
		List<Category> GetAllCategory();
		Category GetByIDCategory(int id);
		Category GetByFilterCategory(Expression<Func<Category, bool>> filter);
		List<Category> GetByFilterListCategory(Expression<Func<Category, bool>> filter);
		bool IsCategoryExist(string name);
		void CategoryStatusChangeActive(int id);
		void CategoryStatusChangeDisable(int id);
		List<Category> GetCategoryWithCategoryActive();

	}
}
