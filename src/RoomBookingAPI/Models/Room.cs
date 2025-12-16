using RoomBookingAPI.src.RoomBookingAPI.Interfaces;

namespace RoomBookingAPI.src.RoomBookingAPI.Models
{
    public class Room : RoomInterface
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal PricePerNight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Beds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Toilets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HotelId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Hotel Hotel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Rooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ApartmentSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Room
        (
            int id = -1, string Name = "NULL", int capacity = 1, decimal pricePerNight = -1, int bads = -1,
            int toilets = -1, int hotelId = -1, Hotel hotel = null!, int rooms = -1, int apartmentSize = -1, string description = ""
            )
        {
            this.Id = id;    
            this.Name = Name;
            this.Capacity = capacity;
            this.PricePerNight = pricePerNight;
            this.Beds = bads;
            this.Toilets = toilets;
            this.HotelId = hotelId;
            this.Hotel = hotel;
            this.Rooms = rooms;
            this.ApartmentSize = apartmentSize;
            this.Description = description;
        }
    }
}
