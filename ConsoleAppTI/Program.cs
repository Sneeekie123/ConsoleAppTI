using ConsoleAppTI.Contexts;
using ConsoleAppTI.Dtos;
using ConsoleAppTI.Repositories;
using ConsoleAppTI.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\ConsoleAppTI\ConsoleAppTI\Data\local_database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));

    services.AddScoped<ProductRepository>();
    services.AddScoped<CustomerRepository>();
    services.AddScoped<OrderRepository>();
    services.AddScoped<OrderRowRepository>();
    services.AddScoped<PriceRepository>();
    services.AddScoped<ProductService>();

}).Build();

builder.Start();

Console.Clear();


var productService = builder.Services.GetRequiredService<ProductService>();
var result = productService.CreateProduct(new Product
{
    ProductId = 3,
    ProductName = "Test3213",
    Price = "300",
    PriceId = 3,
    
});


if (result)
    Console.WriteLine("Lyckades!");
else
    Console.WriteLine("Något gick fel!");
Console.ReadKey();