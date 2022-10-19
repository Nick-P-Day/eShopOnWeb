namespace Microsoft.eShopWeb.PublicApi.AuthEndpoints;

public class AuthenticateRequest : BaseRequest
{
    public string Password { get; set; }
    public string Username { get; set; }
}
