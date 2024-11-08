using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Order
{
    public int ID { get; set; }
    [JsonIgnore]
    public UserInformation? UserInformation { get; set; }
    public int UserID { get; set; }
    [JsonIgnore]
    public Payment? Payment { get; set; }
}
