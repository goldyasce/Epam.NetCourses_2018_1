using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class InMemoryData : IData
    {
        private List<User> users;

        private List<Reward> rewards;

        public InMemoryData()
        {
            users = new List<User>();
            rewards = new List<Reward>();
        }
        public void AddReward(Reward reward)
        {
            var maxId = 0;
            var ids = rewards.Select(u => u.ID);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            reward.ID = maxId + 1;
            rewards.Add(reward);
        }

        public void AddUser(User user)
        {
            var maxId = 0;
            var ids = users.Select(u => u.ID);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            user.ID = maxId + 1;
            users.Add(user);
        }

        public void DeleteReward(int rewardId)
        {
            var tempReward = rewards.Find(r => r.ID == rewardId);
            foreach (var user in users)
            {
                if (user.Rewards != null)
                {
                    if (user.Rewards.Contains(tempReward))
                    {
                        user.Rewards.Remove(tempReward);
                    }
                }
            }
            rewards.Remove(tempReward);
        }

        public void DeleteUser(int userId)
        {
            var tempUser = users.Find(r => r.ID == userId);
            users.Remove(tempUser);
        }

        public Reward GetRewardById(int rewardId)
        {
            
            return rewards.Find(r => r.ID == rewardId); ;
        }

        public List<Reward> GetRewards()
        {
            return new List<Reward>(rewards);
        }

        public User GetUserById(int userId)
        {
            return users.Find(r => r.ID == userId);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void UpdateReward(Reward reward)
        {
            var tempReward = rewards.Find(r => r.ID == reward.ID);
            tempReward.Title = reward.Title;
            tempReward.Description = reward.Description;
        }

        public void UpdateUser(User user)
        {
            var tempUser = users.Find(u => u.ID == user.ID);
            tempUser.FirstName = user.FirstName;
            tempUser.LastName = user.LastName;
            tempUser.DateOfBirth = user.DateOfBirth;
            tempUser.Rewards = user.Rewards;
        }
    }
}
