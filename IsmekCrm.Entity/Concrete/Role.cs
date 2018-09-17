using IsmekCrm.Core.Entity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsmekCrm.Entity.Concrete
{
    public class Role : Base
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        public virtual ICollection<User> Users { get; set; }
    }
}
