using MediatR;
using Microsoft.eShopWeb.Web.ViewModels;

namespace Microsoft.eShopWeb.Web.Features.OrderDetails;

public class GetOrderDetails : IRequest<OrderViewModel>
{
    public GetOrderDetails(string userName, int orderId)
    {
        UserName = userName;
        OrderId = orderId;
    }

    public int OrderId { get; set; }
    public string UserName { get; set; }
}
