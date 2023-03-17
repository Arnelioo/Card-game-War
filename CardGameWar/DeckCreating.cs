using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    internal class DeckCreating
    {
        public static Stack<Card> CreateCards()
        {
            Stack<Card> cardStack = new Stack<Card>();
            foreach (Value v in Enum.GetValues(typeof(Value)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    cardStack.Push(new Card((Value)v, (Suit)s));
                }
            }
            return ShuffleCards(cardStack);
        }

        public static Stack<Card> ShuffleCards(Stack<Card> cardStack)
        {
            List<Card> shuffledCards1 = cardStack.ToList();
            Random random = new Random();
            for (int i = shuffledCards1.Count - 1; i > 0; --i)
            {
                int j = random.Next(i + 1);
                Card temp = shuffledCards1[i];
                shuffledCards1[i] = shuffledCards1[j];
                shuffledCards1[j] = temp;
            }
            Stack<Card> shuffledCards2 = new Stack<Card>();
            foreach (var item in shuffledCards1)
            {
                shuffledCards2.Push(item);
            }
            return shuffledCards2;
        }
    }
}
