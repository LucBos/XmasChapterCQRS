using System;

namespace Domain
{
    public class ReviewsWithPersonName
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public int NrOfStars { get; set; }
        public string Comment { get; set; }
    }
}