using AddisEats.Api.DTOs;
using AddisEats.Api.Services.MenuItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class MenuItemController : ControllerBase
{
    private readonly IMenuItemService _menuItemService;

    public MenuItemController(IMenuItemService menuItemService)
    {
        _menuItemService = menuItemService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MenuItemDTO>> GetAll([FromQuery] int? restaurantId)
    {
        if (restaurantId.HasValue)
        {
            return Ok(_menuItemService.GetByRestaurantId(restaurantId.Value));
        }
        return Ok(_menuItemService.GetAll());
    }

    [HttpGet("{id:int}")]
    public ActionResult<MenuItemDTO> GetById(int id)
    {
        var item = _menuItemService.GetById(id);
        if (item == null)
        {
            return NotFound(new { message = $"Menu item with ID {id} not found." });
        }
        return Ok(item);
    }

    [HttpPost]
    public ActionResult<MenuItemDTO> Create([FromBody] MenuItemDTO dto)
    {
        var created = _menuItemService.Add(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] MenuItemDTO dto)
    {
        var updated = _menuItemService.Update(id, dto);
        if (!updated)
        {
            return NotFound(new { message = $"Menu item with ID {id} not found." });
        }
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _menuItemService.Delete(id);
        if (!deleted)
        {
            return NotFound(new { message = $"Menu item with ID {id} not found." });
        }
        return NoContent();
    }
}

