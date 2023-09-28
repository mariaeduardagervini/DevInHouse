
using Semana10.Interfaces;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;
namespace Semana10.Model;

public class Query
{
    private readonly IProductService _productService;
    private readonly ICustomerService _customerService;
    private readonly IOrderService _orderService;

    public Query(IProductService productService, ICustomerService customerService, IOrderService orderService)
    {
        _productService = productService;
        _customerService = customerService;
        _orderService = orderService;
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

    public List<Order> GetOrdersByCustomer(int customerId)
    {
        return _orderService.GetOrdersByCustomer(customerId);
    }
}
