using CRM_Education_Center.Domain.Entities;

namespace CRM_Education_Center.Data.Interfaces
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Task<List<Group>> GetGroupsByTeacherIdAsync(int teacherId);
        Task<List<Group>> GetGroupsWithActiveStudentsAsync();
        Task<List<Group>> SearchGroupsByNameAsync(string groupName);
        Task<Group?> GetGroupWithStudentsAsync(int groupId);
        Task<int> CountGroupsByTeacherIdAsync(int teacherId);
        Task<bool> IsGroupNameUniqueAsync(string groupName);
    }
}
