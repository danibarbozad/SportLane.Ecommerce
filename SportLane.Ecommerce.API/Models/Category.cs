using System.ComponentModel.DataAnnotations;

namespace SportLane.Ecommerce.API.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
