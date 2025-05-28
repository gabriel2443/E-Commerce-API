namespace Ecommerce.Application.Models;

public class Product
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
}
