namespace CRM_Education_Center.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty; // Subjects taught
        public string PhoneNumber { get; set; } = string.Empty;
        public List<Group> Groups { get; set; } = new List<Group>(); // G
    }
}
