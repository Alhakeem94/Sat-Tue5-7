using Microsoft.EntityFrameworkCore;
using Sat_Tue5_7.Data;
using Sat_Tue5_7.Models;
using Sat_Tue5_7.RepositoryPatterns.Interfaces;

namespace Sat_Tue5_7.RepositoryPatterns.Repositories
{
    public class ArchivingRepository : IArchiving
    {

        private readonly ApplicationDbContext _db;

        public ArchivingRepository(ApplicationDbContext db)
        {
            _db = db;
        }



        public async Task<string> AddFileToTheDb(ArchivingModel NewArchiveObject)
        {
            await _db.ArchvingTable.AddAsync(NewArchiveObject);
            await _db.SaveChangesAsync();
            return "The File Has Been Added To the system";
        }

        public int AddTwoNumbers(int Number1, int Number2)
        {
            int Result = Number1 + Number2;
            return Result;
        }

        public async Task<List<ArchivingModel>> GetAllArchives()
        {
            return await _db.ArchvingTable.ToListAsync();
        }
    }
}
