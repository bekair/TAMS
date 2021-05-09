using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace TAMS.WebApi.Configurations
{
    public static class IdentityConfig
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new(Startup.StaticConfiguration.GetValue<string>("TamsApiResourceName"), "Tennis Academy Management System Api")
                {
                     Scopes = { "TAMSApi.read" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new("TAMSApi.read")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new()
                {
                    ClientId = "client",
                    ClientName = "Tams Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> { new("secret".Sha256()) },
                    AllowedScopes = { "TAMSApi.read" }
                }
            };
        }
    }
}
