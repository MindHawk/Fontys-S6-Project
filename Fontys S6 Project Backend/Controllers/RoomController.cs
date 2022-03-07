using Fontys_S6_Project_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fontys_S6_Project_Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class RoomController : ControllerBase
{
    private readonly ILogger<RoomController> _logger;

    public RoomController(ILogger<RoomController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetRooms")]
    public IEnumerable<Room> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Room
            {
                RoomID = index,
                RoomSize = Random.Shared.Next(1, 5),
            })
            .ToArray();
    }
}