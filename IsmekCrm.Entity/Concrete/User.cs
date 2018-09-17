using IsmekCrm.Core.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsmekCrm.Entity.Concrete
{
    public class User:IEntity
    {
        public User()
        {
            this.Departmens = new HashSet<Department>();
            this.Tasks = new HashSet<Task>();
            this.Roles = new HashSet<Role>();
        }

       [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage ="Username must be 5-20 characters.", MinimumLength =5)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Username must be 5-20 characters.", MinimumLength = 5)]
        public string Password { get; set; }
        public int UserStatusId { get; set; }


        //Navigation properties for department

        public virtual ICollection<Department> Departmens { get; set; }
        public virtual  ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

    }
}
