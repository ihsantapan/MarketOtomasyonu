using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using System.Linq.Expressions;

namespace Market_Otomasyonu.Business.Concrete
{
	public class CategoryService : ICategoryService
	{
		private readonly CategoryRepository _categoryRepository;
		public CategoryService()
		{
			_categoryRepository = new CategoryRepository();
		}

		public void AddCategory(Category category)
		{
			_categoryRepository.Add(category);
		}

		public void UpdateCategory(Category category)
		{
			_categoryRepository.Update(category);
		}

		public void DeleteCategory(Category category)
		{
			_categoryRepository.Delete(category);

		}
		public List<Category> GetAllCategory()
		{
			return _categoryRepository.GetAll();
		}


		public Category GetByIDCategory(int id)
		{
			return _categoryRepository.GetByID(id);
		}

		public Category GetByFilterCategory(Expression<Func<Category, bool>> filter)
		{
			return _categoryRepository.GetByFilter(filter);
		}

		public List<Category> GetByFilterListCategory(Expression<Func<Category, bool>> filter)
		{
			return _categoryRepository.GetByFilterList(filter);
		}

		public bool IsCategoryExist(string name)
		{
			return _categoryRepository.IsCategoryExist(name);
		}

		public void CategoryStatusChangeActive(int id)
		{
			_categoryRepository.CategoryStatusChangeActive(id);
		}

		public void CategoryStatusChangeDisable(int id)
		{
			_categoryRepository.CategoryStatusChangeDisable(id);
		}

		public List<Category> GetCategoryWithCategoryActive()
		{
			return _categoryRepository.GetCategoryWithCategoryActive();
		}
	}
}
