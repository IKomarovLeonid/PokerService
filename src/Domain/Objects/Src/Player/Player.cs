using System;

namespace Objects.Src.Player
{
    internal class Player
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedTimeUtc { get; set; }

        public double MoneyStack { get; set; }
    }
}
