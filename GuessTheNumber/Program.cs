using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //select range
            Console.WriteLine("Select range");
            Console.Write("From: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("To: ");
            int to = int.Parse(Console.ReadLine());

            //random num generator
            Random random = new Random();
            int randomNum = random.Next(from, to + 1);

            // execute method
            GuessNumber(randomNum);
            

        }
        private static void GuessNumber(int randomNum)
        {
            //guess the num
            byte lives = 5;
            int guess = 0;
            Console.Clear();
            while (guess != randomNum)
            {
                if (lives > 0)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Number of guesses: {lives} ");
                    Console.Write("Enter number: ");
                    guess = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("--------------------");

                    if (guess == randomNum)
                    {
                        Console.WriteLine($"Congratulations!\nYou guessed the number {randomNum}!");
                    }
                    else if (guess > randomNum - 5 && guess < randomNum + 5)
                    {
                        Console.WriteLine("State: Close!");
                    }
                    else if (guess > randomNum)
                    {
                        Console.WriteLine("State: Too high!");
                    }
                    else if (guess < randomNum)
                    {
                        Console.WriteLine("State: Too low!");
                    }

                    if (guess != randomNum)
                    {
                        lives--;
                    }
                }
                else
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"GAME OVER!\nYou didn't guess the number {randomNum}\n");
                    return;
                }
            }
        }
    }
}
