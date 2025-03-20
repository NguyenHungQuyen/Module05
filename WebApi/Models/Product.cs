using System;

namespace WebApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public short Quantity { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
