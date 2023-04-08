namespace SystemStores.Domain.Models
{
    public class PurchasesDetails
    {
        public class AddPurchasesDetails
        {
            public int PurchaseID { get; set; }
            public int ProdectID { get; set; }
            public int Quantity { get; set; }
        }
     
        public class UpdatePurchasesDetails
        {
            public int PurchaseID { get; set; }
            public int ProdectID { get; set; }
            public int Quantity { get; set; }
        }
    }
}
