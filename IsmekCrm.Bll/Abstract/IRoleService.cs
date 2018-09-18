using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Bll.Abstract
{
    public interface IRoleService
    {
        void Add(Role entity);
        void Update(Role entity);
        void Delete(int id);
        Role GetById(int id);
        List<Role> GetAll();
    }
}
