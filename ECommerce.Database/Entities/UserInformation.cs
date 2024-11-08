using System.Text.Json.Serialization;
using ECommerce.Utilities;

namespace ECommerce.Database;

public class UserInformation
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; } = "email@pal.tech";
    public string? Password { get; set; } = "Password@123";
    [JsonIgnore]
    public Address? Address { get; set; } = new Address{ID = 1, City = "Hyderabad", Country = "India", DoorNumber = 123, LandMark = "Near TechM", PostalCode = 500017, Street = "Anjaiah Nagar" };
    public int AddressID { get; set; }
    public UserInformations RoleName { get; set; }
}
