using MainProject;
using System.Runtime.ExceptionServices;

namespace Midterm
{
    public class Library
    {
        private int lineNumber;
        private const string USERNAMES_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\UserNames.txt";
        private const string USERS_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\Users.txt";
        private const string PASSWORDS_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\PassWords.txt";
        private const string ACCOUNTS_HISTORY_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\AccountHistory.txt";

        private User CreateUser()
        {
            Console.Write("Enter your username: ");
            var userName = Console.ReadLine();
            
            if (IsUserRegistered(userName!))
            {
                Console.WriteLine($"User already registered with username: {userName}!");
                Console.Write("Enter your password: ");
                var passWord = Console.ReadLine();
                if (IsPasswordValid(passWord!))
                    {
                    Console.WriteLine("The password is correct.");
                    MainMenu(userName!);
                    return null;
                    }
                return null;
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Username doesn't exist. please enter your personal information to get logged in.");
                Console.WriteLine();
                Console.Write("Enter your first name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your last name: ");
                var lastName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your username: ");
                userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your password: ");
                var passWord = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter birth date (mm-d-yyyy: ");
                var birthDate = DateTime.Parse(Console.ReadLine());
                MainMenu(userName!);

                var newUser = new User()
                {
                    FirstName = firstName!,
                    LastName = lastName!,
                    UserName = userName!,
                    Password = passWord,
                    BirthDate = birthDate,
                    CreatedAt = DateTime.Now
                };
                Console.WriteLine();
                return null;
            }
            
        }
        public void DisplayAllUsers()
        {
            var usersList = File.ReadAllLines(USERNAMES_FILE_PATH);

            if (usersList.Length == 0)
            {
                Console.WriteLine("No users found");
                return;
            }
            foreach (var str in usersList)
            {
                var user = User.ParseUser(str);
                Console.WriteLine(user);
            }
        }
        public void RegisterUser()
        {
            var user = CreateUser();

            if (user == null)
            {
                return;
            }
            var formattedUser = user.ToString();

            Console.WriteLine(user);

            File.AppendAllText(USERNAMES_FILE_PATH,
                    formattedUser + Environment.NewLine);
            File.AppendAllText(USERS_FILE_PATH, user.UserName + Environment.NewLine);
            File.AppendAllText(PASSWORDS_FILE_PATH, user.Password + Environment.NewLine);
        }

        private bool IsUserRegistered(string userName)
        {
            var usersList = File.ReadAllLines(USERNAMES_FILE_PATH);
            lineNumber = 1;

            foreach (var str in usersList)
            {
                var user = User.CheckUser(str);
                if (user.UserName == userName)
                {
                    return true;
                }
                lineNumber++;
            }
            return false;
        }
        private bool IsPasswordValid(string passWord)
        {
            var userPasswords = File.ReadAllLines(PASSWORDS_FILE_PATH);
            foreach (var password in userPasswords)   
            {
                var user = User.CheckPassword(password);
                if(user.Password == passWord)
                {
                    return true;
                }
            }
            return false;
        }
        private void AccHistory(string userName)
        {
            var userHistory = File.ReadAllText(ACCOUNTS_HISTORY_FILE_PATH);
            var user = User.CheckHistory(userName);
            foreach (var item in userHistory)
            {
                if (user.UserName == userName)
                {
                    Console.Write(item);
                }        
            }
        }
        public void Login(string passWord)
        {
            Console.Write("Please enter your password: ");
            passWord = Console.ReadLine();
        }

        void MainMenu(string userName)
        {
            Console.WriteLine();
            Console.WriteLine($"Welcome {userName} to our platform!");
            Console.WriteLine("if you want to entertain there is some kind of games");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("press 1 to play TicTacToe game.");
                Console.WriteLine("press 2 to play Number Guessing game.");
                Console.WriteLine("press 3 to play Rock-Paper-Scissors game.");
                Console.WriteLine("if you want to show up your account history press 4.");
                Console.WriteLine("to see all accounts press 5.");
                Console.WriteLine("if you want to exit press 'q'.");
                Console.WriteLine();
                char playersChoice = Convert.ToChar(Console.ReadLine());
                if (playersChoice == '1')
                {
                    var tic = new TicTacToe(userName);
                }
                else if (playersChoice == '2')
                {
                    var NBG = new NumberGuessingGame(userName);
                }
                else if (playersChoice == '3')
                {
                    var RPS = new Rock_Paper_Scissors(userName);
                }
                else if (playersChoice == '4')
                {
                    Console.WriteLine($"Here is your account history {userName}!");
                    AccHistory(userName);
                }
                else if (playersChoice == '5')
                {
                    Console.WriteLine($"hello {userName} welcome to account system");
                    DisplayAllUsers();
                }
                else if (playersChoice == 'q')
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
