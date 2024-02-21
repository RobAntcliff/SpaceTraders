// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace SpaceTraders.Client {
    public class GetResponse_leaderboards : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Top agents with the most credits.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GetResponse_leaderboards_mostCredits>? MostCredits { get; set; }
#nullable restore
#else
        public List<GetResponse_leaderboards_mostCredits> MostCredits { get; set; }
#endif
        /// <summary>Top agents with the most charted submitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GetResponse_leaderboards_mostSubmittedCharts>? MostSubmittedCharts { get; set; }
#nullable restore
#else
        public List<GetResponse_leaderboards_mostSubmittedCharts> MostSubmittedCharts { get; set; }
#endif
        /// <summary>
        /// Instantiates a new GetResponse_leaderboards and sets the default values.
        /// </summary>
        public GetResponse_leaderboards() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetResponse_leaderboards CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetResponse_leaderboards();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"mostCredits", n => { MostCredits = n.GetCollectionOfObjectValues<GetResponse_leaderboards_mostCredits>(GetResponse_leaderboards_mostCredits.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mostSubmittedCharts", n => { MostSubmittedCharts = n.GetCollectionOfObjectValues<GetResponse_leaderboards_mostSubmittedCharts>(GetResponse_leaderboards_mostSubmittedCharts.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GetResponse_leaderboards_mostCredits>("mostCredits", MostCredits);
            writer.WriteCollectionOfObjectValues<GetResponse_leaderboards_mostSubmittedCharts>("mostSubmittedCharts", MostSubmittedCharts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
