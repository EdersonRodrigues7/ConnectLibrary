using ConnectLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConnectLibrary.Persistence.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}