using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Sales
{
    public class SalesDetails :ISalesDetails
    {
        AppDbContext AppDbContext;
        public SalesDetails(AppDbContext appDbContext)
        {
            AppDbContext=appDbContext;
        }
        public void AddSalesDetails(Domain.Models.SalesDetails.AddSalesDetails addSalesDetails)
        {
            var SalesDetails = new Domain.SalesDetails()
            {
                SaleID = addSalesDetails.SaleID,
                ProdectID = addSalesDetails.ProdectID,
                Quantity = addSalesDetails.Quantity,
            };
            AppDbContext.salesDetails.Add(SalesDetails);
            AppDbContext.SaveChanges();
        }
        public void DelSalesDetails(int id)
        {
            var SalesDetails=AppDbContext.salesDetails.FirstOrDefault(i=>i.id==id);
            AppDbContext.salesDetails.Remove(SalesDetails);
            AppDbContext.SaveChanges();
        }
        public List<Domain.SalesDetails> GetSalesDetails()
        {
            return AppDbContext.salesDetails.ToList();
        }
        public void UpdateSalesDetails(Domain.Models.SalesDetails.UpdateSalesDetails updateSalesDetails,int id)
        {
            var SalesDetails=AppDbContext.salesDetails.FirstOrDefault(i=>i.id==id);
            SalesDetails.SaleID = updateSalesDetails.SaleID;
            SalesDetails.ProdectID = updateSalesDetails.ProdectID;
            SalesDetails.Quantity = updateSalesDetails.Quantity;
            AppDbContext.salesDetails.Update(SalesDetails);
            AppDbContext.SaveChanges();
        }
    }
}
