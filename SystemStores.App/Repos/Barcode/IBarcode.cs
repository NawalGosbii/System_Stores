using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemStores.App.Repos.Barcode
{
    public interface IBarcode
    {
        List<Domain.Barcode> GetBarcodes();
        public void AddBarcode(Domain.Models.Barcode.AddBarcode addBarcode);
        public void UpdateBarcode(Domain.Models.Barcode.UpdateBarcode updateBarcode,int id);
        public void DelBarcode(int id);
    }
}
