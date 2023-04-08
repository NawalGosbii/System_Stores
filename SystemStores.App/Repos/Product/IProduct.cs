using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.Domain;

namespace SystemStores.App.Repos.Product
{
    public interface IProduct
    {
        List<Domain.Products> GetProducts();
        public void AddProduct(Domain.Models.Product.AddProduct Product);
        public void UpdateProduct(Domain.Models.Product.UpdateProduct Product, int id);
        public void DelProduct(int id);
    }
}
