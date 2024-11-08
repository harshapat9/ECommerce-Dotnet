using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Cart
{
    public int ID { get; set; }

    [JsonIgnore]
    public Customer? Customer { get; set; }
    public int UserID { get; set; }
    public bool ProceedToOrder { get; set; }
    public int ProductID { get; set; }
    public List<Product>? Products { get; set; }
    public int Quantity { get; set; }
}
