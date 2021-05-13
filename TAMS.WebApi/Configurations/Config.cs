using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace TAMS.WebApi.Configurations
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope> { new("TAMSApi.read") };

        public static IEnumerable<Client> Clients => new List<Client>
        {
            new()
            {
                ClientId = Startup.StaticConfiguration.GetValue<string>("TamsApiClientId"),
                ClientName = "Tams Client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> { new(Startup.StaticConfiguration.GetValue<string>("TamsApiSecret").Sha256()) },
                AllowedScopes = { "TAMSApi.read" }
            }
        };
    }
}
