using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public List<Product> Products { get; set; }
    }
}