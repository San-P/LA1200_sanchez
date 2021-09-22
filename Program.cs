using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctguess = false;
            Random random = new Random ();

            int randomnumb = random.Next(1, 101);
            int attempts = 0;

            Console.WriteLine("Hello and welcome to my number guessing game.");
            Console.WriteLine("I thought of a random whole number between 1 and 100, guess which one it is!");
            Console.WriteLine("If you guess it right, you win :)");


            while (!correctguess)
            {
                attempts = attempts + 1;


                try
                {

                    Console.WriteLine(" ");
                    Console.Write("Enter your guess: ");
                    double guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > 100 || guess < 1)
                    {
                        throw new Exception();
                    }
                    else if (guess > randomnumb)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Haha your number is too big, try a smaller one.");
                    }
                    else if (guess < randomnumb)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Too small, try a bigger number.");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You guessed it, good job! It took you " + attempts + " tries.");
                        correctguess = true;
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please only enter whole numbers between 1-100.");
                }
            }
            if (attempts > 10)
            {
                Console.WriteLine("");
                Console.WriteLine("Damn, it took you more than 10 tries. Try watching the following Video.");
                Console.WriteLine("(Press Enter)");
                Console.Read();

                var prs = new ProcessStartInfo("microsoftedge.exe");
                prs.Arguments = "https://www.youtube.com/watch?v=sPRpVL58IKE";
                Process.Start(prs);
                Console.WriteLine("That was kinda mean haha sorry.");
                Console.Read();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Thanks for playing. See you soon.");
            Console.ReadKey();
            
        }
    }
}
