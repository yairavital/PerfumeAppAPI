using System.ComponentModel.DataAnnotations;
using static PerfumeAppAPI.Enums;

namespace PerfumeAppAPI.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ImgSrc { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
        public Gender Gender { get; set; }
        public ProductType ProductType { get; set; }
        public bool OnSale { get; set; }
    }
}
