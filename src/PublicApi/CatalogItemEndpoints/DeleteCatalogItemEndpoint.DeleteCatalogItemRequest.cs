namespace Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;

public class DeleteCatalogItemRequest : BaseRequest
{
    public DeleteCatalogItemRequest(int catalogItemId)
    {
        CatalogItemId = catalogItemId;
    }

    public int CatalogItemId { get; init; }
}
