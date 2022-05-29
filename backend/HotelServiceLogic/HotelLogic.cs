using HotelModels;
using HotelModels.Interfaces;

namespace HotelServiceLogic
{
    public class HotelLogic : IHotelLogic
    {
        private IHotelRepository _hotelRepository;
        
        public HotelLogic(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        
        public IEnumerable<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }
        
        public Hotel GetHotelById(int id)
        {
            return _hotelRepository.GetHotelById(id);
        }
        
        
        public void AddHotel(Hotel hotel)
        {
            _hotelRepository.AddHotel(hotel);
        }
        
        public void UpdateHotel(Hotel hotel)
        {
            _hotelRepository.UpdateHotel(hotel);
        }
        
        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }
        
        public IEnumerable<Room> GetAllRooms()
        {
            return _hotelRepository.GetAllRooms();
        }
        
        public Room GetRoomById(int id)
        {
            return _hotelRepository.GetRoomById(id);
        }
        
        public void AddRoom(Room room)
        {
            _hotelRepository.AddRoom(room);
        }
        
        public void UpdateRoom(Room room)
        {
            _hotelRepository.UpdateRoom(room);
        }
        
        public void DeleteRoom(int id)
        {
            _hotelRepository.DeleteRoom(id);
        }
    }
}