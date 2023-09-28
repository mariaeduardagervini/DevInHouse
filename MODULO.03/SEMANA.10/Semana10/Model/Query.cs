
using Semana10.Interfaces;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;
namespace Semana10.Model;

public class Query
{
    private readonly IProductService _productService;

    public Query(IProductService productService)
    {
        _productService = productService;
    }

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public List<Product> GetProducts()
    {
        return _productService.GetAllProducts();
    }
}
