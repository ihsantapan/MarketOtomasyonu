using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface IAppUserService
	{
		void Add(AppUser user);
		void UpdateUser(AppUser user);
		void DeleteUser(AppUser user);
		AppUser GetByFilter(Expression<Func<AppUser, bool>> filter);
		List<AppUser> GetAll();
		AppUser GetByID(int id);
		string PasswordHash(string password);
		string AuthenticateUser(string username, string password);
		string CheckPasswordStrength(string password);
		bool IsUserExist(string name, string surname);
		void AppUserStatusChangeWorking(int id);
		void AppUserStatusChangeNotWorking(int id);

	}
}
