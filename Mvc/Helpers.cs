using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace Mvc;

public static class Helpers
{
    // This thumbprint works on my machine<tm>. To get it running on your
    // machine, open certificate manager (mmc.exe, add certificates, current user)
    // and find a thumbprint of any of your personal certificates.
    public const string Thumbprint = "e612a25a9617aef04f3795380cf46425ef680451";

    public static void ConfigureIdentityServer(this OpenIdConnectOptions opt)
    {
        opt.Authority = "https://demo.duendesoftware.com";
        opt.ClientId = "interactive.confidential";
        opt.ClientSecret = "secret";
        opt.ResponseType = "code";

        opt.SaveTokens = true;

        opt.MapInboundClaims = false;
        opt.GetClaimsFromUserInfoEndpoint = true;

        opt.TokenValidationParameters.NameClaimType = "name";
        opt.TokenValidationParameters.RoleClaimType = "role";
    }
}
