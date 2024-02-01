using ConsoleAppTI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTI.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{

    public virtual DbSet<CustomerEntity> Customers { get; set; }

    public virtual DbSet<OrderEntity> Orders { get; set; }

    public virtual DbSet<OrderRowEntity> OrderRows { get; set; }

    public virtual DbSet<PriceEntity> Prices { get; set; }


    public virtual DbSet<ProductEntity> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerEntity>()
            .HasIndex(x => x.CustomerEmail)
            .IsUnique();
    }
}
