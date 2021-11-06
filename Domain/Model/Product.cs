using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
