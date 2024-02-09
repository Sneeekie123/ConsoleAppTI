using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class PriceRepository(DataContext context) : BaseRepository<PriceEntity>(context)
{
    private readonly DataContext _context = context;
}
