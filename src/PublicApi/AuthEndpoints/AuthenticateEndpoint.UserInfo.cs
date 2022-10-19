using System.Collections.Generic;

namespace Microsoft.eShopWeb.PublicApi.AuthEndpoints;

public class UserInfo
{
    public static readonly UserInfo Anonymous = new UserInfo();
    public IEnumerable<ClaimValue> Claims { get; set; }
    public bool IsAuthenticated { get; set; }
    public string NameClaimType { get; set; }
    public string RoleClaimType { get; set; }
}
