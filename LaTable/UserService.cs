﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTable
{
    public class UserService
    {
        public List<User> users = new List<User>
        {
            new User("Надежда", "nadejda", "123"),
            new User("Салима", "salima", "123"),
            new User("Сабина", "sabina", "123"),
            new User("Алексей", "aleksey", "123"),
            new User("Ольга", "olga", "123"),
        };

        public User Authenticate(string login, string password)
        {
            foreach (var user in users)
            {
                if (user.GetLogin() == login && user.GetPassword() == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}