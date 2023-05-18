using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.API.Data.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }


        public int UserId { get; set; }
        public int ProductId { get; set; }


        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
    }
}
