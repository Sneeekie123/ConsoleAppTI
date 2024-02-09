using ConsoleAppTI.Contexts;
using ConsoleAppTI.Entities;

namespace ConsoleAppTI.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<CustomerEntity>(context)
{
    private readonly DataContext _dataContext = context;
}
