﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Infrastructure.Identity;
using Microsoft.eShopWeb.Web.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace Microsoft.eShopWeb.Web.Areas.Identity.Pages.Account;

//TODO : replace IMemoryCache by distributed cache if you are in multi-host scenario
public class LogoutModel : PageModel
{
    private readonly IMemoryCache _cache;
    private readonly ILogger<LogoutModel> _logger;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger, IMemoryCache cache)
    {
        _signInManager = signInManager;
        _logger = logger;
        _cache = cache;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(string? returnUrl = null)
    {
        await _signInManager.SignOutAsync();
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        var userId = _signInManager.Context.User.Claims.First(c => c.Type == ClaimTypes.Name);
        var identityKey = _signInManager.Context.Request.Cookies[ConfigureCookieSettings.IdentifierCookieName];
        _cache.Set($"{userId.Value}:{identityKey}", identityKey, new MemoryCacheEntryOptions
        {
            AbsoluteExpiration = DateTime.Now.AddMinutes(ConfigureCookieSettings.ValidityMinutesPeriod)
        });

        _logger.LogInformation("User logged out.");
        return returnUrl != null ? LocalRedirect(returnUrl) : RedirectToPage("/Index");
    }
}
