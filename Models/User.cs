using System.Net;

namespace eCommerce.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Address ShippingAddress { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
