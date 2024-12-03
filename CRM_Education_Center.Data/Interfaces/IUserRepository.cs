using CRM_Education_Center.Domain.Entities;

namespace CRM_Education_Center.Data.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> SearchUsersByNameAsync(string name);

        Task<List<User>> GetUsersByRoleAsync(string role);

        Task<int> CountUsersByRoleAsync(string role);

    }
}
