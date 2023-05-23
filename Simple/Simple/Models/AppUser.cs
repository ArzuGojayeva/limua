using Microsoft.AspNetCore.Identity;

namespace Simple.Models
{
    public class AppUser:IdentityUser
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
