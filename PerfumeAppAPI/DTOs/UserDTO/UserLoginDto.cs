using System.ComponentModel.DataAnnotations;

namespace PerfumeAppAPI.DTOs.UserDTO
{
    public class UserLoginDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
