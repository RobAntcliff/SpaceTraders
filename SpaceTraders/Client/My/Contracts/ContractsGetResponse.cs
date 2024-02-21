// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using SpaceTraders.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.My.Contracts {
    public class ContractsGetResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SpaceTraders.Client.Models.Contract>? Data { get; set; }
#nullable restore
#else
        public List<SpaceTraders.Client.Models.Contract> Data { get; set; }
#endif
        /// <summary>Meta details for pagination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpaceTraders.Client.Models.Meta? Meta { get; set; }
#nullable restore
#else
        public SpaceTraders.Client.Models.Meta Meta { get; set; }
#endif
        /// <summary>
        /// Instantiates a new contractsGetResponse and sets the default values.
        /// </summary>
        public ContractsGetResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContractsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContractsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<SpaceTraders.Client.Models.Contract>(SpaceTraders.Client.Models.Contract.CreateFromDiscriminatorValue)?.ToList(); } },
                {"meta", n => { Meta = n.GetObjectValue<SpaceTraders.Client.Models.Meta>(SpaceTraders.Client.Models.Meta.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SpaceTraders.Client.Models.Contract>("data", Data);
            writer.WriteObjectValue<SpaceTraders.Client.Models.Meta>("meta", Meta);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
