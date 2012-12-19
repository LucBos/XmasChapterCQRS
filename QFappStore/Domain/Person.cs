using System;
using System.Collections.Generic;

namespace Domain
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}