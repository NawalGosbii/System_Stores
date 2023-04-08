using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Sales;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        ISales sales;
        public SalesController(ISales _sales)
        {
            sales = _sales;
        }
        [HttpGet]
        public List<Domain.Sales> Get()
        {
            return sales.GetSales();
        }
        [HttpPost]
        public void Post(Domain.Models.Sales.AddSales addSales)
        {
            sales.AddSales(addSales);
        }
        [HttpPut]
        public void Put(Domain.Models.Sales.UpdateSales updateSales,int id)
        {
            sales.UpdateSales(updateSales, id);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            sales.DelSales(id);
        }
    }
}
