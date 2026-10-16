using System.ComponentModel.DataAnnotations;

namespace SugboBites.Models;

/// <summary>A Cebu dish guide entry. Restaurant facts are shown separately and linked to their source.</summary>
public sealed class FoodSpot
{
    public int Id { get; init; }

    [Required]
    public string Name { get; init; } = string.Empty;

    [Required]
    public string Dish { get; init; } = string.Empty;

    [Required]
    public string Category { get; init; } = string.Empty;

    [Required]
    public string Location { get; init; } = string.Empty;

    [Required]
    public string Description { get; init; } = string.Empty;

    [Required]
    public string Story { get; init; } = string.Empty;

    public string ImageUrl { get; init; } = string.Empty;
    public string ImageAlt { get; init; } = string.Empty;
    public string SourceName { get; init; } = string.Empty;
    public string SourceUrl { get; init; } = string.Empty;
}
