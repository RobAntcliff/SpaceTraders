// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using SpaceTraders.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.My.Ships.Item.Scan.Systems {
    public class SystemsPostResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A cooldown is a period of time in which a ship cannot perform certain actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpaceTraders.Client.Models.Cooldown? Cooldown { get; set; }
#nullable restore
#else
        public SpaceTraders.Client.Models.Cooldown Cooldown { get; set; }
#endif
        /// <summary>List of scanned systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScannedSystem>? Systems { get; set; }
#nullable restore
#else
        public List<ScannedSystem> Systems { get; set; }
#endif
        /// <summary>
        /// Instantiates a new systemsPostResponse_data and sets the default values.
        /// </summary>
        public SystemsPostResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SystemsPostResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SystemsPostResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cooldown", n => { Cooldown = n.GetObjectValue<SpaceTraders.Client.Models.Cooldown>(SpaceTraders.Client.Models.Cooldown.CreateFromDiscriminatorValue); } },
                {"systems", n => { Systems = n.GetCollectionOfObjectValues<ScannedSystem>(ScannedSystem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SpaceTraders.Client.Models.Cooldown>("cooldown", Cooldown);
            writer.WriteCollectionOfObjectValues<ScannedSystem>("systems", Systems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}