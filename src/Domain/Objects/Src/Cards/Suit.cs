using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace Domain.Src.Cards
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Suit
    {
        Undefined,
        Diamond,
        Heart,
        Club,
        Spade
    }
}
