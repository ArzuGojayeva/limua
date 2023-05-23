using Microsoft.AspNetCore.Identity;

namespace LUMİA.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
    }
}
