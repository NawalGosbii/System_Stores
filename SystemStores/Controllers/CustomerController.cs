using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Customer;

namespace SystemStores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        ICustomer Customer;
        public CustomerController(ICustomer _customer)
        {
            Customer = _customer;
        }
        [HttpGet]
        public List<Domain.Customer> GetCustomer() 
        {
            return Customer.GetCustomers();
        }
        [HttpPost]
        public void PostCustomer(Domain.Models.Customer.AddCustomer customer)
        {
            Customer.Add(customer);
        }
        [HttpPut]
        public void UpdateCustomer(Domain.Models.Customer.UpdateCustomer customer,int id)
        {
            Customer.Update(customer,id);
        }
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            Customer.Delete(id);
        }

    }
}
