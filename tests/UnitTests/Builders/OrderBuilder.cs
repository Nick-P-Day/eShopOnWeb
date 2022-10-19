using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.UnitTests.Builders;

public class OrderBuilder
{
    public decimal TestUnitPrice = 1.23m;
    public int TestUnits = 3;
    private Order _order;

    public OrderBuilder()
    {
        TestCatalogItemOrdered = new CatalogItemOrdered(TestCatalogItemId, TestProductName, TestPictureUri);
        _order = WithDefaultValues();
    }

    public string TestBuyerId => "12345";
    public int TestCatalogItemId => 234;
    public CatalogItemOrdered TestCatalogItemOrdered { get; }
    public string TestPictureUri => "http://test.com/image.jpg";
    public string TestProductName => "Test Product Name";

    public Order Build()
    {
        return _order;
    }

    public Order WithDefaultValues()
    {
        var orderItem = new OrderItem(TestCatalogItemOrdered, TestUnitPrice, TestUnits);
        var itemList = new List<OrderItem>() { orderItem };
        _order = new Order(TestBuyerId, new AddressBuilder().WithDefaultValues(), itemList);
        return _order;
    }

    public Order WithItems(List<OrderItem> items)
    {
        _order = new Order(TestBuyerId, new AddressBuilder().WithDefaultValues(), items);
        return _order;
    }

    public Order WithNoItems()
    {
        _order = new Order(TestBuyerId, new AddressBuilder().WithDefaultValues(), new List<OrderItem>());
        return _order;
    }
}
