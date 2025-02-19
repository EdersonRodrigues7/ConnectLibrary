using ConnectLibrary.Domain.Entities;
using ConnectLibrary.Domain.Interfaces;
using ConnectLibrary.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ConnectLibrary.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context){}
    
    public async Task<User?> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }
}