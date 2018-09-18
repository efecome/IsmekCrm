using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Bll.Abstract
{
    public interface IStatusService
    {
        void Add(Status entity);
        void Update(Status entity);
        void Delete(int id);
        Status GetById(int id);
        List<Status> GetAll();
    }
}
