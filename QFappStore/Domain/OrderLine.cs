using System;

namespace Domain
{
    public class OrderLine
    {
        public Guid Id { get; set; }
        public decimal PriceWhenOrdered { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}