using Microsoft.AspNetCore.Identity;

namespace CodeAlongGr9.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}
