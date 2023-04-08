using Azure.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.Domain;
using SystemStores.Domain.Models;
using SystemStores.infra.Data;
using static System.Net.Mime.MediaTypeNames;

namespace SystemStores.App.Repos.Product
{
    public class Product : IProduct
    {
        AppDbContext AppDbContext;
        public Product(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            AppDbContext.Database.EnsureCreated();
        }
        public void AddProduct(Domain.Models.Product.AddProduct _product)
        {
            AppDbContext.Database.EnsureCreated();
            var prodect = new Domain.Products()
            {
                Description = _product.Description,
                ProductImage = _product.ProductImage,
                CategoryID = _product.CategoryID,
            };
            AppDbContext.products.Add(prodect);
            AppDbContext.SaveChanges();
        }
        public void DelProduct(int id)
        {
            var prodect = AppDbContext.products.FirstOrDefault(i => i.Id == id);
            AppDbContext.products.Remove(prodect);
            AppDbContext.SaveChanges();
        }
        public List<Products> GetProducts()
        {
            return AppDbContext.products.ToList();
        }
        public void UpdateProduct(Domain.Models.Product.UpdateProduct _prodect, int id)
        {
            var prodect = AppDbContext.products.FirstOrDefault(i => i.Id == id);
            prodect.Description = _prodect.Description;
            prodect.ProductImage = _prodect.ProductImage;
            prodect.CategoryID = _prodect.CategoryID;
            AppDbContext.products.Update(prodect);
            AppDbContext.SaveChanges();
        }
    }
}
