using TripLogCleanServer.Domain.Entities;
using TripLogCleanServer.Domain.Repositories;
using TripLogCleanServer.Infrastructure.Abstractions;
using TripLogCleanServer.Infrastructure.Context;

namespace TripLogCleanServer.Infrastructure.Repositories;
internal sealed class TagRepository(ApplicationDbContext context) : GenericRepository<Tag>(context), ITagRepository
{
}
