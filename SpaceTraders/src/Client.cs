using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SpaceTraders.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace SpaceTraders.src
{
    public class Client
    {
        public static SpaceTradersClient AnonymousClient()
        {
            var anonymousAuthProvider = new AnonymousAuthenticationProvider();
            // Create request adapter using the HttpClient-based implementation
            var adapter = new HttpClientRequestAdapter(anonymousAuthProvider);
            // Create the API client
            return new SpaceTradersClient(adapter);
        }

        public static SpaceTradersClient AuthenticatedClient()
        {
            string apiKey = File.ReadAllText(@"supersecretkey.txt");
            var apiKeyAuthProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
            var adapter = new HttpClientRequestAdapter(apiKeyAuthProvider);
            return new SpaceTradersClient(adapter);
        }
    }
}