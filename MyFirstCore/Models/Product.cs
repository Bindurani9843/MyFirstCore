using System;
using System.Collections.Generic;

namespace MyFirstCore.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? Price { get; set; }
        public string? Color { get; set; }
        public int? Quantity { get; set; }
    }
}
