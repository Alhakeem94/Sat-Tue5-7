using Sat_Tue5_7.Models;

namespace Sat_Tue5_7.RepositoryPatterns.Interfaces
{
    public interface IStaff
    {
        public Task<string> AddStaffMember(StaffModel NewEmp);
        public Task<List<StaffModel>> GetAllStaff();
    }
}
