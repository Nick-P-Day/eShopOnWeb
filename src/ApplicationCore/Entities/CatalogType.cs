using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities;

public class CatalogType : BaseEntity, IAggregateRoot
{
    public CatalogType(string type)
    {
        Type = type;
    }

    public string Type { get; private set; }
}
