using AddisEats.Api.DTOs;

namespace AddisEats.Api.Services.MenuItemServices;

public interface IMenuItemService
{
    IEnumerable<MenuItemDTO> GetAll();
    MenuItemDTO? GetById(int id);
    IEnumerable<MenuItemDTO> GetByRestaurantId(int restaurantId);
    MenuItemDTO Add(MenuItemDTO dto);
    bool Update(int id, MenuItemDTO dto);
    bool Delete(int id);
}

