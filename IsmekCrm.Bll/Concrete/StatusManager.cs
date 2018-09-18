using IsmekCrm.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Dal.Abstract;

namespace IsmekCrm.Bll.Concrete
{
    public class StatusManager : IStatusService
    {
        IStatusRepository _statusService;
        public StatusManager(IStatusRepository statusService)
        {
            _statusService = statusService;
        }
        public void Add(Status entity)
        {
            _statusService.Add(entity);
        }

        public void Delete(int id)
        {
            _statusService.Delete(new Status { Id = id });
        }

        public List<Status> GetAll()
        {
            return _statusService.GetList().ToList();
        }

        public Status GetById(int id)
        {
            return _statusService.Get(x => x.Id == id);
        }

        public void Update(Status entity)
        {
            _statusService.Update(entity);
        }
    }
}
