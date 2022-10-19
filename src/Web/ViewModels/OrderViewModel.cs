using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.Web.ViewModels;

public class OrderViewModel
{
    private const string DEFAULT_STATUS = "Pending";

    public DateTimeOffset OrderDate { get; set; }
    public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();
    public int OrderNumber { get; set; }
    public Address? ShippingAddress { get; set; }
    public string Status => DEFAULT_STATUS;
    public decimal Total { get; set; }
}
