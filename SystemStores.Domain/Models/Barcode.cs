namespace SystemStores.Domain.Models
{
    public class Barcode
    {
        public class AddBarcode
        {
            public string Barcode { get; set; }
            public int ProductID { get; set; }
        }
  
        public class UpdateBarcode
        {
            public string Barcode { get; set; }
            public int ProductID { get; set; }
        }
    }
}
