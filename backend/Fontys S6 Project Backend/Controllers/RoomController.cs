using Fontys_S6_Project_Backend.Data;
using Fontys_S6_Project_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fontys_S6_Project_Backend.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("HotelPolicy")]
public class RoomController : ControllerBase
{
    private readonly ILogger<RoomController> _logger;
    private readonly HotelContext _context;

    public RoomController(ILogger<RoomController> logger, HotelContext context)
    {
        _logger = logger;
        _context = context;
        context.Database.Migrate();
    }
    
    [HttpPost(Name = "PostRoom")]
    public async Task<ActionResult<Room>> Post(Room room)
    {
        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return Created("GetRoom", room);
    }

    [HttpGet(Name = "GetRooms")]
    public async Task<IEnumerable<Room>> Get()
    {
        return await _context.Rooms.ToListAsync();
    }
    
    [HttpDelete(Name = "DeleteRoom/{id:int}")]
    public async Task<ActionResult<Room>> Delete(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null)
        {
            return NotFound();
        }

        _context.Rooms.Remove(room);
        await _context.SaveChangesAsync();

        return room;
    }
}