using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServerCenter.Models
{
    public class Config
    {

        public static IEnumerable<ApiResource> GetResource()
        {
            return new List<ApiResource>
            {
                new ApiResource("api", "My API")
                {
                    Scopes = {"api", "My API"}
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = { "api" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
           {
                 new ApiScope("api", "My API")
            };
        }

    }
}
