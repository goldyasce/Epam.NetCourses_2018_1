using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.Web.Models
{
    public class UsersAndRewardsViewModel
    {
        public User User { get; set; }

        public List<RewardViewModel> AllRewards { get; set; }

        public static UsersAndRewardsViewModel CreateModel(User user, List<Reward> rewards)
        {
            var model = new UsersAndRewardsViewModel();
            model.User = user;
            model.AllRewards = new List<RewardViewModel>();
            foreach (Reward r in rewards)
            {
                var isChecked = user == null ? false : ContainsReward(r,user.Rewards);
                var rewardModel = RewardViewModel.ToModel(r, isChecked);
                model.AllRewards.Add(rewardModel);
            }

            return model;
        }
        private static bool ContainsReward(Reward reward, List<Reward> rewards)
        {
            foreach (var rewardTemp in rewards)
            {
                if (rewardTemp.ID == reward.ID)
                {
                    return true;
                }

            }
            return false;
        }
    }
}