namespace BuckleUpApi.Core.Models.Entities
{
    public class User : BaseEntity
    {
        public string Type { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string HashSalt { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }

    }
}