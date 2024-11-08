using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Address
{
    public int ID { get; set; }
    [JsonIgnore]
    public UserInformation? UserInformation { get; set; }
    public int UserInformationID { get; set; }
    public int DoorNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public int PostalCode { get; set; }
    public string? Country { get; set; }
    public string? LandMark { get; set; }

}
