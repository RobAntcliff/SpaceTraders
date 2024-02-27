using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceTraders.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Abstractions;

namespace SpaceTraders.src
{
    public sealed class AuthenticationClient : SpaceTradersClient
    {
        private static readonly object _lock = new object();
        private static DateTime _expiry = DateTime.MinValue;
        private static readonly Task<AuthenticationClient> _getAuthenticationClientTask = CreateAuthenticationClient();
        private AuthenticationClient(IRequestAdapter requestAdapter) : base(requestAdapter) { }
        private static AuthenticationClient client;
        public static Task<AuthenticationClient> Client { get { return _getAuthenticationClientTask; } }
        private static async Task<AuthenticationClient> CreateAuthenticationClient()
        {
            if (HasExpired)
            {
                client = null;
            }

            if (client == null)
            {
                string apiKey = File.ReadAllText(@"supersecretkey.txt");
                var apiKeyAuthProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
                var adapter = new HttpClientRequestAdapter(apiKeyAuthProvider);
                client = new AuthenticationClient(adapter);

                var status = await client.GetAsGetResponseAsync();
                string resetDateString = status.ServerResets.Next;
                DateTime resetDate = DateTime.Parse(resetDateString);

                // Set the expiry date to be date of the next reset
                _expiry = resetDate;
            }
            return client;
        }
        public static bool HasExpired
        {
            get
            {
                lock (_lock) { return _expiry < DateTime.Now; }
            }
        }
    }
}