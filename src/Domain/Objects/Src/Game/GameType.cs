﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Objects.Src.Game
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GameType
    {
        Undefined,
        Poker
    }
}
