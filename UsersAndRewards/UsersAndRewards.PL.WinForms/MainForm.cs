using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UsersAndRewards.PL.WinForms.RewardForms;
using UsersAndRewards.PL.WinForms.UserForms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
    public partial class MainForm : Form
    {
        private List<User> _users = new List<User>();
        private BindingList<UserViewModel> _usersView = new BindingList<UserViewModel>();
        #region Sort Mode
        private enum SortMode { Asceding, Desceding };
        private SortMode _sortModeFirstName = SortMode.Asceding;
        private SortMode _sortModeLastName = SortMode.Asceding;
        private SortMode _sortModeDateofbirth = SortMode.Asceding;
        private SortMode _sortModeAge = SortMode.Asceding;
        private SortMode _sortModeReward = SortMode.Asceding;
        private SortMode _sortModeRewardTitle = SortMode.Asceding;
        #endregion
        private ILogic logic;

        public MainForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            ctlReward.AutoGenerateColumns = false;
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser()
        {
            AddUserForm form = new AddUserForm(logic.GetRewards());
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                User user = new User();
                user.FirstName = form.FirstName;
                user.LastName = form.LastName;
                user.DateOfBirth = form.DateOfBirth;
                user.Add(form.chkreward);
                logic.AddUser(user);
                UpdateUsersGrid();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var users = logic.GetUsersViewModel();
            ctlUser.DataSource = users;
            var rewards = logic.GetRewards();
            ctlReward.DataSource = rewards;
        }

        private void UpdateUsersGrid()
        {
            var users = logic.GetUsersViewModel();
            ctlUser.DataSource = users;
            ctlUser.Refresh();
            ctlUser.Update();
        }

        private void UpdateRewardsGrid()
        {
            var rewards = logic.GetRewards();
            ctlReward.DataSource = rewards;
            ctlReward.Refresh();
            ctlReward.Update();
        }

        private void RemoveSelectedUser()
        {
            if (ctlUser.SelectedCells.Count > 0)
            {
                UserViewModel userView = (UserViewModel)ctlUser.SelectedCells[0].OwningRow.DataBoundItem;
                logic.DeleteUser(userView.ID);
                UpdateUsersGrid();
            }
        }

        private void EditSelectedUser()
        {
            if (ctlUser.SelectedCells.Count > 0)
            {
                UserViewModel userView = (UserViewModel)ctlUser.SelectedCells[0].OwningRow.DataBoundItem;
                User user = userView.GetUser();
                AddUserForm form = new AddUserForm(user, logic.GetRewards());
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    user.Add(form.chkreward);
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.DateOfBirth = form.DateOfBirth;
                    logic.UpdateUser(user);
                    UpdateUsersGrid();
                }
            }
        }

        private void AddReward()
        {
            AddRewardForm form = new AddRewardForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Reward reward = new Reward();
                reward.Title = form.Title;
                reward.Description = form.Description;
                logic.AddReward(reward);
                UpdateRewardsGrid();
            }
        }

        private void EditSelectedRewards()
        {
            if (ctlReward.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlReward.SelectedCells[0].OwningRow.DataBoundItem;
                AddRewardForm form = new AddRewardForm(reward);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    reward.Title = form.Title;
                    reward.Description = form.Description;
                    logic.UpdateReward(reward);
                }
            }
            UpdateUsersGrid();
            UpdateRewardsGrid();
        }

        private void RemoveSelectedReward()
        {
            if (ctlReward.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlReward.SelectedCells[0].OwningRow.DataBoundItem;
                logic.DeleteReward(reward.ID);
                UpdateUsersGrid();
                UpdateRewardsGrid();
            }
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            UserViewModel userView = (UserViewModel)ctlUser.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"You want to delete {userView.FirstName} {userView.LastName}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedUser();
            }
        }

        private void btnAddReward_Click_1(object sender, EventArgs e)
        {
            AddReward();
        }

        private void btnUpdateReward_Click_1(object sender, EventArgs e)
        {
            EditSelectedRewards();
        }

        private void btnDeleteReward_Click_1(object sender, EventArgs e)
        {
            Reward reward = (Reward)ctlReward.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"You want to delete {reward.Title}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedReward();
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserViewModel userView = (UserViewModel)ctlUser.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"You want to delete {userView.FirstName} {userView.LastName}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedUser();
            }
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void addRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void updateRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedRewards();
        }

        private void deleteRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reward reward = (Reward)ctlReward.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialogres = MessageBox.Show($"You want to delete {reward.Title}?", "Warning", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                RemoveSelectedReward();
            }
        }

        private void SortByFirstNameAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.FirstName).ToList());
        }

        private void SortByFirstNameDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.FirstName).ToList());
        }

        private void SortByLastNameAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.LastName).ToList());
        }

        private void SortByLastNameDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.LastName).ToList());
        }

        private void SortByDateOfBirthAsc()
        {
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.DateOfBirth).ToList());
        }

        private void SortByDateOfBirthDesc()
        {
            //_users = new List<UserViewModel>(_users.OrderByDescending(s => s.DateOfBirth).ToList());
        }
        private void SortByAgeAsc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.Age).ToList());
        }

        private void SortByAgeDesc()
        {
            _usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.Age).ToList());
        }

        private void SortByRewardAsc()
        {
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderBy(s => s.Rewards.Count).ToList());
        }

        private void SortByRewardDesc()
        {
            //_usersView = new BindingList<UserViewModel>(_usersView.OrderByDescending(s => s.Rewards.Count).ToList());
        }

        private void SortByRewardTitleAsc()
        {
            //_rewards = new BindingList<Reward>(_rewards.OrderBy(s => s.Title).ToList());
        }

        private void SortByRewardTitleDesc()
        {
            //_rewards = new BindingList<Reward>(_rewards.OrderByDescending(s => s.Title).ToList());
        }

        private void ctlUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (_sortModeFirstName == SortMode.Asceding)
                {
                    SortByFirstNameDesc();
                    _sortModeFirstName = SortMode.Desceding;
                }
                else
                {
                    SortByFirstNameAsc();
                    _sortModeFirstName = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (_sortModeLastName == SortMode.Asceding)
                {
                    SortByLastNameDesc();
                    _sortModeLastName = SortMode.Desceding;
                }
                else
                {
                    SortByLastNameAsc();
                    _sortModeLastName = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (_sortModeDateofbirth == SortMode.Asceding)
                {
                    SortByDateOfBirthDesc();
                    _sortModeDateofbirth = SortMode.Desceding;
                }
                else
                {
                    SortByDateOfBirthAsc();
                    _sortModeDateofbirth = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (_sortModeAge == SortMode.Asceding)
                {
                    SortByAgeDesc();
                    _sortModeAge = SortMode.Desceding;
                }
                else
                {
                    SortByAgeAsc();
                    _sortModeAge = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 5)
            {
                if (_sortModeReward == SortMode.Asceding)
                {
                    SortByRewardDesc();
                    _sortModeReward = SortMode.Desceding;
                }
                else
                {
                    SortByRewardAsc();
                    _sortModeReward = SortMode.Asceding;
                }
            }
            UpdateUsersGrid();
        }

        private void ctlReward_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (_sortModeRewardTitle == SortMode.Asceding)
                {
                    SortByRewardTitleDesc();
                    _sortModeRewardTitle = SortMode.Desceding;
                }
                else
                {
                    SortByRewardTitleAsc();
                    _sortModeRewardTitle = SortMode.Asceding;
                }
            }
            UpdateRewardsGrid();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
