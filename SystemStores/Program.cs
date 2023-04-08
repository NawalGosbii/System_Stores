using SystemStores.App.Repos;
using SystemStores.App.Repos.Barcode;
using SystemStores.App.Repos.Customer;
using SystemStores.App.Repos.Product;
using SystemStores.App.Repos.Purchases;
using SystemStores.App.Repos.Sales;
using SystemStores.infra.Data;

namespace SystemStores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddScoped<IProduct, Product>();
            builder.Services.AddScoped<IPurchases,Purchases>();
            builder.Services.AddScoped<ICustomer, Customer>();
            builder.Services.AddScoped<ICategory, Category>();
            builder.Services.AddScoped<IBarcode, Barcode>();
            builder.Services.AddScoped<IPurchasesDetails,PurchasesDetails>();
            builder.Services.AddScoped<ISales,Sales>();
            builder.Services.AddScoped<ISalesDetails,SalesDetails>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}