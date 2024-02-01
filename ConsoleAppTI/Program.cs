using ConsoleAppTI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder();

builder.ConfigureServices(services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Projects\\ConsoleAppTI\\ConsoleAppTI\\Data\\local_database.mdf;Integrated Security=True;Connect Timeout=30"));

});

builder.Build();
