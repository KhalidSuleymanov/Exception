using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNoValue
{
    internal class Student
    {
        static int _totalCount;
        public Student()
        {
            _totalCount++;
            No = _totalCount;

        }
        static Student()
        {
            _totalCount = 100;
        }


        public int No;
        string _name;
        private string _groupNo;
        private string _password;
        static public int TotalCount;
        public string FullName;
        public byte Point;
        protected double _price;
        public static void ShowInfo()
        {
            Console.WriteLine();
        }
        public string Password
        {
            set
            {
                if (PassWord(value))
                {
                    _password = value;
                }
            }
            get
            {
                return _password;
            }
        }
        public string GroupNo
        {
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
            get
            {
                return _groupNo;
            }
        }

        
        public string Name
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2 && value.Length <= 20)
                {
                    _name = value;
                }
                   
            }
            get
            {
                return _name;
            }
        }

        

        public virtual double Price
        {
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                    
            }
            get
            {
                return _price;
            }
        }

        public static bool PassWord(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) || password.Length >= 8 || password.Length <= 25)
            {
                return true;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static public bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(groupNo[0]))
            {
                return false;
            }
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
