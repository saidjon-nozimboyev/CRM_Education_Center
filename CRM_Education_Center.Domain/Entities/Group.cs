namespace CRM_Education_Center.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Group name
        public int TeacherId { get; set; } // Assigned Teacher
        public Teacher Teacher { get; set; } = new Teacher(); // Navigation property
        public List<User> Students { get; set; } = new List<User>(); // Students in the group
    }
}
