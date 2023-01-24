using Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class TicTacToe
    {
        char[] array = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static public int cCount = 0;
        static public int pCount = 0;
        public bool running = true;
        private const string ACCOUNTS_HISTORY_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\AccountHistory.txt";
        public void drawBoard(string userName)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {array[0]}  |  {array[1]}  |  {array[2]}  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {array[3]}  |  {array[4]}  |  {array[5]}  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {array[6]}  |  {array[7]}  |  {array[8]}  ");
            Console.WriteLine("     |     |     ");
        }

        public void playersMove(string userName)
        {
            while (true)
            {
                Console.Write("Enter the number between (1-9): ");
                int playerInput = Convert.ToInt32(Console.ReadLine());
                int arrayIndex = playerInput - 1;
                if (array[arrayIndex] == ' ')
                {
                    array[arrayIndex] = 'X';
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter different number this area is already full.");
                }
            }
        }

        public void computersMove(string userName)
        {
            Random randNum = new Random();
            int computersMove = randNum.Next(1, 9);
            int arrayIndex = computersMove - 1;

            while (true)
            {
                if (array[arrayIndex] == ' ')
                {
                    array[arrayIndex] = 'O';
                    break;
                }
                else
                {
                    computersMove = randNum.Next(1, 9);
                    arrayIndex = computersMove - 1;
                }
            }
        }

        public bool checkWinner(string userName)
        {
            if (array[0] != ' ' && array[0] == array[1] && array[1] == array[2])
            {
                if (array[0] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[3] != ' ' && array[3] == array[4] && array[4] == array[5])
            {
                if (array[3] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[6] != ' ' && array[6] == array[7] && array[7] == array[8])
            {
                if (array[6] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[0] != ' ' && array[0] == array[3] && array[3] == array[6])
            {
                if (array[0] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[1] != ' ' && array[1] == array[4] && array[4] == array[7])
            {
                if (array[1] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[2] != ' ' && array[2] == array[5] && array[5] == array[8])
            {
                if (array[2] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[0] != ' ' && array[0] == array[4] && array[4] == array[8])
            {
                if (array[0] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            else if (array[2] != ' ' && array[2] == array[4] && array[4] == array[6])
            {
                if (array[2] == 'X')
                {
                    Console.WriteLine($"{userName} wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " won Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    pCount++;
                    running = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("computer wins");
                    File.AppendAllText(ACCOUNTS_HISTORY_FILE_PATH, userName + " lost Tic-Tac-Toe game against computer at " + DateTime.Now + Environment.NewLine);
                    cCount++;
                    running = false;
                    return false;
                }
            }
            running = true;
            return true;
        }
        public TicTacToe(string userName)
        {
            running = true;
            while (running)
            {
                drawBoard(userName);
                playersMove(userName);
                computersMove(userName);
                checkWinner(userName);
                drawBoard(userName);
                //running = checkWinner(userName);
            }
        }
        
    }
}
