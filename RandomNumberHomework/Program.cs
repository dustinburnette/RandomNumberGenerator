using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int winningNumber = random.Next(1, 101);
            int parsedGuess = 0;
            bool answer = false;
            int numberOfGuesses = 0;

           
        

            Console.WriteLine("I am thinking of a number between 1-100, can you guess it?");

            while (!answer)
            {

                string guess = Console.ReadLine();
               
                if (int.TryParse(guess, out parsedGuess))
                {

                   // if (parsedGuess)
                   //{                       
                   //     Console.WriteLine("Are you feeling well? You tried that."); 
                   // }

                    if (parsedGuess > winningNumber)
                    {
                        numberOfGuesses++;
                        Console.WriteLine("No the number I'm thinking of is lower than " + parsedGuess + " Try again.");
                    }
                    else if (parsedGuess < winningNumber)
                    {
                        numberOfGuesses++;
                        Console.WriteLine("No the number I'm thinking of is higher than " + parsedGuess + " Try again.");
                    }
                    if (numberOfGuesses > 4)
                    {
                        Console.WriteLine("Too many attempts, you lose.");
                        Environment.Exit(0);
                    }
                    
                    

                }
                else
                {
                    answer = true;
                    Console.WriteLine("You guessed it right!");


                    

                }

            }
               
            
           
         










            }
    }
}
