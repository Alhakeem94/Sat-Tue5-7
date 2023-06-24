using Sat_Tue5_7.RepositoryPatterns.Interfaces;

namespace Sat_Tue5_7.RepositoryPatterns.Repositories
{
    public class ArchivingRepository : IArchiving
    {
        public int AddTwoNumbers(int Number1, int Number2)
        {
            int Result = Number1 + Number2;
            return Result;
        }
    }
}
