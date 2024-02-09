using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class PriceRepository(DataContext dataContext) : BaseRepository<PriceEntity>(dataContext)
{
    private readonly DataContext _dataContext = dataContext;
}
