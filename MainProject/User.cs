namespace Midterm
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public override string? ToString()
        {
            return $"{UserName}-{FirstName}-{LastName}-{BirthDate}-{CreatedAt}";
        }
        public static User CheckUser(string info)
        {
            var parts = info.Split('-');
            var user = new User()
            {
                UserName = parts[0]      
            };
            return user;
        }
        public static User CheckPassword(string info)
        {
            var parts = info.Split('-');
            var user = new User()
            {
                Password = parts[0]
            };
            return user;
        }
        public static User CheckHistory(string info)
        {
            var parts = info.Split('-');
            var user = new User()
            {
                UserName = parts[0]
            };
            return user;
        }
        public static User ParseUser(string info)
        {
            var parts = info.Split('-');
            var user = new User()
            {
                UserName = parts[0],
                FirstName = parts[1],
                LastName = parts[2],
                BirthDate = DateTime.Parse(parts[3]),
                CreatedAt = DateTime.Parse(parts[4]),
            };
            return user;
        }

    }
}
