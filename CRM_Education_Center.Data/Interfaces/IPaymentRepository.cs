using CRM_Education_Center.Domain.Entities;

namespace CRM_Education_Center.Data.Interfaces
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<List<Payment>> GetPaymentsByUserIdAsync(int userId);
        Task<List<Payment>> GetPaymentsByGroupIdAsync(int groupId);
        Task<decimal> GetTotalPaymentsByUserIdAsync(int userId);
    }
}
