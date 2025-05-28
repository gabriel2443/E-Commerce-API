namespace Ecommerce.Application.Models;

public class Cart
{
    public required Guid Id { get; set; }
    public Product? Product { get; set; }
}