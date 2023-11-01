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
	public class RoleService : IRoleService
	{
		private readonly RoleRepository _repository;
		public RoleService()
		{
			_repository = new RoleRepository();
		}

		public AppRole GetByFilter(Expression<Func<AppRole, bool>> filter)
		{
			return _repository.GetByFilter(filter);
		}
		public AppRole GetByRoleAdmin()
		{
			return _repository.GetByFilter(x=>x.RoleName=="Admin");
		}

		public int TGetRoleIDByName(string roleName)
		{
			return _repository.GetRoleIdByName(roleName);
		}

	}
}
