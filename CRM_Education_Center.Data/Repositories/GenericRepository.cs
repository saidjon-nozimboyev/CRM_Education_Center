using CRM_Education_Center.Data.Interfaces;
using CRM_Education_Center.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_Education_Center.Data.Repositories;

public class GenericRepository<T>(AppDbContext dbContext)
    : IGenericRepository<T> where T : BaseEntity
{
    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
