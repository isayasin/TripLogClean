namespace TripLogCleanServer.Domain.Entities;

public sealed class TripContent
{
    public TripContent()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PhotoUrl { get; set; } = string.Empty;

    public string TripId { get; set; } = string.Empty;
    public Trip? Trip { get; set; }
}


