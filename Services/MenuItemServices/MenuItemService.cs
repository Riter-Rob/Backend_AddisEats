using AddisEats.Api.Data;
using AddisEats.Api.DTOs;
using AddisEats.Api.Mappers;
using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{
    private readonly List<MenuItem> _menuItems = SeedData.MenuItems;

    public IEnumerable<MenuItemDTO> GetAll()
    {
        return _menuItems.Select(m => m.ToDTO());
    }

    public MenuItemDTO? GetById(int id)
    {
        var item = _menuItems.FirstOrDefault(m => m.Id == id);
        return item?.ToDTO();
    }

    public IEnumerable<MenuItemDTO> GetByRestaurantId(int restaurantId)
    {
        return _menuItems
            .Where(m => m.RestaurantId == restaurantId)
            .Select(m => m.ToDTO());
    }

    public MenuItemDTO Add(MenuItemDTO dto)
    {
        var item = dto.ToEntity();
        item.Id = _menuItems.Any() ? _menuItems.Max(m => m.Id) + 1 : 1;
        _menuItems.Add(item);
        return item.ToDTO();
    }

    public bool Update(int id, MenuItemDTO dto)
    {
        var existing = _menuItems.FirstOrDefault(m => m.Id == id);
        if (existing == null)
        {
            return false;
        }

        existing.Name = dto.Name;
        existing.Description = dto.Description;
        existing.Price = dto.Price;
        existing.Category = dto.Category;
        existing.IsVegetarian = dto.IsVegetarian;
        existing.IsSpecial = dto.IsSpecial;
        existing.PrepTime = dto.PrepTime;
        existing.ImageUrl = dto.ImageUrl;
        existing.RestaurantId = dto.RestaurantId;

        return true;
    }

    public bool Delete(int id)
    {
        var existing = _menuItems.FirstOrDefault(m => m.Id == id);
        if (existing == null)
        {
            return false;
        }

        _menuItems.Remove(existing);
        return true;
    }
}

