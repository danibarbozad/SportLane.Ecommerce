using System.ComponentModel.DataAnnotations;

namespace SportLane.Ecommerce.API.Models
{
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
