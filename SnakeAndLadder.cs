using System;

namespace SnakeLadder
{
    public class SnakeAndLadder
    {
        public static void Main(string[] args)
        {
            int rollDice = 0;
            int[] SnakeArray = { 42, 85, 99 };
            int[] LadderArray = { 7, 35, 72 };
            Console.WriteLine("Welcome to the game of SNAKE AND LADDER");
            Console.WriteLine("Starting position of the player is at 0");
            for (int positionOfPlayer = 1; positionOfPlayer <= 100; positionOfPlayer++)
            {
                Random random = new Random();
                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice Number is " + rollDice);
                positionOfPlayer = positionOfPlayer + rollDice;
                positionOfPlayer = positionOfPlayer - 1;
                Console.WriteLine("Present Position =" + positionOfPlayer);
				if (positionOfPlayer == 100)
				{
					Console.WriteLine("You have won the GAME");
				}
				if (rollDice == 0)
				{
					positionOfPlayer = positionOfPlayer - rollDice;
					Console.WriteLine("Stay on same position");
				}
				if (positionOfPlayer == SnakeArray[0])
				{
					positionOfPlayer = 13;
					Console.WriteLine("It's a SNAKE");
					Console.WriteLine("Now, you are at " + positionOfPlayer);
				}
				else if (positionOfPlayer == SnakeArray[1])
				{
					positionOfPlayer = 58;
					Console.WriteLine("It's a SNAKE");
					Console.WriteLine("Now, you are at " + positionOfPlayer);
				}
				else if (positionOfPlayer == SnakeArray[2])
				{
					positionOfPlayer = 65;
					Console.WriteLine("It's a SNAKE");
					Console.WriteLine("Now, you are at " + positionOfPlayer);

				}
				else if (positionOfPlayer == LadderArray[0])
				{
					positionOfPlayer = 38;
					Console.WriteLine("You got a LADDER");
					Console.WriteLine("Now, you are at " + positionOfPlayer);
				}
				else if (positionOfPlayer == LadderArray[1])
				{
					positionOfPlayer = 64;
					Console.WriteLine("You got a LADDER");
					Console.WriteLine("Now, you are at " + positionOfPlayer);
				}
				else if (positionOfPlayer == LadderArray[2])
				{
					positionOfPlayer = 89;
					Console.WriteLine("You got a LADDER");
					Console.WriteLine("Now, you are at " + positionOfPlayer);
				}

			}
        }
    }
}
