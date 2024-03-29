// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.Models {
    /// <summary>
    /// The reactor of the ship. The reactor is responsible for powering the ship&apos;s systems and weapons.
    /// </summary>
    public class ShipReactor : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new.</summary>
        public int? Condition { get; set; }
        /// <summary>Description of the reactor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the reactor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The amount of power provided by this reactor. The more power a reactor provides to the ship, the lower the cooldown it gets when using a module or mount that taxes the ship&apos;s power.</summary>
        public int? PowerOutput { get; set; }
        /// <summary>The requirements for installation on a ship</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipRequirements? Requirements { get; set; }
#nullable restore
#else
        public ShipRequirements Requirements { get; set; }
#endif
        /// <summary>Symbol of the reactor.</summary>
        public ShipReactor_symbol? Symbol { get; set; }
        /// <summary>
        /// Instantiates a new ShipReactor and sets the default values.
        /// </summary>
        public ShipReactor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ShipReactor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShipReactor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"condition", n => { Condition = n.GetIntValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"powerOutput", n => { PowerOutput = n.GetIntValue(); } },
                {"requirements", n => { Requirements = n.GetObjectValue<ShipRequirements>(ShipRequirements.CreateFromDiscriminatorValue); } },
                {"symbol", n => { Symbol = n.GetEnumValue<ShipReactor_symbol>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("condition", Condition);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("powerOutput", PowerOutput);
            writer.WriteObjectValue<ShipRequirements>("requirements", Requirements);
            writer.WriteEnumValue<ShipReactor_symbol>("symbol", Symbol);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
