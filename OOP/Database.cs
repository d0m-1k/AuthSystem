using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Sql;
using System.Linq;

namespace OOP
{
    internal class Database
    {
        public static List<User> users = new List<User>();
        public static User addUser(string username, string passwordHash)
        {
            User user = new User(users.Count, username, passwordHash);
            users.Add(user);
            return user;
        }
        public static User getUser(string username, string passwordHash)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username) {
                    if (users[i].PasswordHash == passwordHash) {
                        return users[i];
                    }
                }
            }
            return null;
        }
    }
}
