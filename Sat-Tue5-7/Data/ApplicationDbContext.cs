using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sat_Tue5_7.Models;

namespace Sat_Tue5_7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ArchivingModel> ArchvingTable { get; set; }
        public DbSet<StaffModel> StaffTable { get; set; }






    }
}