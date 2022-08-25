using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Objects.Src.Player
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlayerType
    {
        Undefined,
        Human,
        Machine
    }
}
