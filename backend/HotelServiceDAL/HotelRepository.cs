using HotelModels;
using HotelModels.Interfaces;
using HotelServiceDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace HotelServiceDAL
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _context;

        public HotelRepository(HotelContext context)
        {
            _context = context;
            context.Database.Migrate();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return _context.Hotels.FirstOrDefault(h => h.Id == id);
        }

        public void AddHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public void UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
        }

        public void DeleteHotel(int id)
        {
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
        }
        
        public IEnumerable<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
        
        public Room GetRoomById(int id)
        {
            return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }
        
        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }
        
        public void UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }
        
        public void DeleteRoom(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}