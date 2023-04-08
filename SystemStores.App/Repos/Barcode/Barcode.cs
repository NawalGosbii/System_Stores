using SystemStores.infra.Data;

namespace SystemStores.App.Repos.Barcode
{
    public class Barcode : IBarcode
    {
        AppDbContext appDbContext;
        public Barcode(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
            appDbContext.Database.EnsureCreated();
        }
        public void AddBarcode(Domain.Models.Barcode.AddBarcode addBarcode)
        {
            var barcode = new Domain.Barcode()
            {
                barcode = addBarcode.Barcode,
                ProductID = addBarcode.ProductID,
            };
            appDbContext.barcode.Add(barcode);
            appDbContext.SaveChanges();
        }
        public void DelBarcode(int id)
        {
            var barcode = appDbContext.barcode.FirstOrDefault(i => i.Id == id);
            appDbContext.barcode.Remove(barcode);
            appDbContext.SaveChanges();
        }
        public List<Domain.Barcode> GetBarcodes()
        {
            return appDbContext.barcode.ToList();
        }
        public void UpdateBarcode(Domain.Models.Barcode.UpdateBarcode updateBarcode, int id)
        {
            var _barcode = appDbContext.barcode.FirstOrDefault(i => i.Id == id);
            _barcode.barcode = updateBarcode.Barcode;
            _barcode.ProductID = updateBarcode.ProductID;
            appDbContext.barcode.Update(_barcode);
            appDbContext.SaveChanges();
        }
    }
}
