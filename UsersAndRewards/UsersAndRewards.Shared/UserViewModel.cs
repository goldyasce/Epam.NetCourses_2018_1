using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class UserViewModel
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public string Rewards { get; set; }

        private List<Reward> rewards= new List<Reward>();

        public static UserViewModel ToModel(User user)
        {
            var model = new UserViewModel();
            model.ID = user.ID;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Age = user.Age;
            model.DateOfBirth = user.DateOfBirth;
            model.Rewards = string.Join(", ", user.Rewards.Select(r => r.Title));
            return model;
        }

        public User GetUser()
        {
            User user = new User();
            user.ID = ID;
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.DateOfBirth = DateOfBirth;
            return user;
        }
    }
}
