using Domain.Src.Cards;
using Objects.Src.Game;
using System;
using System.Collections.Generic;

namespace API.Src.View
{
    public class GameViewModel
    {
        public ulong Id { get; set; }

        public GameType Type { get; set; }

        public GameStatus Status { get; set; }

        public ICollection<PlayerViewModel> Players { get; set; }

        public ICollection<Card> Cards { get; set; }

        public double Bank { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}
