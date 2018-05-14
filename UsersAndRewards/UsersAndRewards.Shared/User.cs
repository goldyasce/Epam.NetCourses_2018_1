using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class User
    {
        static int i = 0;
        public User()
        {
            Rewards = new List<Reward>();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Reward> Rewards { get; set; }
        public int Age
        {
            get
            {
                int age = 0;
                if (DateTime.Today.Month < DateOfBirth.Month)
                {
                    age = DateTime.Today.Year - DateOfBirth.Year - 1;
                }
                else
                {
                    age = DateTime.Today.Year - DateOfBirth.Year;
                }
                return age;
            }
        }

        public void Add(List<Reward> Rewards)
        {
            this.Rewards = Rewards;
        }
    }
}
