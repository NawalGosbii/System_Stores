using Microsoft.EntityFrameworkCore;
using SystemStores.Domain;

namespace SystemStores.infra.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customer { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Barcode> barcode { get; set; }
        public DbSet<Purchases> purchases { get; set; }
        public DbSet<PurchasesDetails> purchasesDetails { get; set; }
        public DbSet<Sales> sales { get; set; }
        public DbSet<SalesDetails> salesDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=dbStores;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasKey(i => i.Id);
            modelBuilder.Entity<Barcode>().HasOne(i => i.Products).WithMany(i => i.barcodes).HasForeignKey(i => i.ProductID);
            modelBuilder.Entity<Products>().HasOne(i => i.Category).WithMany(i => i.Products).HasForeignKey(i => i.CategoryID);
            modelBuilder.Entity<PurchasesDetails>().HasOne(i => i.Purchases).WithMany(i => i.purchasesDetails).HasForeignKey(i => i.PurchaseID);
            modelBuilder.Entity<Products>().HasMany(i => i.purchasesDetails).WithOne(i => i.Products).HasForeignKey(i => i.ProdectID);
            modelBuilder.Entity<Customer>().HasMany(i => i.sales).WithOne(i => i.customer).HasForeignKey(i => i.CustomerID);
            modelBuilder.Entity<SalesDetails>().HasOne(i => i.sales).WithMany(i => i.salesDetails).HasForeignKey(i => i.SaleID);
            modelBuilder.Entity<Products>().HasMany(i => i.salesDetails).WithOne(i => i.Products).HasForeignKey(i => i.ProdectID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
