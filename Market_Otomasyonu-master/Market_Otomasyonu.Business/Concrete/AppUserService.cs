using Market_Otomasyonu.Business.Abstract;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Concrete
{
	public class AppUserService : IAppUserService
	{
		private readonly AppUserRepository _appUserRepository;
		public AppUserService()
		{
			_appUserRepository = new AppUserRepository();
		}
		public string PasswordHash(string password)
		{
			using (SHA256 hash = SHA256Managed.Create())
			{
				return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
			}
		}
		public string AuthenticateUser(string username, string password)
		{

			return _appUserRepository.UserAuthenticationResult(username, password);
		}
		public bool IsUserExist(string name, string surname)
		{
			if (_appUserRepository.IsEmailExist(name, surname))
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool ArePasswordsMatching(string password, string confirmPassword)
		{
			return password.Equals(confirmPassword);
		}

		public void Add(AppUser user)
		{
			_appUserRepository.Add(user);
		}
		public string CheckPasswordStrength(string password)
		{
			bool hasUpperCase = false;
			bool hasLowerCase = false;
			bool hasDigit = false;
			bool hasSpecialChar = false;

			foreach (char character in password)
			{
				if (char.IsUpper(character))
				{
					hasUpperCase = true;
				}
				else if (char.IsLower(character))
				{
					hasLowerCase = true;
				}
				else if (char.IsDigit(character))
				{
					hasDigit = true;
				}
				else if (!char.IsLetterOrDigit(character))
				{
					hasSpecialChar = true;
				}
			}

			if (hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && password.Length >= 8)
			{
				return "Güçlü Şifre...";
			}
			else if (hasDigit && hasLowerCase && password.Length >= 8)
			{
				return "Orta Seviye...";
			}
			else
			{
				return "Zayıf Şifre...";
			}
		}
		public AppUser GetByFilterUser(Expression<Func<AppUser, bool>> filter)
		{
			return _appUserRepository.GetByFilter(filter);
		}

		public AppUser GetByFilter(Expression<Func<AppUser, bool>> filter)
		{
			return _appUserRepository.GetByFilter(filter);
		}

		public List<AppUser> GetAll()
		{
			return _appUserRepository.GetAll();
		}

		public AppUser GetByID(int id)
		{
			return _appUserRepository.GetByID(id);
		}

		public void AppUserStatusChangeWorking(int id)
		{
			_appUserRepository.AppUserStatusChangeWorking(id);
		}

		public void AppUserStatusChangeNotWorking(int id)
		{
			_appUserRepository.AppUserStatusChangeNotWorking(id);
		}

		public void UpdateUser(AppUser user)
		{
			_appUserRepository.Update(user);
		}

		public void DeleteUser(AppUser user)
		{
			_appUserRepository.Delete(user);
		}
		
	}
}
