using Concrete;
using IsmekCrm.Core.DbAccess;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Dal.Concrete
{
    public class StatusRepository:EFBaseRepository<Status, IsmekCrmContext>, IStatusRepository
    {
    }
}
