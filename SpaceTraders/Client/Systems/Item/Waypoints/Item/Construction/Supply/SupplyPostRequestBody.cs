// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.Systems.Item.Waypoints.Item.Construction.Supply {
    public class SupplyPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Symbol of the ship to use.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipSymbol { get; set; }
#nullable restore
#else
        public string ShipSymbol { get; set; }
#endif
        /// <summary>The symbol of the good to supply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TradeSymbol { get; set; }
#nullable restore
#else
        public string TradeSymbol { get; set; }
#endif
        /// <summary>Amount of units to supply.</summary>
        public int? Units { get; set; }
        /// <summary>
        /// Instantiates a new supplyPostRequestBody and sets the default values.
        /// </summary>
        public SupplyPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SupplyPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SupplyPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"shipSymbol", n => { ShipSymbol = n.GetStringValue(); } },
                {"tradeSymbol", n => { TradeSymbol = n.GetStringValue(); } },
                {"units", n => { Units = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("shipSymbol", ShipSymbol);
            writer.WriteStringValue("tradeSymbol", TradeSymbol);
            writer.WriteIntValue("units", Units);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}