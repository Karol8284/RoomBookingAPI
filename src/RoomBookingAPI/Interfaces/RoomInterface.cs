using RoomBookingAPI.src.RoomBookingAPI.Models;

namespace RoomBookingAPI.src.RoomBookingAPI.Interfaces
{
    public interface RoomInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public int Bed { get; set; }
        public int Toilets { get; set; }

        //public bool IsAvailable { get; set; } // is Avaliable for easer access
        // hotel data
        public int HotelId { get; set; } 
        public Hotel Hotel { get; set; }
    }
}
