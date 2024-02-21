// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.Models {
    public class Shipyard : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fee to modify a ship at this shipyard. This includes installing or removing modules and mounts on a ship. In the case of mounts, the fee is a flat rate per mount. In the case of modules, the fee is per slot the module occupies.</summary>
        public int? ModificationsFee { get; set; }
        /// <summary>The ships that are currently available for purchase at the shipyard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShipyardShip>? Ships { get; set; }
#nullable restore
#else
        public List<ShipyardShip> Ships { get; set; }
#endif
        /// <summary>The list of ship types available for purchase at this shipyard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Shipyard_shipTypes>? ShipTypes { get; set; }
#nullable restore
#else
        public List<Shipyard_shipTypes> ShipTypes { get; set; }
#endif
        /// <summary>The symbol of the shipyard. The symbol is the same as the waypoint where the shipyard is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Symbol { get; set; }
#nullable restore
#else
        public string Symbol { get; set; }
#endif
        /// <summary>The list of recent transactions at this shipyard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShipyardTransaction>? Transactions { get; set; }
#nullable restore
#else
        public List<ShipyardTransaction> Transactions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Shipyard and sets the default values.
        /// </summary>
        public Shipyard() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Shipyard CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Shipyard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"modificationsFee", n => { ModificationsFee = n.GetIntValue(); } },
                {"shipTypes", n => { ShipTypes = n.GetCollectionOfObjectValues<Shipyard_shipTypes>(Shipyard_shipTypes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ships", n => { Ships = n.GetCollectionOfObjectValues<ShipyardShip>(ShipyardShip.CreateFromDiscriminatorValue)?.ToList(); } },
                {"symbol", n => { Symbol = n.GetStringValue(); } },
                {"transactions", n => { Transactions = n.GetCollectionOfObjectValues<ShipyardTransaction>(ShipyardTransaction.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("modificationsFee", ModificationsFee);
            writer.WriteCollectionOfObjectValues<ShipyardShip>("ships", Ships);
            writer.WriteCollectionOfObjectValues<Shipyard_shipTypes>("shipTypes", ShipTypes);
            writer.WriteStringValue("symbol", Symbol);
            writer.WriteCollectionOfObjectValues<ShipyardTransaction>("transactions", Transactions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
