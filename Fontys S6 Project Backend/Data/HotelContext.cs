using Fontys_S6_Project_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Fontys_S6_Project_Backend.Data;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
    }

    public DbSet<Room> Rooms { get; set; }
}