using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        // Ideally, products would be fetched from the vendor's API here.
        // For simplicity, we use hardcoded data.
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Description = "Description A", BasePrice = 100 },
            new Product { Id = 2, Name = "Product B", Description = "Description B", BasePrice = 150 },
        };

        return products;
    }
}
