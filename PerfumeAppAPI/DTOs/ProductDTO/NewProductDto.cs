using System.ComponentModel.DataAnnotations;
using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.DTOs.ProductDTO
{
    public class NewProductDto
    { 
        [Required]
        public string ImgSrc { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public bool OnSale { get; set; }
        public ProductType ProductType { get; set; }

    }
}
