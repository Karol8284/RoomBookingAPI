using RoomBookingAPI.src.RoomBookingAPI.Enums;

namespace RoomBookingAPI.src.RoomBookingAPI.Interfaces
{
    public interface UserInterface
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }

        public UserRoleType Role { get; set; }
        //public string EmailConfirmed { get; set; }




    }
}
