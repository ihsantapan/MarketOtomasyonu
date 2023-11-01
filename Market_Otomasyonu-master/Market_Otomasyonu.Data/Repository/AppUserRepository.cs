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
	public class AppUserRepository
	{
		private readonly AppDbContext _context;
		public AppUserRepository()
		{
			_context = new AppDbContext();
		}

		public string UserAuthenticationResult(string username, string password)
		{
			var userExists = _context.Users.FirstOrDefault(u => u.Username == username);

			if (userExists != null)
			{
				if (userExists.Password == password)
				{
					return "Giriş Başarılı";
				}
				else
				{
					return "Şifre Yanlış";
				}
			}
			else
			{
				return "Kullanıcı Bulunamadı";
			}
		}
		public bool IsEmailExist(string name, string surname)
		{
			var user = _context.Users.Any(x => x.Name == name && x.Surname == surname);
			return user;
		}
		public void Add(AppUser user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
		}
		public void Update(AppUser user)
		{
			_context.Users.Update(user);
			_context.SaveChanges();
		}

		public void Delete(AppUser user)
		{
			_context.Users.Remove(user);
			_context.SaveChanges();

		}
		public AppUser GetByFilter(Expression<Func<AppUser, bool>> filter)
		{
			return _context.Set<AppUser>().First(filter);
		}
		public List<AppUser> GetAll()
		{
			return _context.Set<AppUser>().ToList();
		}

		public AppUser GetByID(int id)
		{
			return _context.Set<AppUser>().Find(id);
		}
		public void AppUserStatusChangeWorking(int id)
		{
			var values = _context.Users.Find(id);
			values.IsWorking = "Çalışıyor";
			_context.SaveChanges();
		}

		public void AppUserStatusChangeNotWorking(int id)
		{
			var values = _context.Users.Find(id);
			values.IsWorking = "Çalışmıyor";
			_context.SaveChanges();
		}

	}
}
