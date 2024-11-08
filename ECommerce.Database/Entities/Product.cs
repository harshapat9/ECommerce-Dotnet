using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class Product
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Subcategory { get; set; }
    public string? Brand { get; set; }
    public string? Color { get; set; }
    public int Quantity { get; set; }
    public int CostPrice { get; set; }
    public int SellingPrice { get; set; }
    public List<Review>? Reviews { get; set; } = new List<Review>();

    [JsonIgnore]
    public UserInformation? UserInformation { get; set; }
    public int UserID { get; set; }    
    public bool IsActive { get; set; }

}
