﻿using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities;

public class CatalogBrand : BaseEntity, IAggregateRoot
{
    public CatalogBrand(string brand)
    {
        Brand = brand;
    }

    public string Brand { get; private set; }
}
