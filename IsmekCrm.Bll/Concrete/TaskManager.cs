using IsmekCrm.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Dal.Abstract;

namespace IsmekCrm.Bll.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskRepository _taskRepository;

        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Add(Entity.Concrete.Task entity)
        {
            _taskRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _taskRepository.Delete(new Entity.Concrete.Task { Id = id });
        }

        public List<Entity.Concrete.Task> GetAll()
        {
            return _taskRepository.GetList().ToList();
        }

        public Entity.Concrete.Task GetById(int id)
        {
            return _taskRepository.Get(x => x.Id == id);
        }

        public void Update(Entity.Concrete.Task entity)
        {
            _taskRepository.Update(entity);
        }
    }
}
