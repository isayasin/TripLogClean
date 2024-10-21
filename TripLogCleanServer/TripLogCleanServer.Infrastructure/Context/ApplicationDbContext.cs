using Microsoft.EntityFrameworkCore;
using TripLogCleanServer.Domain.Entities;

namespace TripLogCleanServer.Infrastructure.Context;
public sealed class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<TripContent> TripContents { get; set; }
}
