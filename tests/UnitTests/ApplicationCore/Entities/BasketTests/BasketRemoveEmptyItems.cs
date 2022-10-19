using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Entities.BasketTests;

public class BasketRemoveEmptyItems
{
    private readonly string _buyerId = "Test buyerId";
    private readonly int _testCatalogItemId = 123;
    private readonly decimal _testUnitPrice = 1.23m;

    [Fact]
    public void RemovesEmptyBasketItems()
    {
        var basket = new Basket(_buyerId);
        basket.AddItem(_testCatalogItemId, _testUnitPrice, 0);
        basket.RemoveEmptyItems();

        Assert.Equal(0, basket.Items.Count);
    }
}
