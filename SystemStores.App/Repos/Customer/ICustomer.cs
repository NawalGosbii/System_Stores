using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.App.Repos.Customer
{
    public interface ICustomer
    {
        List<Domain.Customer> GetCustomers();
        public void Add(Domain.Models.Customer.AddCustomer customer);
        public void Update(Domain.Models.Customer.UpdateCustomer customer,int id);
        public void Delete(int id);
    }
}
