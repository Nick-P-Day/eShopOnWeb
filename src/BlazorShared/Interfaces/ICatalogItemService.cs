using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Models;

namespace BlazorShared.Interfaces;

public interface ICatalogItemService
{
    Task<CatalogItem> Create(CreateCatalogItemRequest catalogItem);

    Task<string> Delete(int id);

    Task<CatalogItem> Edit(CatalogItem catalogItem);

    Task<CatalogItem> GetById(int id);

    Task<List<CatalogItem>> List();

    Task<List<CatalogItem>> ListPaged(int pageSize);
}
