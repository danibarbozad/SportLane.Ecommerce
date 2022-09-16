using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportLane.Ecommerce.API.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }

        public OrderStatus OrderStatus { get; set; }
        [ForeignKey("OrderStatus")]
        public int? OrderStatusId { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        public Address Address { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }

        public Nullable<double> OrderTotalPrice { get; set; }

    }
}
