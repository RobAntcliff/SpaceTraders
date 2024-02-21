// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.Models {
    /// <summary>
    /// The chart of a system or waypoint, which makes the location visible to other agents.
    /// </summary>
    public class Chart : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The agent that submitted the chart for this waypoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubmittedBy { get; set; }
#nullable restore
#else
        public string SubmittedBy { get; set; }
#endif
        /// <summary>The time the chart for this waypoint was submitted.</summary>
        public DateTimeOffset? SubmittedOn { get; set; }
        /// <summary>The symbol of the waypoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WaypointSymbol { get; set; }
#nullable restore
#else
        public string WaypointSymbol { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Chart and sets the default values.
        /// </summary>
        public Chart() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Chart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Chart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"submittedBy", n => { SubmittedBy = n.GetStringValue(); } },
                {"submittedOn", n => { SubmittedOn = n.GetDateTimeOffsetValue(); } },
                {"waypointSymbol", n => { WaypointSymbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("submittedBy", SubmittedBy);
            writer.WriteDateTimeOffsetValue("submittedOn", SubmittedOn);
            writer.WriteStringValue("waypointSymbol", WaypointSymbol);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}