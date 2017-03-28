using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberHomework
{
    class Program
    {
        //example method, first one//
        public static string promptUserNumber()
        {
            string example = "";
            Console.WriteLine("I am thinking of a number between 1-100, can you guess it?");
            return example;
            
        }
        //example method, first one//

        public static int UserGuess()
        {


                Random random = new Random();
                int winningNumber = random.Next(1, 101);
                int parsedGuess = 0;
                bool answer = true;
                int numberOfGuesses = 0;
                while (answer)
                {
                    string guess = Console.ReadLine();

                    if (int.TryParse(guess, out parsedGuess) && (parsedGuess > 0 && parsedGuess <= 100))
                    {
                        return parsedGuess;

                        if (parsedGuess > winningNumber)
                        {
                           
                            numberOfGuesses++;
                            Console.WriteLine("No the number I'm thinking of is lower than " + parsedGuess + " Try again.");
                        }
                        else if (parsedGuess < winningNumber)
                        {
                            return parsedGuess;
                            numberOfGuesses++;
                            Console.WriteLine("No the number I'm thinking of is higher than " + parsedGuess + " Try again.");
                        }
                        else if (parsedGuess == winningNumber)
                        {
                            return parsedGuess;
                            Console.WriteLine("You're correct, you win!");
                            Environment.Exit(0);
                        }
                        if (numberOfGuesses > 4)
                        {
                            return parsedGuess;
                            Console.WriteLine("Too many attempts, you lose.");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number");
                        return 0;
                    }
                }
            
        static void Main(string[] args)
        {
               
                promptUserNumber();

                int parsedGuess = UserGuess();
            

            }
        }
    }
}
