﻿namespace Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;

public class CatalogItemDto
{
    public int CatalogBrandId { get; set; }
    public int CatalogTypeId { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string PictureUri { get; set; }
    public decimal Price { get; set; }
}
