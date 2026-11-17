using AddisEats.Api.DTOs;
using AddisEats.Api.Models;

namespace AddisEats.Api.Mappers;

public static class RestaurantMapper
{
    public static RestaurantDTO ToDTO(this Restaurant restaurant)
    {
        return new RestaurantDTO(
            restaurant.Id,
            restaurant.Name,
            restaurant.Address,
            restaurant.Phone,
            restaurant.IsActive
        );
    }

    public static Restaurant ToEntity(this RestaurantDTO dto)
    {
        return new Restaurant
        {
            Id = dto.Id,
            Name = dto.Name,
            Address = dto.Address,
            Phone = dto.Phone,
            IsActive = dto.IsActive
        };
    }
}

