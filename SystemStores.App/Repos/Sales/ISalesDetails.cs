using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.App.Repos.Sales
{
    public interface ISalesDetails
    {
        List<Domain.SalesDetails>GetSalesDetails();
        public void AddSalesDetails(Domain.Models.SalesDetails.AddSalesDetails addSalesDetails);
        public void UpdateSalesDetails(Domain.Models.SalesDetails.UpdateSalesDetails updateSalesDetails,int id);
        public void DelSalesDetails(int id);
    }
}
