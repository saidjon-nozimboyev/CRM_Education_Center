using CRM_Education_Center.Domain.Enums;

namespace CRM_Education_Center.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set; } // Reference to the paying user
        public User User { get; set; } = new User(); // Navigation property
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public PaymentMethod Method { get; set; } = PaymentMethod.Cash; // Default payment method
        public string Description { get; set; } = string.Empty; // Additional details
    }
}
