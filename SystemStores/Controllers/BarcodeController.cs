using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using SystemStores.App.Repos.Barcode;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        IBarcode Barcode;
        public BarcodeController(IBarcode barcode)
        {
            Barcode = barcode;
        }
        [HttpGet]
        public List<Domain.Barcode> Get()
        {
            return Barcode.GetBarcodes();
        }
        [HttpPost]
        public void AddBarcod(Domain.Models.Barcode.AddBarcode barcode) 
        {
            Barcode.AddBarcode(barcode);
        }
        [HttpPut]
        public void UpdateBarcode(Domain.Models.Barcode.UpdateBarcode barcode,int id)
        {
            Barcode.UpdateBarcode(barcode,id);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            Barcode.DelBarcode(id);
        }
    }
}
