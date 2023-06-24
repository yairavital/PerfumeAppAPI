using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerfumeAppAPI.Data.Entities
{
    public class ProductSale
    {
        [Key]
        public int Id { get; set; }

 

        public int UserId { get; set; }

      

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
