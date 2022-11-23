using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.models
{
    internal class User
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if ((value.Length >= 8 && value.Length <= 25))
                {
                    (int, int, int) result = (0, 0, 0);
                    foreach (char c in value)
                    {
                        if ((int)c >= 48 && (int)c <= 57)
                        {
                            result.Item1++;
                        }
                        if ((int)c >= 65 && (int)c <= 90)
                        {
                            result.Item2++;
                        }
                        if (((int)c >= 97 && (int)c <= 122))
                        {
                            result.Item3++;
                        }
                    }
                    if (result.Item1 != 0 && result.Item2 != 0 && result.Item3 != 0)
                    {
                        _password = value;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                    }
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }

        public User(string username)
        {
            _userName = username;
        }
        public User(string username, string password)
        {
            _userName = username;
            _password = password;
        }

        public bool HasDigit(string text)
        {
            foreach (char item in text)
            {
                if ((int)item >= 48 && (int)item <= 57)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string text)
        {
            foreach (char item in text)
            {
                if ((int)item >= 65 && (int)item <= 90)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string text)
        {
            foreach (char item in text)
            {
                if (((int)item >= 97 && (int)item <= 122))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
