using HotelModels;
using Microsoft.EntityFrameworkCore;

namespace HotelServiceDAL.Context;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
    }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
}