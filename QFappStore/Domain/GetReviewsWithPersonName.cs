using System;

namespace Domain
{
    public class GetReviewsWithPersonName
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public int NrOfStars { get; set; }
        public string Comment { get; set; }
    }
}