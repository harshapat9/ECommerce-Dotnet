using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Review
{
    public int ID { get; set; }
    public int ProductID { get; set; }
    public int Rating { get; set; }
    public string? UserName { get; set; }
    [JsonIgnore]
    public Product? Product { get; set; }
    public string? Comment { get; set; }
}
