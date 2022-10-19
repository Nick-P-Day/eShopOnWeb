﻿namespace Microsoft.eShopWeb.Web.Pages.Basket;

public class BasketViewModel
{
    public string? BuyerId { get; set; }
    public int Id { get; set; }
    public List<BasketItemViewModel> Items { get; set; } = new List<BasketItemViewModel>();

    public decimal Total()
    {
        return Math.Round(Items.Sum(x => x.UnitPrice * x.Quantity), 2);
    }
}
