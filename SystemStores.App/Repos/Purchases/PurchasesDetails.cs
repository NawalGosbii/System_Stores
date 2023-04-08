using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Purchases
{

    public class PurchasesDetails : IPurchasesDetails
    {
        AppDbContext AppDbContext;
        public PurchasesDetails(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            AppDbContext.Database.EnsureCreated();
        }
        public void AddPurchasesDetails(Domain.Models.PurchasesDetails.AddPurchasesDetails _purchasesDetails)
        {
            var purchasesDetails = new Domain.PurchasesDetails()
            {
                PurchaseID = _purchasesDetails.PurchaseID,
                ProdectID = _purchasesDetails.ProdectID,
                Quantity = _purchasesDetails.Quantity
            };
            AppDbContext.purchasesDetails.Add(purchasesDetails);
            AppDbContext.SaveChanges();
        }
        public void DelPurchasesDetails(int id)
        {
            var purchasesDetails = AppDbContext.purchasesDetails.FirstOrDefault(i => i.id == id);
            AppDbContext.purchasesDetails.Remove(purchasesDetails);
            AppDbContext.SaveChanges();
        }
        public List<Domain.PurchasesDetails> GetPurchasesDetails()
        {
            return AppDbContext.purchasesDetails.ToList();
        }
        public void UpdatePurchasesDetails(Domain.Models.PurchasesDetails.UpdatePurchasesDetails updatePurchasesDetails, int id)
        {
            var purchasesDetails = AppDbContext.purchasesDetails.FirstOrDefault(i => i.id == id);
            purchasesDetails.PurchaseID = updatePurchasesDetails.PurchaseID;
            purchasesDetails.ProdectID = updatePurchasesDetails.ProdectID;
            purchasesDetails.Quantity = updatePurchasesDetails.Quantity;
            AppDbContext.purchasesDetails.Update(purchasesDetails);
            AppDbContext.SaveChanges();
        }
    }
}
