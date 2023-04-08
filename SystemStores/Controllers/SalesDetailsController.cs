using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Sales;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesDetailsController : ControllerBase
    {
        ISalesDetails salesDetails;
        public SalesDetailsController(ISalesDetails _salesDetails)
        {
            salesDetails= _salesDetails;
        }
        [HttpGet]
        public List<Domain.SalesDetails> Get()
        {
            return salesDetails.GetSalesDetails();
        }
        [HttpPost]
        public void Post(Domain.Models.SalesDetails.AddSalesDetails addSalesDetails)
        {
            salesDetails.AddSalesDetails(addSalesDetails);
        }
        [HttpPut]
        public void Put(Domain.Models.SalesDetails.UpdateSalesDetails updateSalesDetails,int id)
        {
            salesDetails.UpdateSalesDetails(updateSalesDetails, id);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            salesDetails.DelSalesDetails(id);
        }
    }
}
