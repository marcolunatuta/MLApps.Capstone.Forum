namespace MLApps.Capstone.Forum.Application.Dto.Entities
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
    }
}