namespace SystemStores.Domain.Models
{
    public class Product
    {
        public class AddProduct
        {
            public string Description { get; set; }
            public byte[] ProductImage { get; set; }
            public int CategoryID { get; set; }
        }

        public class UpdateProduct
        {
            public string Description { get; set; }
            public byte[] ProductImage { get; set; }
            public int CategoryID { get; set; }
        }
    }
}
