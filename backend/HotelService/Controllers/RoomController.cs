using HotelServiceDAL.Context;
using HotelModels;
using HotelModels.Interfaces;
using HotelServiceLogic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelService.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("HotelPolicy")]
public class RoomController : ControllerBase
{
    private readonly ILogger<RoomController> _logger;
    private readonly IHotelLogic _hotelLogic;

    public RoomController(ILogger<RoomController> logger, IHotelLogic hotelLogic)
    {
        _logger = logger;
        _hotelLogic = hotelLogic;
    }

    [HttpPost(Name = "PostRoom")]
    public async Task<ActionResult<Room>> Post(Room room)
    {
        _hotelLogic.AddRoom(room);

        return Created("GetRoom", room);
    }

    [HttpGet(Name = "GetRooms")]
    public async Task<IEnumerable<Room>> Get()
    {
        return _hotelLogic.GetAllRooms();
    }
    
    [HttpDelete(Name = "DeleteRoom/{id:int}")]
    public async Task<ActionResult<Room>> Delete(int id)
    {
        Room room = _hotelLogic.GetRoomById(id);
        _hotelLogic.DeleteRoom(id);

        return room;
    }
}