namespace TripLogCleanServer.Domain.Entities;
public sealed class Trip
{
    public Trip()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public ICollection<Tag>? Tags { get; set; }
    public ICollection<TripContent>? TripContents { get; set; }
}


