using Semana10.Model;

namespace Semana10.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();
}

public class ProductService : IProductService
{
    private List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Banana", Price = 1 },
        new Product { Id = 2, Name = "Maçã", Price = 2 },

    };

    public List<Product> GetAllProducts()
    {
        return _products;
    }
}
