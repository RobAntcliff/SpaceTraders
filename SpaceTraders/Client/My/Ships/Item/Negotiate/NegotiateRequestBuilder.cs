// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using SpaceTraders.Client.My.Ships.Item.Negotiate.Contract;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace SpaceTraders.Client.My.Ships.Item.Negotiate {
    /// <summary>
    /// Builds and executes requests for operations under \my\ships\{shipSymbol}\negotiate
    /// </summary>
    public class NegotiateRequestBuilder : BaseRequestBuilder {
        /// <summary>The contract property</summary>
        public ContractRequestBuilder Contract { get =>
            new ContractRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new NegotiateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NegotiateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/my/ships/{shipSymbol}/negotiate", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new NegotiateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NegotiateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/my/ships/{shipSymbol}/negotiate", rawUrl) {
        }
    }
}
