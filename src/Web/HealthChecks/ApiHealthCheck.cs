﻿using BlazorShared;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

namespace Microsoft.eShopWeb.Web.HealthChecks;

public class ApiHealthCheck : IHealthCheck
{
    private readonly BaseUrlConfiguration _baseUrlConfiguration;

    public ApiHealthCheck(IOptions<BaseUrlConfiguration> baseUrlConfiguration)
    {
        _baseUrlConfiguration = baseUrlConfiguration.Value;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        var myUrl = _baseUrlConfiguration.ApiBase + "catalog-items";
        var client = new HttpClient();
        var response = await client.GetAsync(myUrl);
        var pageContents = await response.Content.ReadAsStringAsync();
        return pageContents.Contains(".NET Bot Black Sweatshirt")
            ? HealthCheckResult.Healthy("The check indicates a healthy result.")
            : HealthCheckResult.Unhealthy("The check indicates an unhealthy result.");
    }
}
