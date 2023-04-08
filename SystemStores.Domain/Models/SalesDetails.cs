using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain.Models
{
    public class SalesDetails
    {
        public class AddSalesDetails
        {
            public int SaleID { get; set; }
            public int ProdectID { get; set; }
            public int Quantity { get; set; }
        }
        
        public class UpdateSalesDetails
        {
            public int SaleID { get; set;}
            public int ProdectID { get; set; }
            public int Quantity { get; set; }
        }
    }
}
