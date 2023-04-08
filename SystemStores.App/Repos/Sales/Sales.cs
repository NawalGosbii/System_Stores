using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Sales
{

    public class Sales : ISales
    {
        AppDbContext AppDbContext;
        public Sales(AppDbContext appDbContext)
        {
            AppDbContext=appDbContext;
        }

        public void AddSales(Domain.Models.Sales.AddSales addSales)
        {
            var sales = new Domain.Sales()
            {
                Date = addSales.Date,
                CustomerID = addSales.CustomerID,
            };
            AppDbContext.sales.Add(sales);
            AppDbContext.SaveChanges();
        }

        public void DelSales(int id)
        {
            var sales =AppDbContext.sales.FirstOrDefault(i=>i.Id==id);
            AppDbContext.sales.Remove(sales);
            AppDbContext.SaveChanges();
        }

        public List<Domain.Sales> GetSales()
        {
            return AppDbContext.sales.ToList();
        }

        public void UpdateSales(Domain.Models.Sales.UpdateSales updateSales, int id)
        {
            var sales = AppDbContext.sales.FirstOrDefault(s => s.Id == id);
            sales.Date = updateSales.Date;
            sales.CustomerID = updateSales.CustomerID;
            AppDbContext.sales.Update(sales);
            AppDbContext.SaveChanges();
        }
    }
}
