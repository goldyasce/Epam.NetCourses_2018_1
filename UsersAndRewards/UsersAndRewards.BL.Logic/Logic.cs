using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using UsersAndRewards.DAL.DataLayer;
using UsersAndRewards.Shared;

namespace UsersAndRewards.BL.Logic
{
    public class Logic : ILogic
    {
        private IData data;
        public Logic()
        {
            data = DataContextFactory.Create(ConfigurationManager.AppSettings.GetKey(4));
        }
        public void AddReward(Reward reward)
        {
            data.AddReward(reward);
        }

        public void AddUser(User user)
        {
            data.AddUser(user);
        }

        public void DeleteReward(int rewardId)
        {
            data.DeleteReward(rewardId);
        }

        public void DeleteUser(int userId)
        {
            data.DeleteUser(userId);
        }

        public Reward GetRewardById(int rewardId)
        {
            return data.GetRewardById(rewardId);
        }

        public List<Reward> GetRewards()
        {
            return data.GetRewards();
        }

        public User GetUserById(int userId)
        {
            return data.GetUserById(userId);
        }

        public List<User> GetUsers()
        {
            return data.GetUsers();
        }

        public List<UserViewModel> GetUsersViewModel()
        {
            var users = GetUsers();
            var usersModels = users.Select(u => UserViewModel.ToModel(u));
            return usersModels.ToList();
        }

        public void UpdateReward(Reward reward)
        {
            data.UpdateReward(reward);
        }

        public void UpdateUser(User user)
        {
            data.UpdateUser(user);
        }
    }
}
