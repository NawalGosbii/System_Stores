namespace SystemStores.Domain.Models
{
    public class Customer
    {
        public class AddCustomer
        {
            public string Name { get; set; }
            public string Phone { get; set; }
        }

        public class UpdateCustomer
        {
            public string Name { get; set; }
            public string Phone { get; set; }
        }
    }
}
