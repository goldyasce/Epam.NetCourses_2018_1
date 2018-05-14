using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAndRewards.BL.Logic;
using UsersAndRewards.PL.Web.Models;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.Web.Controllers
{
    public class RewardController : Controller
    {
        private ILogic logic;
        public RewardController()
        {
            logic = new Logic();
        }
        public ActionResult RewardTable()
        {
            var rewards = logic.GetRewards();
            return View("RewardPage",rewards);
        }
        public ActionResult Create()
        {
            return View("AddReward");
        }
        public ActionResult Update(int rewardID)
        {
            var model = logic.GetRewardById(rewardID);
            return View("AddReward", model);
        }
        public ActionResult Add(Reward reward)
        {
            if (reward.ID==0)
            {
                logic.AddReward(reward);
            }
            else
            {
                logic.UpdateReward(reward);
            }
            return RedirectToAction("RewardTable");
        }
        public ActionResult Delete(int rewardID)
        {
            logic.DeleteReward(rewardID);
            return RedirectToAction("RewardTable");
        }
    }
}