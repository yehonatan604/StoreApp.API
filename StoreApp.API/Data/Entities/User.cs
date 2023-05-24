using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.API.Data.Entities
{
    public class User : IdentityUser
    {
        public AuthLevels AuthLevel { get; set; }
    }

    
}
