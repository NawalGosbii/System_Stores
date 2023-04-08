using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Purchases
{
    public class Purchases : IPurchases
    {
        AppDbContext AppDbContext;
        public Purchases(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            AppDbContext.Database.EnsureCreated();
        }
        public void AddPurchase(Domain.Models.Purchases.AddPurchases purchases)
        {
            var _purchases = new Domain.Purchases()
            {
                name = purchases.Name,
                Date = purchases.Date,
            };
            AppDbContext.purchases.Add(_purchases);
            AppDbContext.SaveChanges();
        }
        public void DelPurchases(int id)
        {
            var _Purchases= AppDbContext.purchases.FirstOrDefault(i=>i.id==id);
            AppDbContext.Remove(_Purchases);
            AppDbContext.SaveChanges();
        }
        public List<Domain.Purchases> GetAllPurchases()
        {
            return AppDbContext.purchases.ToList();
        }
        public void UpdatePurchases(Domain.Models.Purchases.UpdatePurchases purchases, int id)
        {
            var _purchases = AppDbContext.purchases.FirstOrDefault(i => i.id == id);
            _purchases.Date = purchases.Date;
            _purchases.name = purchases.Name;
           
            AppDbContext.purchases.Update(_purchases);
            AppDbContext.SaveChanges();
        }
    }
}
