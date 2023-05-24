using System.ComponentModel.DataAnnotations;

namespace StoreApp.API.Data
{
    public class UserRegisterDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
