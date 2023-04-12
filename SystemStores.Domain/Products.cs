namespace SystemStores.Domain
{
    public class Products
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }
        public int CategoryID { get; set; }


        public Category Category { get; set; }
        public List<Barcode> barcodes { get; set; }
        public List<PurchasesDetails> purchasesDetails { get; set; }
        public List<SalesDetails> salesDetails { get; set; }
    }
}
