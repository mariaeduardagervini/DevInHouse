using Semana10.Model;
using System.Collections.Generic;

namespace Semana10.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product AddProduct(Product product);
    }

    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Banana", Price = 1 },
            new Product { Id = 2, Name = "Maçã", Price = 2 },
        };

        private int _nextProductId = 3; 

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product AddProduct(Product product)
        {
            product.Id = _nextProductId++;
            _products.Add(product);
            return product;
        }
    }
}
