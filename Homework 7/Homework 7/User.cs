using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    internal class User
    {
        public User(string username)
        {           
        }
        public string UserName
        {
            get => _userName;
            set
            {
                if(IsUserNameTrue(value))
                _userName=value;
            } 
        }

        public string Password
        {
            get => _password;
            set
            {
                if (IsPasswordTrue(value)) 
                _password = value;
            }
        }

        public string DateTime
        {
            get => _dateTime;
            set
            {
                    _dateTime = value;
            }
        }

        private string _dateTime;
        private string _userName;
        private string _password;

        public bool IsUserNameTrue(string username)
        {
            if (username.Length >=6 && username.Length <= 25)
            {
                return true;
            }
            else
                return false;
        }

        public bool PasswordLength(string paswoord)
        {
            if (paswoord.Length >= 8 && paswoord.Length <= 25)
            {
                return true;
            }
            return false;
        }
        public bool HasDigit(string input1)
        {
            for(int i = 0; i < input1.Length; i++)
            {
                if (char.IsDigit(input1[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string input2)
        {
            for(int i = 0; i < input2.Length; i++)
            {
                if (char.IsUpper(input2[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string input3)
        {
            for(int i=0;i< input3.Length; i++)
            {
                if (char.IsLower(input3[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPasswordTrue(string input)
        {
            if(HasDigit(input) && HasLower(input) && HasUpper(input) && PasswordLength(input))
            {
                return true;
            }
            return false;
        }
    }
}
