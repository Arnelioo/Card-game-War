using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    internal class GameLauncher
    {
        Player player1;
        Player player2;

        public GameLauncher(string firstPlayer, string secondPlayer)
        {
            player1 = new Player(firstPlayer);
            player2 = new Player(secondPlayer);

            var wholeStack = DeckCreating.CreateCards();
            var playerDeck = player1.SplitStack(wholeStack);
            player1.PlayerStack = playerDeck.Item1;
            player2.PlayerStack = playerDeck.Item2;
        }
        public void PlayTurn(Stack<Card> Stack1, Stack<Card> Stack2, Suit randomSuit)
        {
            while (!IsItEnd())
            {
                var firstPlayerCard = player1.PlayerStack.Pop();
                var secondPlayerCard = player2.PlayerStack.Pop();
                Console.WriteLine(player1.Name + " plays with " + firstPlayerCard.ToString() + " and " +
                    player2.Name + " plays with " + secondPlayerCard.ToString());
                if (firstPlayerCard.Suit == randomSuit && secondPlayerCard.Suit != randomSuit)
                {
                    Stack1.Push(firstPlayerCard);
                    Stack1.Push(secondPlayerCard);
                    Console.WriteLine(player1.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (secondPlayerCard.Suit == randomSuit && firstPlayerCard.Suit != randomSuit)
                {
                    Stack2.Push(firstPlayerCard);
                    Stack2.Push(secondPlayerCard);
                    Console.WriteLine(player2.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (firstPlayerCard.Suit == randomSuit && secondPlayerCard.Suit == randomSuit && firstPlayerCard.Value > secondPlayerCard.Value)
                {
                    Stack1.Push(firstPlayerCard);
                    Stack1.Push(secondPlayerCard);
                    Console.WriteLine(player1.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (firstPlayerCard.Suit == randomSuit && secondPlayerCard.Suit == randomSuit && firstPlayerCard.Value < secondPlayerCard.Value)
                {
                    Stack2.Push(firstPlayerCard);
                    Stack2.Push(secondPlayerCard);
                    Console.WriteLine(player2.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (firstPlayerCard.Value > secondPlayerCard.Value && firstPlayerCard.Suit != randomSuit && secondPlayerCard.Suit != randomSuit)
                {
                    Stack1.Push(firstPlayerCard);
                    Stack1.Push(secondPlayerCard);
                    Console.WriteLine(player1.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (firstPlayerCard.Value < secondPlayerCard.Value && firstPlayerCard.Suit != randomSuit && secondPlayerCard.Suit != randomSuit)
                {
                    Stack2.Push(firstPlayerCard);
                    Stack2.Push(secondPlayerCard);
                    Console.WriteLine(player2.Name + " wins this turn!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
                if (firstPlayerCard.Value == secondPlayerCard.Value && firstPlayerCard.Suit != randomSuit && secondPlayerCard.Suit != randomSuit)
                {
                    Stack1.Push(firstPlayerCard);
                    Stack2.Push(secondPlayerCard);
                    Console.WriteLine("WAR!");
                    Console.WriteLine(player1.Name + " now has " + Stack1.Count + " point/s!");
                    Console.WriteLine(player2.Name + " now has " + Stack2.Count + " point/s!");
                    Console.WriteLine("");
                }
            }
        }

        public bool IsItEnd()
        {
            if (!player1.PlayerStack.Any() && !player2.PlayerStack.Any())
            {
                return true;
            }
            return false;
        }
    }
}
