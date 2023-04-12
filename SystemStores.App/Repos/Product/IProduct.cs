namespace SystemStores.App.Repos.Product
{
    public interface IProduct
    {
        List<Domain.Products> GetProducts();
        List<Domain.Products> GetProduct(int id);
        List<Domain.Products> GetProducts(string name);
        public void AddProduct(Domain.Models.Product.AddProduct Product);
        public void UpdateProduct(Domain.Models.Product.UpdateProduct Product, int id);
        public void DelProduct(int id);
    }
}
