using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Interfaces;

public interface IBasketService
{
    Task<Basket> AddItemToBasket(string username, int catalogItemId, decimal price, int quantity = 1);

    Task DeleteBasketAsync(int basketId);

    Task<Result<Basket>> SetQuantities(int basketId, Dictionary<string, int> quantities);

    Task TransferBasketAsync(string anonymousId, string userName);
}
