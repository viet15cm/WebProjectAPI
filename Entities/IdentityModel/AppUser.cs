using Microsoft.AspNetCore.Identity;

namespace WebProjectAPI.Entities.IdentityModel
{
    public class AppUser : IdentityUser
    {
        public string Address { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
