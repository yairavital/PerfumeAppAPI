using System.ComponentModel.DataAnnotations;
using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.DTOs.UserDTO
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
        public AuthLevels AuthLevel { get; set;  }

    }
}
