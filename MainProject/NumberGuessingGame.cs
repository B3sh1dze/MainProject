using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class NumberGuessingGame
    {
        private const string ACCOUNTS_HISTORY_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\AccountHistory.txt";
        void Game(int range, int guesses, string userName)
        {
            Console.WriteLine($"You have {guesses} guesses");
            Console.WriteLine("Good luck!!!");
            Random randNum = new Random();
            int computersChoice = randNum.Next(range);
            for (int i = 1; i <= guesses; i++)
            {
                Console.WriteLine($" {i}) Enter the number: ");
                int playerInput = Convert.ToInt32(Console.ReadLine());
                if (playerInput == computersChoice)
                {
                    Console.WriteLine("congratulations! You win.");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Number Guessing Game against computer at " + DateTime.Now + Environment.NewLine);
                    break;
                }
                else if (playerInput > computersChoice)
                {
                    Console.WriteLine("generated number is smaller.");
                    Console.WriteLine();
                }
                else if (playerInput < computersChoice)
                {
                    Console.WriteLine("generated number is higher.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("wrong answer. try again.");
                }
            }

            Console.WriteLine($"generated number was: {computersChoice}");
        }

        void menu()
        {
            Console.WriteLine("                       _______________________________________________");
            Console.WriteLine("                                   NUMBER GUESSING GAME               ");
            Console.WriteLine("                           please select the difficulty level!");
            Console.WriteLine("1. easy  -- in this level you have to guess numbers between 0 to 30, in 10 guesses");
            Console.WriteLine("2. medium -- in this level you have to guess numbers between 0 to 50, in 7 guesses");
            Console.WriteLine("3. hard -- in this level you have to guess numbers between 0 to 70, in 6 guesses");
            Console.WriteLine("4. impossible -- in this level you have to guess numbers between 0 to 100, in 3 guesses");
            Console.WriteLine("5. if u want to exit press '5'.");
        }
        public NumberGuessingGame(string userName)
        {
            menu();
            int playerInput = Convert.ToInt32(Console.ReadLine());
            if (playerInput == 1)
            {
                Game(30, 10, userName);
            }
            else if (playerInput == 2)
            {
                Game(50, 7, userName);
            }
            else if (playerInput == 3)
            {
                Game(70, 6, userName);
            }
            else if (playerInput == 4)
            {
                Game(100, 3, userName);
            }
            else
            {
                Console.Clear();

            }
        }
    }
}