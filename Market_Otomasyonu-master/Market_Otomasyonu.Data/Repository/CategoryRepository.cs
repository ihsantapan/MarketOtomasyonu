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
	public class CategoryRepository
	{
		private readonly AppDbContext _context;
		public CategoryRepository()
		{
			_context = new AppDbContext();
		}
		public void Add(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
		}

		public void Update(Category category)
		{
			_context.Categories.Update(category);
			_context.SaveChanges();
		}

		public void Delete(Category category)
		{
			_context.Categories.Remove(category);
			_context.SaveChanges();

		}
		public List<Category> GetAll()
		{
			return _context.Categories.Where(x => x.CategoryID != 1).ToList();
		}

		public Category GetByID(int id)
		{
			return _context.Set<Category>().Find(id);
		}

		public Category GetByFilter(Expression<Func<Category, bool>> filter)
		{
			return _context.Set<Category>().First(filter);
		}

		public List<Category> GetByFilterList(Expression<Func<Category, bool>> filter)
		{
			return _context.Set<Category>().Where(filter).ToList();
		}
		public Category GetByName(string categoryName)
		{
			return _context.Set<Category>().FirstOrDefault(c => c.Name == categoryName);
		}
		public bool IsCategoryExist(string name)
		{
			var category = _context.Categories.Any(x => x.Name == name);
			return category;
		}
		public void CategoryStatusChangeActive(int id)
		{
			var values = _context.Categories.Find(id);
			values.IsActive = "Aktif";
			_context.SaveChanges();
		}

		public void CategoryStatusChangeDisable(int id)
		{
			var values = _context.Categories.Find(id);
			values.IsActive = "Pasif";
			_context.SaveChanges();
		}

		public List<Category> GetCategoryWithCategoryActive()
		{
			return _context.Categories.Where(x => x.IsActive == "Aktif").ToList();
		}


	}
}
