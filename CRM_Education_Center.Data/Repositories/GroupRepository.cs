using CRM_Education_Center.Data.DbContexts;
using CRM_Education_Center.Data.Interfaces;
using CRM_Education_Center.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_Education_Center.Data.Repositories
{
    public class GroupRepository(AppDbContext dbContext) : GenericRepository<Group>(dbContext), IGroupRepository
    {
        public async Task<int> CountGroupsByTeacherIdAsync(int teacherId)
        {
            return await _dbContext.Groups.CountAsync(g => g.TeacherId == teacherId);
        }

        public async Task<List<Group>> GetGroupsByTeacherIdAsync(int teacherId)
        {
            return await _dbContext.Groups
                .Where(g => g.TeacherId == teacherId)
                .ToListAsync();
        }

        public async Task<List<Group>> GetGroupsWithActiveStudentsAsync()
        {
            return await _dbContext.Groups
                .Include(g => g.Students)
                .Where(g => g.Students.Any(s => s.IsActive))
                .ToListAsync();
        }

        public async Task<Group?> GetGroupWithStudentsAsync(int groupId)
        {
            return await _dbContext.Groups
                .Include(g => g.Students)
                .FirstOrDefaultAsync(g => g.Id == groupId);
        }

        public async Task<bool> IsGroupNameUniqueAsync(string groupName)
        {
            return !await _dbContext.Groups.AnyAsync(g => g.Name == groupName);
        }

        public async Task<List<Group>> SearchGroupsByNameAsync(string groupName)
        {
            return await _dbContext.Groups
                .Where(g => EF.Functions.Like(g.Name, $"%{groupName}%"))
                .ToListAsync();
        }
    }
}
