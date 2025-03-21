namespace WebApp.Models;
public class Product
{
    public int ProductId { get; set; }
    public short CategoryId { get; set; }
    public string ProductName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public short Quantity { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string Unit { get; set; } = null!;
}