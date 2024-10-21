namespace TripLogCleanServer.Infrastructure.Repositories;
using TripLogCleanServer.Domain.Entities;
using TripLogCleanServer.Domain.Repositories;
using TripLogCleanServer.Infrastructure.Abstractions;
using TripLogCleanServer.Infrastructure.Context;

internal sealed class TripRepository(ApplicationDbContext context) : GenericRepository<Trip>(context), ITripRepository
{
}
