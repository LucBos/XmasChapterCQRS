using System;

namespace Domain
{
    public class Review
    {
        public Guid Id { get; set; }
        public int NrOfStars { get; set; }
        public string Comment { get; set; }

        public Product Product { get; set; }
    }
}