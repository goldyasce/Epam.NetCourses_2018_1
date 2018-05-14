using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public interface ILogic : IData
    {
        List<UserViewModel> GetUsersViewModel();
    }
}
