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
        public List<Domain.Products> GetProducts()
        {
            return product.GetProducts();
        }
        [HttpGet("{id}")]
        public List<Domain.Products> GetProducts(int id)
        {
            return product.GetProducts();
        }
        [HttpPost]
        public void add(Domain.Models.Product.AddProduct product)
        {
            this.product.AddProduct(product);
        }

        [HttpPut]
        public void Update(Domain.Models.Product.UpdateProduct product, int id)
        {
            this.product.UpdateProduct(product, id);
        }
        [HttpDelete]
        public void DelProduct(int id) { this.product.DelProduct(id); }
    }
}