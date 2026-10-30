namespace SugboBites.Models;

/// <summary>A Cebu dish and its background, image, and further-reading source.</summary>
public sealed class Dish
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Category { get; init; }
    public required string Location { get; init; }
    public required string Description { get; init; }
    public required string Story { get; init; }
    public required string ImageUrl { get; init; }
    public required string ImageAlt { get; init; }
    public required string SourceName { get; init; }
    public required string SourceUrl { get; init; }
}
