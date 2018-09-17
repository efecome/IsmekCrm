using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsmekCrm.Entity.Concrete
{
    public class Task: IEntity
    {
        public Task()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        //[ForeignKey("Status")]
        public int StatusId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Navigation properties
        public virtual ICollection<User> Users { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
    }
}
