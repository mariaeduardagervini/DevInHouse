using HotChocolate;
using Semana10.Interfaces;


namespace Semana10.Model;
public class Mutation
{
    private readonly IProductService _productService;
    private readonly ICustomerService _customerService;

    public Mutation(IProductService productService, ICustomerService customerService)
    {
        _productService = productService;
        _customerService = customerService;
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
    public Customer UpdateCustomerEmail(int id, string newEmail)
    {
        // Chame o serviço para atualizar o e-mail do cliente
        var updatedCustomer = _customerService.UpdateCustomerEmail(id, newEmail);
        return updatedCustomer;
    }
}
