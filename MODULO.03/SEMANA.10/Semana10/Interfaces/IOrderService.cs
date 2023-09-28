using Semana10.Model;

namespace Semana10.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrdersByCustomer(int customerId);
    }

    public class OrderService : IOrderService
    {
        private List<Order> _orders = new List<Order>
    {
        new Order { Id = 1, OrderNumber = "ORD123", TotalAmount = 100.0m },
        new Order { Id = 2, OrderNumber = "ORD456", TotalAmount = 150.0m },
        // Adicione mais pedidos conforme necessário
    };

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            return _orders.Where(o => o.Id == customerId).ToList();
        }
    }

}
