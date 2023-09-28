using HotChocolate;
using Semana10.Interfaces;


namespace Semana10.Model;
public class Mutation
{
    private readonly IProductService _productService;

    public Mutation(IProductService productService)
    {
        _productService = productService;
    }

    public Product AddProduct(string name, decimal price)
    {
        var newProduct = new Product
        {
            Name = name,
            Price = price
        };

        var addedProduct = _productService.AddProduct(newProduct);

        return addedProduct;
    }
}
