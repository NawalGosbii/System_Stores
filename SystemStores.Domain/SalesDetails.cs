using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain
{
    public class SalesDetails
    {
        public int id { get; set; }
        public int SaleID { get; set; }
        public Sales sales { get; set; }
        public int ProdectID { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}
