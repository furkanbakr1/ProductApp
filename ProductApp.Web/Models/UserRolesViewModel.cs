namespace ProductApp.Web.Models
{
    public class UserRolesViewModel
    {
        public string? UserId { get; set; }
        public string? Email { get; set; }
        public List<string>? AllRoles { get; set; }
        public List<string> UserRoles { get; set; } = new();
    }
}
