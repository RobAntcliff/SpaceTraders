// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using SpaceTraders.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.My.Ships.Item.Purchase {
    public class PurchasePostResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Agent details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpaceTraders.Client.Models.Agent? Agent { get; set; }
#nullable restore
#else
        public SpaceTraders.Client.Models.Agent Agent { get; set; }
#endif
        /// <summary>Ship cargo details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipCargo? Cargo { get; set; }
#nullable restore
#else
        public ShipCargo Cargo { get; set; }
#endif
        /// <summary>Result of a transaction with a market.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketTransaction? Transaction { get; set; }
#nullable restore
#else
        public MarketTransaction Transaction { get; set; }
#endif
        /// <summary>
        /// Instantiates a new purchasePostResponse_data and sets the default values.
        /// </summary>
        public PurchasePostResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PurchasePostResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PurchasePostResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"agent", n => { Agent = n.GetObjectValue<SpaceTraders.Client.Models.Agent>(SpaceTraders.Client.Models.Agent.CreateFromDiscriminatorValue); } },
                {"cargo", n => { Cargo = n.GetObjectValue<ShipCargo>(ShipCargo.CreateFromDiscriminatorValue); } },
                {"transaction", n => { Transaction = n.GetObjectValue<MarketTransaction>(MarketTransaction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SpaceTraders.Client.Models.Agent>("agent", Agent);
            writer.WriteObjectValue<ShipCargo>("cargo", Cargo);
            writer.WriteObjectValue<MarketTransaction>("transaction", Transaction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
