using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMainProject
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreateTime { get; set; }

        public static User ParseUser(string info)
        {
            if(info == "")
            {
                return null;
            }
            var information = info.Split('-');

            var user = new User()
            {
                FirstName = information[0],
                LastName = information[1],
                UserName = information[2],
                DateOfBirth = DateTime.Parse(information[3]),
                CreateTime = DateTime.Parse(information[4]),
            };
            return user;
        }
    }
}
