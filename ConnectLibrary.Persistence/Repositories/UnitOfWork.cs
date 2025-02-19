using ConnectLibrary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConnectLibrary.Persistence.Repositories;

public class UnitOfWork(DbContext context) : IUnitOfWork
{
    private readonly DbContext _context = context;
    
    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}