using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class SubCategory
{
    public int ID { get; set; }
    [JsonIgnore]
    public Category? Category { get; set; }
    public int CategoryID { get; set; }
    public string? Name { get; set; }
}
