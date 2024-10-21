using Microsoft.EntityFrameworkCore;
using TripLogCleanServer.Domain.Entities;

namespace TripLogCleanServer.Infrastructure.Context;
public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    public DbSet<Trip> Trips { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<TripContent> TripContents { get; set; }
}
