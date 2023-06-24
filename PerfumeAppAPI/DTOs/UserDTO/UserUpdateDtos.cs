using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.DTOs.UserDTO
{
    public class UserUpdateDtos
    {
        public string Id{ get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AuthLevels AuthLevel { get; set; }


    }
}
