using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Seller
{
    public int ID { get; set; }
    [JsonIgnore]
    public UserInformation? UserInformation { get; set; }
    public int SellerID { get; set; }
    public List<Product>? Products { get; set; }
}
