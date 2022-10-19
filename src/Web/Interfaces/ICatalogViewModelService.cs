using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.eShopWeb.Web.ViewModels;

namespace Microsoft.eShopWeb.Web.Services;

public interface ICatalogViewModelService
{
    Task<IEnumerable<SelectListItem>> GetBrands();

    Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId);

    Task<IEnumerable<SelectListItem>> GetTypes();
}
