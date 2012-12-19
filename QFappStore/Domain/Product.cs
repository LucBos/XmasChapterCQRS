using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InPromotion { get; set; }
        public decimal PromotionPrice { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}