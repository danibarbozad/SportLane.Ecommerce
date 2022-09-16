using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportLane.Ecommerce.API.Models
{
    public class OrderItems
    {
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }
    }
}
