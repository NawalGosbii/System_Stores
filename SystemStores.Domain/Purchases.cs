using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain
{
    public class Purchases
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string name { get; set; }

        public List<PurchasesDetails> purchasesDetails { get; set; }
    }
}
