namespace SystemStores.Domain
{
    public class Barcode
    {
        public int Id { get; set; }
        public string barcode { get; set; }
        public int ProductID { get; set; }
        public Products Products { get; set; }
    }
}
