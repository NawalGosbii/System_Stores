namespace SystemStores.Domain.Models
{
    public class Purchases
    {
        public class AddPurchases
        {
            public DateTime Date { get; set; }
            public string Name { get; set; }
        }

        public class UpdatePurchases
        {
            public DateTime Date { get; set; }
            public string Name { get; set; }
        }
    }
}
