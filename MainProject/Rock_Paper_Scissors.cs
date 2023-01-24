using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Rock_Paper_Scissors
    {
        int computerWins = 0;
        int playersWins = 0;
        string[] moves = { "rock", "paper", "scissors" };
        private const string ACCOUNTS_HISTORY_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\AccountHistory.txt";
        public Rock_Paper_Scissors(string userName)
        { 
            while (computerWins != 3 && playersWins != 3)
            {
                Console.Write("Please enter the character you want from('r','s','p'): ");
                char playersInput = Convert.ToChar(Console.ReadLine());
                if (playersInput != 'r' && playersInput != 's' && playersInput != 'p')
                {
                    Console.WriteLine("wrong input! please enter the correct character! ");
                    continue;
                }
                int playersMoveIndex = -1;
                if (playersInput == 'r') playersMoveIndex = 0;
                else if (playersInput == 'p') playersMoveIndex = 1;
                else if (playersInput == 's') playersMoveIndex = 2;
                string playerMove = moves[playersMoveIndex];
                Console.WriteLine($"Player's move is: {playerMove}");
                var random = new Random();
                int randomNumber = random.Next(0, 3);
                string computersMove = moves[randomNumber];
                Console.WriteLine($"computer's move: {computersMove}");
                if ((playersInput == 'r' && computersMove == "scissors") || (playersInput == 'p' && computersMove == "rock") || (playersInput == 's' && computersMove == "paper"))
                {
                    Console.WriteLine($"{userName} wins!");
                    playersWins++;
                }
                else if (playersMoveIndex == randomNumber)
                {
                 Console.WriteLine("It's a tie!");
                }
                else
                {
                Console.WriteLine("computer wins!");
                computerWins++;
                }
                Console.WriteLine($"computer's score: {computerWins}");
                Console.WriteLine($"{userName}'s score: {playersWins}");
            }
            if(playersWins == 3)
            {
                Console.WriteLine($"{userName} wins!");
                File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Rock-Paper-Scissors Game against computer at " + DateTime.Now + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Computer wins!");
                File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Rock-Paper-Scissors Game against computer at " + DateTime.Now + Environment.NewLine);
            }
        }
    }
}

