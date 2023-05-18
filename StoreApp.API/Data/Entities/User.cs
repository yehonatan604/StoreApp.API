using Microsoft.AspNetCore.Identity;

namespace StoreApp.API.Data.Entities
{
    public class User : IdentityUser
    {
        public string Password { get; set; }
        public AuthLevels AuthLevel { get; set; }
    }
}
