using CardGameWar;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<Card> Stack1 = new Stack<Card>();
        Stack<Card> Stack2 = new Stack<Card>();
        Suit randomSuit = RandomSuit();

        Console.WriteLine("Random suit: {0}", randomSuit);
        Console.WriteLine("");

        GameLauncher game = new GameLauncher("Player1", "Player2");

        game.PlayTurn(Stack1, Stack2, randomSuit);

        Console.WriteLine("Both players are out of cards. Game results:");
        if (Stack1.Count > Stack2.Count)
        {
            Console.WriteLine("First player wins with {0} point/s!", Stack1.Count);
        }
        if (Stack1.Count < Stack2.Count)
        {
            Console.WriteLine("Second player wins with {0} point/s!", Stack2.Count);
        }
        if (Stack1.Count == Stack2.Count)
        {
            Console.WriteLine("Tie!");
        }
    }
    static Suit RandomSuit()
    {
        var random = new Random();
        return (Suit)random.Next(Enum.GetNames(typeof(Suit)).Length);
    }
}