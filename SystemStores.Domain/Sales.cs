using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public Customer customer { get; set; }
        public List<SalesDetails> salesDetails { get; set; }
    }
}
