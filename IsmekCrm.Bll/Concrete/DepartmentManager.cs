using IsmekCrm.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Dal.Abstract;

namespace IsmekCrm.Bll.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentRepository _departmentService;

        public DepartmentManager(IDepartmentRepository departmentService)
        {
            _departmentService = departmentService;
        }

        public void Add(Department entity)
        {
            _departmentService.Add(entity);
        }

        public void Delete(int id)
        {
            _departmentService.Delete(new Department { Id = id });
        }

        public List<Department> GetAll()
        {
            return _departmentService.GetList().ToList();
        }

        public Department GetById(int id)
        {
            return _departmentService.Get(x => x.Id == id);
        }

        public void Update(Department entity)
        {
            _departmentService.Update(entity);
        }
    }
}
