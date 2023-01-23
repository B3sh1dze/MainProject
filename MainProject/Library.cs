using MainProject;

namespace Midterm
{
    public class Library
    {
        private const string USERS_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MainProject\UserName.txt";

        private User CreateUser()
        {
            Console.Write("Enter your username: ");
            var userName = Console.ReadLine();

            if (IsUserRegistered(userName!))
            {
                Console.WriteLine($"User already registered with username: {userName}!");
                return null;
            }

            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter birth date (mm-d-yyyy: ");
            var birthDate = DateTime.Parse(Console.ReadLine());


            var newUser = new User()
            {
                FirstName = firstName!,
                LastName = lastName!,
                UserName = userName!,
                BirthDate = birthDate,
                CreatedAt = DateTime.Now
            };


            return newUser;
        }

        // overriding string method would do the work too

        public void DisplayAllUsers()
        {
            var usersList = File.ReadAllLines(USERS_FILE_PATH);

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

            // get user in format ...-...-...-...-...

            var formattedUser = user.ToString();

            Console.WriteLine(user);

            // save user in txt file
            File.AppendAllText(USERS_FILE_PATH,
                    formattedUser + Environment.NewLine);

        }

        private bool IsUserRegistered(string userName)
        {
            var usersList = File.ReadAllLines(USERS_FILE_PATH);
            Console.WriteLine(usersList.Le);

            foreach (var str in usersList)
            {
                Console.WriteLine(str);
                var user = User.ParseUser(str);
                if (user.UserName == userName)
                {
                    return true;
                }
            }

            return false;
        }

        public void Login()
        {

        }

        void MainMenu()
        {
            //

        }


    }
}
