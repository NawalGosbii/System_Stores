using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain
{
    public class PurchasesDetails
    {
        public int id {  get; set; }
        public int PurchaseID { get; set; }
        public Purchases Purchases { get; set; }
        public int ProdectID { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}
