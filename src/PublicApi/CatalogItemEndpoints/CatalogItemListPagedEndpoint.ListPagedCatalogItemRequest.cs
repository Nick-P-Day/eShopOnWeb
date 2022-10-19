namespace Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;

public class ListPagedCatalogItemRequest : BaseRequest
{
    public ListPagedCatalogItemRequest(int? pageSize, int? pageIndex, int? catalogBrandId, int? catalogTypeId)
    {
        PageSize = pageSize ?? 0;
        PageIndex = pageIndex ?? 0;
        CatalogBrandId = catalogBrandId;
        CatalogTypeId = catalogTypeId;
    }

    public int? CatalogBrandId { get; init; }
    public int? CatalogTypeId { get; init; }
    public int? PageIndex { get; init; }
    public int? PageSize { get; init; }
}
