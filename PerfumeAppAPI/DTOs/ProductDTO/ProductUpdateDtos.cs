using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.DTOs.ProductDTO
{
    public class ProductUpdateDtos
    {
        public int Id { get; set; }
        public string ImgSrc { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public  Gender Gender {get; set;}
        public bool OnSale { get; set; }

    }
}
