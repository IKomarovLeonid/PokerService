using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Domain.Src.Cards
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardValue
    {
        Unknown,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Quenn,
        King,
        Ace
    }
}
