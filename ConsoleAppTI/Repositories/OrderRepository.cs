using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class OrderRepository(DataContext context) : BaseRepository<OrderEntity>(context)
{
    private readonly DataContext _dataContext = context;
}
