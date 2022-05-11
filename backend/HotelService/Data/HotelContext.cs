using HotelService.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelService.Data;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
    }

    public DbSet<Room> Rooms { get; set; }
}