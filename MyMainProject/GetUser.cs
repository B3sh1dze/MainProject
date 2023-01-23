using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMainProject
{
    public class GetUser
    {
        private const string USERS_FILE_PATH = @"C:\Users\99559\Desktop\MainProject\MyMainProject\Users.txt";

        private User CreateUser()
        {
            Console.Write("Please enter your username: ");
            var userName = Console.ReadLine(); 
            if(IsUserRegistered(userName!))
            {
                Console.WriteLine($"User already registered with this username {userName}");
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
                DateOfBirth = birthDate,
                CreateTime = DateTime.Now,
            };
            return newUser;
        }

        public void RegisterUser()
        {
            var user = CreateUser();
            if(user == null)
            {
                return;
            }
            var formattedUser = user.ToString();
            File.AppendAllText(USERS_FILE_PATH, formattedUser + Environment.NewLine);
        }
        private bool IsUserRegistered(string userName)
        {
            var usersList = File.ReadAllLines(USERS_FILE_PATH);

            foreach (var str in usersList)
            {
                var user = User.ParseUser(str);
                if (user.UserName == userName)
                {
                    return true;
                }
            }

            return false;
        }

        public GetUser()
        {
            RegisterUser();
        }
    }
}
