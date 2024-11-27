﻿namespace LaTable
{
    public class User
    {
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public List<DateTime>? dates { get; private set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
            dates = new List<DateTime>();
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLogin()
        {
            return Login;
        }

        public string GetPassword()
        {
            return Password;
        }
    }
}
