using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    internal class Player
    {
        public string Name { get; set; }
        public Stack<Card> PlayerStack { get; set; }

        public Player()
        { }
        public Player(string name)
        {
            this.Name = name;
        }

        public (Stack<Card>, Stack<Card>) SplitStack(Stack<Card> cards)
        {
            Stack<Card> player1cards = new Stack<Card>();
            Stack<Card> player2cards = new Stack<Card>();
            int counter = 2;
            while (cards.Any())
            {
                if (counter % 2 == 0)
                {
                    player1cards.Push(cards.Pop());
                }
                else
                {
                    player2cards.Push(cards.Pop());
                }
                counter++;
            }
            return (player2cards, player1cards);
        }
    }
}
