using IsmekCrm.Core.Entity;
using System.Collections;
using System.Collections.Generic;

namespace IsmekCrm.Entity.Concrete
{
    public class Status :  Base
    {
        public Status()
        {
            this.Tasks = new HashSet<Task>();
        }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
