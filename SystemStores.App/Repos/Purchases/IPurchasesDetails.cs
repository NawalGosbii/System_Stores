using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.Domain;

namespace SystemStores.App.Repos.Purchases
{
    public interface IPurchasesDetails
    {
        List<Domain.PurchasesDetails> GetPurchasesDetails(); 
        public void AddPurchasesDetails(Domain.Models.PurchasesDetails.AddPurchasesDetails purchasesDetails);
        public void UpdatePurchasesDetails(Domain.Models.PurchasesDetails.UpdatePurchasesDetails updatePurchasesDetails,int id);
        public void DelPurchasesDetails(int id);
    }
}
