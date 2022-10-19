using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.UnitTests.Builders;

public class AddressBuilder
{
    private Address _address;

    public AddressBuilder()
    {
        _address = WithDefaultValues();
    }

    public string TestCity => "Kent";
    public string TestCountry => "USA";
    public string TestState => "OH";
    public string TestStreet => "123 Main St.";
    public string TestZipCode => "44240";

    public Address Build()
    {
        return _address;
    }

    public Address WithDefaultValues()
    {
        _address = new Address(TestStreet, TestCity, TestState, TestCountry, TestZipCode);
        return _address;
    }
}
