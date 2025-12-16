using Microsoft.EntityFrameworkCore;

namespace RoomBookingAPI.src.RoomBookingAPI.Infrastructure.Database.Services
{
    public class RoomBookingDbContext : DbContext
    {
        public RoomBookingDbContext(DbContextOptions<RoomBookingDbContext> options) : base(options)
        {

        }



    }
}
