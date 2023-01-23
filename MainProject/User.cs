namespace Midterm
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string? ToString()
        {
            return $"{UserName}-{FirstName}-{LastName}-{BirthDate}-{CreatedAt}";
        }

        public static User ParseUser(string info)
        {
            var parts = info.Split('-');

            var user = new User()
            {
                FirstName = parts[0],
                LastName = parts[1],
                UserName = parts[2],
                BirthDate = DateTime.Parse(parts[3]),
                CreatedAt = DateTime.Parse(parts[4]),
            };

            return user;
        }


    }
}
