using IsmekCrm.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace Concrete
{
    public class IsmekCrmContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=LAB03-15;Database=IsmekCrm;Integrated Security=True;");

           
        }

        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}