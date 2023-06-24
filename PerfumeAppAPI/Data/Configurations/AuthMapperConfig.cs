using AutoMapper;
using PerfumeAppAPI.Data.Entities;
using PerfumeAppAPI.DTOs.ProductDTO;
using PerfumeAppAPI.DTOs.UserDTO;

namespace PerfumeAppAPI.Data.Configurations
{
    public class AuthMapperConfig : Profile
    {
        public AuthMapperConfig()
        {
            CreateMap<User, UserRegisterDto>().ReverseMap();
            CreateMap<User, UserUpdateDtos>().ReverseMap();
            CreateMap<Product, NewProductDto>().ReverseMap();


        }
    }
}
