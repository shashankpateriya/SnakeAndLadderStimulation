using System;

namespace SnakeLadder
{
    public class SnakeAndLadder
    {
        public static void Main(string[] args)
        {
            int positionOfPlayer = 0;
            int rollDice = 0;
            Console.WriteLine("Welcome to the game of SNAKE AND LADDER");
            Console.WriteLine("Starting position of the player is at " + positionOfPlayer);
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice Number is " + rollDice);
        }
    }
}
