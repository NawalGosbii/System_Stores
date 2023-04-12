using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemStores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        IProduct product;
        public ProductController(IProduct _product)
        {
            product = _product;
        }
        [HttpGet]
        public List<Domain.Products> AllProducts()
        {
            return product.GetProducts();
        }
        [HttpGet("SearchID")]
        public List<Domain.Products> GetProduct(int id)
        {
            return product.GetProduct(id);
        }
        [HttpGet("SearchName")]
        public List<Domain.Products> GetProducts(string name)
        {
            return product.GetProducts(name);
        }
        [HttpPost]
        public void add(Domain.Models.Product.AddProduct product)
        {
            this.product.AddProduct(product);
        }

        [HttpPut("{id}")]
        public void Update(Domain.Models.Product.UpdateProduct product, int id)
        {
            this.product.UpdateProduct(product, id);
        }
        [HttpDelete("{id}")]
        public void DelProduct(int id)
        {
            this.product.DelProduct(id);
        }
    }
}