namespace Microsoft.eShopWeb.Web.ViewModels;

public class OrderItemViewModel
{
    public decimal Discount => 0;
    public string? PictureUrl { get; set; }
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Units { get; set; }
}
