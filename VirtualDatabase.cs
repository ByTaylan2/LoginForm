using System.Collections.Generic;

namespace LoginForm
{
    static internal class VirtualDatabase
    {
        public static List<User> users;
        static VirtualDatabase()
        {
            users = new List<User>();
            users.Add(new User()
            {
                Username = "hp",
                Password = "hp123",
                Name = "HP",
                Surname = "USER",
                Description = "Description about a hp user"
            });
        }
    }
}
