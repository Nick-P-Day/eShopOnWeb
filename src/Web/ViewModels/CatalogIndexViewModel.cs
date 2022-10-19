using Microsoft.AspNetCore.Mvc.Rendering;

namespace Microsoft.eShopWeb.Web.ViewModels;

public class CatalogIndexViewModel
{
    public int? BrandFilterApplied { get; set; }
    public List<SelectListItem>? Brands { get; set; }
    public List<CatalogItemViewModel>? CatalogItems { get; set; }
    public PaginationInfoViewModel? PaginationInfo { get; set; }
    public List<SelectListItem>? Types { get; set; }
    public int? TypesFilterApplied { get; set; }
}
