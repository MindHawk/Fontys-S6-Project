namespace HotelModels.Interfaces
{
    public interface IHotelRepository
    {
        public IEnumerable<Hotel> GetAllHotels();
        public Hotel GetHotelById(int id);
        public void AddHotel(Hotel hotel);
        public void UpdateHotel(Hotel hotel);
        public void DeleteHotel(int id);
        
        public IEnumerable<Room> GetAllRooms();
        public Room GetRoomById(int id);
        public void AddRoom(Room room);
        public void UpdateRoom(Room room);
        public void DeleteRoom(int id);
    }
}