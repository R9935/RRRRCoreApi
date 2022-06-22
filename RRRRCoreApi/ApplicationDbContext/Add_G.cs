using Microsoft.EntityFrameworkCore;
using RRRRCoreApi.Model;

namespace RRRRCoreApi.ApplicationDbContext
{
    public class Add_G : DbContext
    {
        public Add_G(DbContextOptions<Add_G> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserInfo> Users { get; set; }
    }
}