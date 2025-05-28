namespace Ecommerce.Application.Models;

public class Cart
{
    public required Guid Id { get; set; }
    public required List<Product?> Products { get; set; }
    public required int Quantity { get; set; }
}