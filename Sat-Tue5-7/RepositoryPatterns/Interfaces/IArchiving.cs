using Sat_Tue5_7.Models;

namespace Sat_Tue5_7.RepositoryPatterns.Interfaces
{
    public interface IArchiving
    {
        public int AddTwoNumbers(int Number1, int Number2); // Defenition
        public Task<string> AddFileToTheDb(ArchivingModel NewArchiveObject);
        public Task<List<ArchivingModel>> GetAllArchives();

        // public Task<Reciept> Murtada (Money membershipMoney);
    }
}
