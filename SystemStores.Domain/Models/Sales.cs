using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.Domain.Models
{
    public class Sales
    {
        public class AddSales
        {
            public DateTime Date { get; set; }
            public int CustomerID { get; set; }
        }
      
        public class UpdateSales
        {
            public DateTime Date { get; set; }
            public int CustomerID { get; set; }
        }
    }
}
