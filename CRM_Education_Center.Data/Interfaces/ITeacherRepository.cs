using CRM_Education_Center.Domain.Entities;

namespace CRM_Education_Center.Data.Interfaces
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        Task<List<Teacher>> GetTeachersBySubjectAsync(string subject);
        Task<int> CountTeachersAsync();
        Task<List<Teacher>> GetTeachersWithActiveGroupsAsync();
        Task<List<Teacher>> SearchTeachersByNameAsync(string name);
        Task<Teacher?> GetTeacherWithGroupsAsync(int teacherId);

    }
}
