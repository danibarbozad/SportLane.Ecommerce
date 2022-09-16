using System.ComponentModel.DataAnnotations;

namespace SportLane.Ecommerce.API.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AddressName { get; set; }

        [Required]
        [StringLength(200)]
        public string Street { get; set; }

        [StringLength(200)]
        public string District { get; set; }

        [Required]        
        public int ZipCode { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(200)]
        public string Reference { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string State { get; set; }

    }
}
