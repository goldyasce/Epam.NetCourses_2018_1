using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User, IEquatable<Employee>
    {
        private double workStage;
        private string userPosition;
        private DateTime workStart;

        public DateTime WorkStart
        {
            get
            {
                return workStart;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Future date");
                }
                else
                {
                    workStart = value;
                }
            }
        }

        public double WorkStage
        {
            get
            {
                return workStage + (DateTime.Today.Year - workStart.Year);
            }
            set
            {
                if (value >= 0)
                {
                    workStage = value;
                }
                else
                {
                    throw new ArgumentException("Unreal stage");
                }
            }
        }
        public string UserPosition
        {
            get
            {
                return userPosition;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("User post can't be empty");
                }
                else
                {
                    userPosition = value;
                }
            }
        }

        public Employee(string UserName, string Surname, DateTime DateOfBirth,
            double workStage, string userPosition, DateTime workStart, string Secondname = null) : base(UserName, Surname, DateOfBirth, Secondname)
        {
            
        }

        bool IEquatable<Employee>.Equals(Employee other)
        {
            
            if (other != null)
            {
                return other == this;
            }

            return false;
        }
    }


}
