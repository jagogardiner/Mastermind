using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mastermind
// Generate a random four digit number. 
// The player has to keep inputting four digit numbers until they guess the randomly generated number.
// After each unsuccessful try it should say how many numbers they got correct, but not which position they got right.
// At the end of the game should congratulate the user and say how many tries it took.
namespace Mastermind
{
    class Program
    {
        public void menu()
        {
            // The main menu for the start of the game.
            Console.Clear();
            Console.WriteLine("Hi! Welcome to Mastermind.");
            Console.WriteLine("Please choose a difficulty:\n1. Easy\n2. Normal\n3. Hard");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case ("1"):
                case ("1."):
                case ("easy"):
                case ("Easy"):
                case ("1. easy"):
                case ("1. Easy"):
                    easy();
                    break;

                case ("2"):
                case ("2."):
                case ("normal"):
                case ("Normal"):
                case ("2. normal"):
                case ("2. Normal"):
                    
                    break;
            }
        }
        public void easy()
        {
            // The easy mode for the game!
            Console.Clear();
            int[] answer = generate4Digit(); // Generate a 4 digit number.
            int correct = 0;
            int tries = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                correct += answer[i] * Convert.ToInt32(Math.Pow(10, answer.Length - i - 1));
            }
            Console.WriteLine("Game started! (Easy mode)");
            Console.WriteLine(correct);
            Console.WriteLine("Your guess:");
            int response = Convert.ToInt32(Console.ReadLine());
            var digits = response.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            if (response == correct)
            {
                Console.WriteLine("Well done! You guessed the number!");
                Console.WriteLine("Proceeding to leaderboards...");
                System.Threading.Thread.Sleep(3000);
                leaderboards();
            }
            else if (response != correct)
            {
                if(digits[0] == answer[0])
                {
                    Console.WriteLine("The first number, "+answer[0]+", is correct and at the right location!");
                }
                else if (digits[1] == answer[0])
                {
                    Console.WriteLine("The first number, "+answer[0], "is correct but not at the right location!");
                }
                else if (digits[2] == answer[0])
                {
                    Console.WriteLine("The first number, " + answer[0], "is correct but not at the right location!");
                }
                else if (digits[3] == answer[0])
                {
                    Console.WriteLine("The first number, " + answer[0], "is correct but not at the right location!");
                }
            }
            Console.ReadKey();
        }
        public void leaderboards()
        {
            // Displays the leaderboards and lets you enter your own score 
            Console.Clear();
            Console.WriteLine("In progress.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public static int[] generate4Digit()
        {
            // Method to generate a random 4 digit number at any time, as a 4 slot array.
            int[] generated = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                generated[i] = rnd.Next(1, 9);
            }
            return generated;
        }
        public static int[] generate5Digit()
        {
            // Method to generate a random 5 digit number at any time, as a 5 slot array.
            int[] generated = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                generated[i] = rnd.Next(1, 9);
            }
            return generated;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.easy();
        }
    }
}
