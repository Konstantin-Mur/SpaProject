namespace SpaProject.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime DateRegistration { get; set; }
        public string Email { get; set; }
        public string? Sity { get; set; }
    }
}