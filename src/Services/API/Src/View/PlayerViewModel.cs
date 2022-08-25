using Objects.Src.Game;
using Objects.Src.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Src.View
{
    public class PlayerViewModel
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public PlayerType Type { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}
