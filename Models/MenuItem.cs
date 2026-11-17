namespace AddisEats.Api.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public bool IsVegetarian { get; set; }
    public bool IsSpecial { get; set; }
    public string PrepTime { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant? Restaurant { get; set; }
}

