using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Payment
{
    public int ID { get; set; }
    [JsonIgnore]
    public Order? Order { get; set; }
    public int OrderID { get; set; }
    public int TotalAmount { get; set; }
    public string? PurchaseDate { get; set; }
}
