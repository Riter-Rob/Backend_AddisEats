using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.MenuItemServices;
using AddisEats.Api.Mappers;
using AddisEats.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;
    private readonly IMenuItemService _menuItemService;

    public RestaurantController(IRestaurantService restaurantService, IMenuItemService menuItemService)
    {
        _restaurantService = restaurantService;
        _menuItemService = menuItemService;
    }

    [HttpGet("{id}")]
    public IActionResult GetRestaurantById(int id)
    {
        var restaurant = _restaurantService.GetById(id);
        if (restaurant == null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }

    [HttpGet()]
    public IActionResult GetAllRestaurants([FromQuery] string? address, [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var restaurants = _restaurantService.GetAll(address, page, pageSize);
        var restaurantDTOs = restaurants.Select(r => r.ToDTO()).ToList();
        return Ok(restaurantDTOs);
    }

    [HttpGet("{id}/menu")]
    public IActionResult GetRestaurantMenu(int id)
    {
        var restaurant = _restaurantService.GetById(id);
        if (restaurant == null)
        {
            return NotFound(new { message = $"Restaurant with ID {id} not found." });
        }

        var menu = _menuItemService.GetByRestaurantId(id);
        return Ok(menu);
    }
}
