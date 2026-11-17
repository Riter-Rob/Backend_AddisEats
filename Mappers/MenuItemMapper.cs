using AddisEats.Api.DTOs;
using AddisEats.Api.Models;

namespace AddisEats.Api.Mappers;

public static class MenuItemMapper
{
    public static MenuItemDTO ToDTO(this MenuItem item)
    {
        return new MenuItemDTO(
            item.Id,
            item.Name,
            item.Description,
            item.Price,
            item.Category,
            item.IsVegetarian,
            item.IsSpecial,
            item.PrepTime,
            item.ImageUrl,
            item.RestaurantId
        );
    }

    public static MenuItem ToEntity(this MenuItemDTO dto)
    {
        return new MenuItem
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            Category = dto.Category,
            IsVegetarian = dto.IsVegetarian,
            IsSpecial = dto.IsSpecial,
            PrepTime = dto.PrepTime,
            ImageUrl = dto.ImageUrl,
            RestaurantId = dto.RestaurantId
        };
    }
}

