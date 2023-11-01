using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface IRoleService
	{
		int TGetRoleIDByName(string roleName);
		AppRole GetByFilter(Expression<Func<AppRole, bool>> filter);
	}
}
