using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Entity.Concrete
{
    public class Department : Base
    {
        public Department()
        {
            this.Users = new HashSet<User>();
        }
        public virtual ICollection<User> Users { get; set; }
    }
}
