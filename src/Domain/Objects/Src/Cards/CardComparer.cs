using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Src.Cards
{
    internal class CardComparer : IEqualityComparer<Card>
    {
        public bool Equals(Card x, Card y)
        {
            if (x == null || y == null) return false;

            return x.Value == y.Value && x.Suit == y.Suit;
        }

        public int GetHashCode([DisallowNull] Card obj)
        {
            ulong kind = (ulong)(int)obj.Value;
            return (int)(kind << 62 | (ulong)obj.Suit);
        }
    }
}
