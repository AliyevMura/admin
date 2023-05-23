using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebFrontToBack.Models.Auth
{
    public class AppUser: IdentityUser
    {
        public string Fullname { get; set; }
        public bool IsActivated { get; set; }
    }
}
