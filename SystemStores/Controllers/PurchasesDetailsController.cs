using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Purchases;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesDetailsController : ControllerBase
    {
        IPurchasesDetails PurchasesDetails;
        public PurchasesDetailsController(IPurchasesDetails purchasesDetails)
        {
            PurchasesDetails = purchasesDetails;
        }
        [HttpGet]
        public List<Domain.PurchasesDetails> Get()
        {
            return PurchasesDetails.GetPurchasesDetails();
        }
        [HttpPost]
        public void Post(Domain.Models.PurchasesDetails.AddPurchasesDetails addPurchasesDetails)
        {
            PurchasesDetails.AddPurchasesDetails(addPurchasesDetails);
        }

        [HttpPut]
        public void Put(Domain.Models.PurchasesDetails.UpdatePurchasesDetails updatePurchasesDetails,int id)
        {
            PurchasesDetails.UpdatePurchasesDetails(updatePurchasesDetails, id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            PurchasesDetails.DelPurchasesDetails(id);
        }
    }
}
