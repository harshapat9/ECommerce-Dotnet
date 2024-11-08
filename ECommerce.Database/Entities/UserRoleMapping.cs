using System.Text.Json.Serialization;

namespace ECommerce.Database;

public class UserRoleMapping
{
    public int ID { get; set; }
    [JsonIgnore]
    public Role? Role { get; set; }
    public int RoleID { get; set; }
}
