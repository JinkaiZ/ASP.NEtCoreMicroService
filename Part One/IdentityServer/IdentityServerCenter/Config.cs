using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4.Test;

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
                },
                 new Client()
                {
                    ClientId = "pwdClient",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
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

        public static List<TestUser> GetTestUser()
        {
            return new List<TestUser>
            {
                new TestUser()
                {
                    SubjectId = "1",
                    Username = "jinkai",
                    Password = "1234"


                }
            };
        }

    }
}
