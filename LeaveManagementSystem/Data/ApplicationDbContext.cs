using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<Emplyee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Leavetype> Leavetypes { get; set; }
        public DbSet<LeaveAllocation> Leaveallocations { get; set; }
    }
}