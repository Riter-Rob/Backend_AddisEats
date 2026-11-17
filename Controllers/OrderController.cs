using AddisEats.Api.DTOs;
using AddisEats.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private static readonly List<Order> Orders = new();

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var order = Orders.FirstOrDefault(o => o.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpPost]
    public IActionResult CreateOrder([FromBody] CreateOrderDTO dto)
    {
        var order = new Order
        {
            Id = Orders.Any() ? Orders.Max(o => o.Id) + 1 : 1,
            RestaurantId = dto.RestaurantId,
            MenuItemId = dto.MenuItemId,
            CustomerName = dto.CustomerName,
            DeliveryAddress = dto.DeliveryAddress,
            CustomerPhone = dto.CustomerPhone,
            Quantity = dto.Quantity,
            TotalAmount = dto.TotalAmount
        };

        Orders.Add(order);

        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
    }
}
