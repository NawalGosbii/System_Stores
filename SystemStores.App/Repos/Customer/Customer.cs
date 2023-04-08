using Azure.Core;
using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Customer
{
    public class Customer : ICustomer
    {
        AppDbContext appDbContext;
        public Customer(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public void Add(Domain.Models.Customer.AddCustomer customer)
        {
            appDbContext.Database.EnsureCreated();
            var _customer = new Domain.Customer()
            {
                Name = customer.Name,
                Phone = customer.Phone,
            };
            appDbContext.customer.Add(_customer);

            appDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var _customer = appDbContext.customer.FirstOrDefault(x => x.Id == id);
            appDbContext.Remove(_customer);
            appDbContext.SaveChanges();
        }
        public List<Domain.Customer> GetCustomers()
        {
            return appDbContext.customer.ToList();
        }
        public void Update(Domain.Models.Customer.UpdateCustomer customer, int id)
        {
            appDbContext.Database.EnsureCreated();
            var _customer = appDbContext.customer.FirstOrDefault(x => x.Id == id);
            _customer.Name=customer.Name;
            _customer.Phone=customer.Phone;
            appDbContext.customer.Update(_customer);
            appDbContext.SaveChanges();
        }
    }
}
