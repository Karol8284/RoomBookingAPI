using Microsoft.AspNetCore.Mvc;
using RoomBookingAPI.src.RoomBookingAPI.Infrastructure.Database.Enums;
using RoomBookingAPI.src.RoomBookingAPI.Models;

namespace RoomBookingAPI.src.RoomBookingAPI.Infrastructure.Database.Services
{
        [ApiController]
        [Route("api/[controller]")]
    public class DBServices : ControllerBase
    {
        private readonly RoomBookingDbContext _context;
        public DBServices(RoomBookingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Room> GetAllRooms()
        {
            //List<Room> roomsList = await _context.Room.ToListAsync();

        }
        public async Task<Room> GetRoomByMatch(RoomSearchType searchType, string value)
        {
            switch(searchType)
            {
                case RoomSearchType.Id:
                    {
                        int id = int.Parse(value);
                        Room room = await _context.Room.FindAsync(id);
                        return room;
                    }
            }


            //Room room = await _context.Room.FindAsync(id);
        }


    }
}
