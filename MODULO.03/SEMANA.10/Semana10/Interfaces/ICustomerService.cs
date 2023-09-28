using Semana10.Model;

public interface ICustomerService
{
    Customer GetCustomerById(int id);
    Customer UpdateCustomerEmail(int id, string newEmail);
}

public class CustomerService : ICustomerService
{
    private List<Customer> _customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "Maria", Email = "maria@example.com" },
        new Customer { Id = 2, Name = "João", Email = "joao@example.com" },

    };
    public Customer UpdateCustomerEmail(int id, string newEmail)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer != null)
        {
            customer.Email = newEmail;
        }
        return customer;
    }

    public Customer GetCustomerById(int id)
    {
        return _customers.FirstOrDefault(c => c.Id == id);
    }
}
