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
	public class RoleRepository
	{
		private readonly AppDbContext _context;
		public RoleRepository()
		{
			_context = new AppDbContext();
		}
		public int GetRoleIdByName(string roleName)
		{
			var role = _context.Roles.FirstOrDefault(r => r.RoleName == roleName);
			return role.RoleID;
		}
		public AppRole GetByFilter(Expression<Func<AppRole, bool>> filter)
		{
			return _context.Set<AppRole>().First(filter);
		}


	}
}
