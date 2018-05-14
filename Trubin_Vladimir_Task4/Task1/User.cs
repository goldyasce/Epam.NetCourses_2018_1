using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string userName;
        private string secondName;
        private string surname;
        private DateTime dateOfBirth;
        private int age;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("User name can't be empty!!!");
                }
                else
                {
                    userName = value;
                }
            }
        }

        public string SecondName { get; set; }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Surname can't be empty!!!");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public int Age
        {
            get;
        }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if ((DateTime.Today.Year - Age) == value.Year)
                {
                    dateOfBirth = value;
                }
            }
        }
    }
}
