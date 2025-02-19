using ConnectLibrary.Domain.Entities;

namespace ConnectLibrary.Domain.Interfaces;

public interface IUserRepository : IBaseRepository<User> 
{
    Task<User?> GetByEmail(string email, CancellationToken cancellationToken);
}