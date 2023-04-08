using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.App.Repos.Sales
{
    public interface ISales
    {
        List<Domain.Sales> GetSales();
        public void AddSales(Domain.Models.Sales.AddSales addSales);
        public void UpdateSales(Domain.Models.Sales.UpdateSales updateSales,int id);
        public void DelSales(int  id);
    }
}
