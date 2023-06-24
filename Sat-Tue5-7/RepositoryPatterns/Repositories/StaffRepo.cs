using Microsoft.EntityFrameworkCore;
using Sat_Tue5_7.Data;
using Sat_Tue5_7.Models;
using Sat_Tue5_7.RepositoryPatterns.Interfaces;

namespace Sat_Tue5_7.RepositoryPatterns.Repositories
{
    public class StaffRepo : IStaff
    {

        private ApplicationDbContext Db;

        public StaffRepo(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task<string> AddStaffMember(StaffModel NewEmp)
        {
            Db.StaffTable.Add(NewEmp);
            Db.SaveChanges();
            return "The Emp Has Been Added To The DataBase";
        }

        public async Task<List<StaffModel>> GetAllStaff()
        {
            var ListOfAllStaff = await Db.StaffTable.ToListAsync();
            return ListOfAllStaff;
        }
    }
}
