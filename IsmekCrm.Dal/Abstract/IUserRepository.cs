using IsmekCrm.Core.DbAccess;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Dal.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> OrderByIdDesc();
        List<User> OrderByIdAsc();
    }
}
