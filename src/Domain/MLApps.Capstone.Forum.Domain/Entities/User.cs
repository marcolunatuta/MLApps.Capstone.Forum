namespace MLApps.Capstone.Forum.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public byte[] Password { get; set; } = default!;
        public string? Email { get; set; }
        public bool IsActive { get; set; }

        public string? PasswordString { get; set; }
    }
}