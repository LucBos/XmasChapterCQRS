using System;
using System.Collections.Generic;

namespace Core.GetDemoData
{
    public class GetDemoDataResult
    {
        public class ReviewWithPersonName
        {
            public Guid Id { get; set; }
            public int Stars { get; set; }
            public string Comment { get; set; }
            public string Reviewer { get; set; }
        }

        public IEnumerable<ReviewWithPersonName> Reviews { get; set; }
    }
}
