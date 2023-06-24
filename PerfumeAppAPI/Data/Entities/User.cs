using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.Data.Entities
{
    public class User:IdentityUser
    { 
    


        public AuthLevels AuthLevel { get; set; }

    }
  
}
