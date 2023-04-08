using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos.Purchases;

namespace SystemStores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchasesController :ControllerBase
    {
        IPurchases purchases;
        public PurchasesController(IPurchases _purchases)
        {
            purchases = _purchases;            
        }
        [HttpGet]
        public List<Domain.Purchases> Get() 
        { 
            return purchases.GetAllPurchases();
        }
        [HttpPost]
        public void AddPurchases(Domain.Models.Purchases.AddPurchases purchases)
        { 
            this.purchases.AddPurchase(purchases);
        }
        [HttpPut]
        public void UpdatePurchases(Domain.Models.Purchases.UpdatePurchases purchases, int id)
        {
            this.purchases.UpdatePurchases(purchases, id);
        }
        [HttpDelete]
        public void DeletePurchases(int id) 
        { 
            purchases.DelPurchases(id);
        }
    }
}
