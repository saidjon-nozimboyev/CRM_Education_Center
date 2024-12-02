using CRM_Education_Center.Domain.Enums;

namespace CRM_Education_Center.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Role Role { get; set; } = Role.Student; // Default role is Student
        public List<Payment> Payments { get; set; } = new List<Payment>(); // Payment history
        public int GroupId { get; set; } // Group the user belongs to
        public Group Group { get; set; } = new Group(); // Navigation property
    }
}
