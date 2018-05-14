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
    public class UserController : Controller
    {
        private ILogic logic;
        public UserController()
        {
            logic = new Logic();
        }
        public ActionResult Index()
        {
            var users = logic.GetUsersViewModel();
            return View(users);
        }
        public ActionResult Create()
        {
            var model = UsersAndRewardsViewModel.CreateModel(null, logic.GetRewards());
            return View("UserPage", model);
        }
        public ActionResult Update(int userId)
        {
            var model = UsersAndRewardsViewModel.CreateModel(logic.GetUserById(userId), logic.GetRewards());
            return View("UserPage", model);
        }
        public ActionResult Add(UsersAndRewardsViewModel model)
        {
            var checkedRewards = model.AllRewards.Where(r => r.IsChecked).ToList();
            model.User.Rewards = checkedRewards.Select(m => new Reward { ID = m.RewardId }).ToList();
            if (model.User.ID==0)
            {
                logic.AddUser(model.User);
            }
            else
            {
                logic.UpdateUser(model.User);
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteUser(int userId)
        {
            logic.DeleteUser(userId);
            return RedirectToAction("Index");
        }
    }
}