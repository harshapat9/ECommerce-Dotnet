namespace ECommerce.Database;

public class SalesReport
{
    public int ID { get; set; }
    public int TotalSales { get; set; }
    public int TotalOrders { get; set; }
    public double AverageOrderValue { get; set; }
    public Dictionary<string, int>? ProductSalesRecord { get; set; } = new Dictionary<string, int>();
    public int CustomerCount { get; set; }
    public int NetProfit { get; set; }
    public string? PurchaseDate { get; set; }
}
