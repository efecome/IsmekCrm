using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Bll.Abstract
{
    interface IDepartmentService
    {
        void Add(Department entity);
        void Update(Department entity);
        void Delete(int id);
        Department GetById(int id);
        List<Department> GetAll();
    }
}
