using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Customer
{
    [JsonIgnore]
    public Cart? Cart { get; set; }
    public List<Order>? Orders { get; set; } = new List<Order>();
    public int CartID { get; set; }
    
}
