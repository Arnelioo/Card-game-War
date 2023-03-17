using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    public enum Suit
    {
        Clubs, Diamonds, Hearts, Spades
    }
    public enum Value
    {
        Two = 2, Three = 3, Four = 4, Five = 5,
        Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11,
        Queen = 12, King = 13, Ace = 14
    };
    internal class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card()
        { }
        public Card(Value va, Suit su)
        {
            this.Suit = su;
            this.Value = va;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Value, Suit);
        }
    }
}
