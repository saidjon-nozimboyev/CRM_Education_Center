using CRM_Education_Center.Data.DbContexts;
using CRM_Education_Center.Data.Interfaces;
using CRM_Education_Center.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_Education_Center.Data.Repositories
{
    public class PaymentRepository(AppDbContext dbContext) : GenericRepository<Payment>(dbContext), IPaymentRepository
    {
        public async Task<List<Payment>> GetPaymentsByUserIdAsync(int userId)
        {
            return await _dbContext.Payments
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }

        public async Task<List<Payment>> GetPaymentsByGroupIdAsync(int groupId)
        {
            return await _dbContext.Payments
                .Where(p => p.Id == groupId)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalPaymentsByUserIdAsync(int userId)
        {
            return await _dbContext.Payments
                .Where(p => p.UserId == userId)
                .SumAsync(p => p.Amount);
        }
    }
}
