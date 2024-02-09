using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class OrderRowRepository(DataContext context) : BaseRepository<OrderRowEntity>(context)
{
    private readonly DataContext _dataContext = context;
}
