using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class AuditProperties
{
    public int ID { get; set; }
    [JsonIgnore]
    public Product? Product { get; set; }
    public int ProductID { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
