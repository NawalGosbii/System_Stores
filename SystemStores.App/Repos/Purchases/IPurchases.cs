using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.App.Repos.Purchases
{
    public interface IPurchases
    {
        public void AddPurchase(Domain.Models.Purchases.AddPurchases purchases);
        public void UpdatePurchases(Domain.Models.Purchases.UpdatePurchases purchases,int id);
        public void DelPurchases(int id);
        List<Domain.Purchases> GetAllPurchases();
    }
}
