// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client.Models {
    /// <summary>
    /// Ship details.
    /// </summary>
    public class Ship : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Ship cargo details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipCargo? Cargo { get; set; }
#nullable restore
#else
        public ShipCargo Cargo { get; set; }
#endif
        /// <summary>A cooldown is a period of time in which a ship cannot perform certain actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpaceTraders.Client.Models.Cooldown? Cooldown { get; set; }
#nullable restore
#else
        public SpaceTraders.Client.Models.Cooldown Cooldown { get; set; }
#endif
        /// <summary>The ship&apos;s crew service and maintain the ship&apos;s systems and equipment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipCrew? Crew { get; set; }
#nullable restore
#else
        public ShipCrew Crew { get; set; }
#endif
        /// <summary>The engine determines how quickly a ship travels between waypoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipEngine? Engine { get; set; }
#nullable restore
#else
        public ShipEngine Engine { get; set; }
#endif
        /// <summary>The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipFrame? Frame { get; set; }
#nullable restore
#else
        public ShipFrame Frame { get; set; }
#endif
        /// <summary>Details of the ship&apos;s fuel tanks including how much fuel was consumed during the last transit or action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipFuel? Fuel { get; set; }
#nullable restore
#else
        public ShipFuel Fuel { get; set; }
#endif
        /// <summary>Modules installed in this ship.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShipModule>? Modules { get; set; }
#nullable restore
#else
        public List<ShipModule> Modules { get; set; }
#endif
        /// <summary>Mounts installed in this ship.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShipMount>? Mounts { get; set; }
#nullable restore
#else
        public List<ShipMount> Mounts { get; set; }
#endif
        /// <summary>The navigation information of the ship.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipNav? Nav { get; set; }
#nullable restore
#else
        public ShipNav Nav { get; set; }
#endif
        /// <summary>The reactor of the ship. The reactor is responsible for powering the ship&apos;s systems and weapons.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipReactor? Reactor { get; set; }
#nullable restore
#else
        public ShipReactor Reactor { get; set; }
#endif
        /// <summary>The public registration information of the ship</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShipRegistration? Registration { get; set; }
#nullable restore
#else
        public ShipRegistration Registration { get; set; }
#endif
        /// <summary>The globally unique identifier of the ship in the following format: `[AGENT_SYMBOL]-[HEX_ID]`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Symbol { get; set; }
#nullable restore
#else
        public string Symbol { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Ship and sets the default values.
        /// </summary>
        public Ship() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cargo", n => { Cargo = n.GetObjectValue<ShipCargo>(ShipCargo.CreateFromDiscriminatorValue); } },
                {"cooldown", n => { Cooldown = n.GetObjectValue<SpaceTraders.Client.Models.Cooldown>(SpaceTraders.Client.Models.Cooldown.CreateFromDiscriminatorValue); } },
                {"crew", n => { Crew = n.GetObjectValue<ShipCrew>(ShipCrew.CreateFromDiscriminatorValue); } },
                {"engine", n => { Engine = n.GetObjectValue<ShipEngine>(ShipEngine.CreateFromDiscriminatorValue); } },
                {"frame", n => { Frame = n.GetObjectValue<ShipFrame>(ShipFrame.CreateFromDiscriminatorValue); } },
                {"fuel", n => { Fuel = n.GetObjectValue<ShipFuel>(ShipFuel.CreateFromDiscriminatorValue); } },
                {"modules", n => { Modules = n.GetCollectionOfObjectValues<ShipModule>(ShipModule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mounts", n => { Mounts = n.GetCollectionOfObjectValues<ShipMount>(ShipMount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"nav", n => { Nav = n.GetObjectValue<ShipNav>(ShipNav.CreateFromDiscriminatorValue); } },
                {"reactor", n => { Reactor = n.GetObjectValue<ShipReactor>(ShipReactor.CreateFromDiscriminatorValue); } },
                {"registration", n => { Registration = n.GetObjectValue<ShipRegistration>(ShipRegistration.CreateFromDiscriminatorValue); } },
                {"symbol", n => { Symbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ShipCargo>("cargo", Cargo);
            writer.WriteObjectValue<SpaceTraders.Client.Models.Cooldown>("cooldown", Cooldown);
            writer.WriteObjectValue<ShipCrew>("crew", Crew);
            writer.WriteObjectValue<ShipEngine>("engine", Engine);
            writer.WriteObjectValue<ShipFrame>("frame", Frame);
            writer.WriteObjectValue<ShipFuel>("fuel", Fuel);
            writer.WriteCollectionOfObjectValues<ShipModule>("modules", Modules);
            writer.WriteCollectionOfObjectValues<ShipMount>("mounts", Mounts);
            writer.WriteObjectValue<ShipNav>("nav", Nav);
            writer.WriteObjectValue<ShipReactor>("reactor", Reactor);
            writer.WriteObjectValue<ShipRegistration>("registration", Registration);
            writer.WriteStringValue("symbol", Symbol);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
