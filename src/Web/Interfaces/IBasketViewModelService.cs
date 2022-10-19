﻿using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;
using Microsoft.eShopWeb.Web.Pages.Basket;

namespace Microsoft.eShopWeb.Web.Interfaces;

public interface IBasketViewModelService
{
    Task<int> CountTotalBasketItems(string username);

    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);

    Task<BasketViewModel> Map(Basket basket);
}
