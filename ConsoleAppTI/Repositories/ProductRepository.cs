using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class ProductRepository(DataContext context) : BaseRepository<ProductEntity>(context)
{
    private readonly DataContext _dataContext = context;
}
