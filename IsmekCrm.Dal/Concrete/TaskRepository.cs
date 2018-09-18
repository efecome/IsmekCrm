using Concrete;
using IsmekCrm.Core.DbAccess;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;

namespace IsmekCrm.Dal.Concrete
{
    public class TaskRepository:EFBaseRepository<Task, IsmekCrmContext>, ITaskRepository
    {
    }
}
