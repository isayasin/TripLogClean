namespace TripLogCleanServer.Domain.Entities;

public sealed class Tag
{
    public Tag()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Trip>? Trips { get; set; }
}


