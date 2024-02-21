// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace SpaceTraders.Client.Models {
    /// <summary>The activity level of a trade good. If the good is an import, this represents how strong consumption is. If the good is an export, this represents how strong the production is for the good. When activity is strong, consumption or production is near maximum capacity. When activity is weak, consumption or production is near minimum capacity.</summary>
    public enum ActivityLevel {
        [EnumMember(Value = "WEAK")]
        WEAK,
        [EnumMember(Value = "GROWING")]
        GROWING,
        [EnumMember(Value = "STRONG")]
        STRONG,
        [EnumMember(Value = "RESTRICTED")]
        RESTRICTED,
    }
}
