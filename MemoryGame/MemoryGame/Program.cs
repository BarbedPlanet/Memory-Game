using System;
using System.Timers;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello player, Welcome to the number memory game");
            Console.WriteLine("Are you ready to play? <Press Enter>");
            Console.ReadLine();
            Console.Clear();
            //Introduction

            int number;
            int counter = 1;
            string input;
            int intInput;
            string numberSave = "";
            Random RNG = new Random();
            Timer myTimer = new Timer();



            while (true)
            {
                number = RNG.Next(1, 10);
                numberSave = numberSave + number.ToString();
                //Creates a random number and stores is in the variable named "number"

                Console.WriteLine("Stage " + counter + ": The next number to remember is - " + number);
                Console.WriteLine("<Press Enter>");
                myTimer.Interval = 2000;
                myTimer.Start();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What are the numbers to remember: ");
                myTimer.Interval = 2000;
                myTimer.Start();
                input = Console.ReadLine();

                // Shows the user the number to remember and asks what the previous numbers were

                intInput = Convert.ToInt32(input);
                number = Convert.ToInt32(numberSave);
                if (intInput == number)
                {
                    Console.WriteLine("Correct");
                    counter++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer was " + number);
                    Console.WriteLine("You got all the way to stage " + counter + ", the previous numbers were: " + numberSave);
                    Console.WriteLine("Play Again? <Press Enter>");
                    Console.ReadLine();
                    counter = 1;
                    numberSave = "";
                }
                Console.Clear();
                //Checks to make sure that the user has inputted the correct answer
                
                
            }
        }
    }
}
