namespace AddisEats.Api.DTOs;

public record MenuItemDTO
(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string Category,
    bool IsVegetarian,
    bool IsSpecial,
    string PrepTime,
    string? ImageUrl,
    int RestaurantId
);

