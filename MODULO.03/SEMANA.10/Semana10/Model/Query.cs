
using Semana10.Interfaces;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;
namespace Semana10.Model;

public class Query
{
    private readonly IProductService _productService;
    private readonly ICustomerService _customerService;

    public Query(IProductService productService, ICustomerService customerService)
    {
        _productService = productService;
        _customerService = customerService;
    }

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public List<Product> GetProducts()
    {
        return _productService.GetAllProducts();
    }

    public Customer GetCustomer(int id)
    {
        return _customerService.GetCustomerById(id);
    }
}
