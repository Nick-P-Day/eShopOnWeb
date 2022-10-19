namespace Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;

public class GetByIdCatalogItemRequest : BaseRequest
{
    public GetByIdCatalogItemRequest(int catalogItemId)
    {
        CatalogItemId = catalogItemId;
    }

    public int CatalogItemId { get; init; }
}
