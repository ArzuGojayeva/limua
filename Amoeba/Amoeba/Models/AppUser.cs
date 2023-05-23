using Microsoft.AspNetCore.Identity;

namespace Amoeba.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
    }
}
