using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsOrdered { get; set; }

        public Person Person { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}