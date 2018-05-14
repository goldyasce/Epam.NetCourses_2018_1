using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms.UserForms
{
    public partial class AddUserForm : Form
    {
        private readonly bool _createNew = true;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public BindingList<Reward> allRewards = new BindingList<Reward>();
        public List<Reward> chkreward;

        public AddUserForm(List<Reward> allRewards)
        {
            InitializeComponent();
            ctlCheckxBoxList.DataSource = allRewards;
            ctlCheckxBoxList.DisplayMember = "Title";
            ctlCheckxBoxList.ValueMember = "Title";
        }

        public AddUserForm(User user, List<Reward> allRewards)
        {
            InitializeComponent();
            FirstName = user.FirstName;
            LastName = user.LastName;
            DateOfBirth = user.DateOfBirth;
            ctlCheckxBoxList.DataSource = allRewards;
            ctlCheckxBoxList.DisplayMember = "Title";
            ctlCheckxBoxList.ValueMember = "Title";
            chkreward = user.Rewards;
            _createNew = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            chkreward = ctlCheckxBoxList.CheckedItems.OfType<Reward>().ToList();
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtFirstName.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length>50)
            {
                errorProvider.SetError(txtFirstName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtLastName.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 50)
            {
                errorProvider.SetError(txtLastName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text.Trim();
        }

        private void ctlDateOfBirth_Validated(object sender, EventArgs e)
        {
            DateOfBirth = ctlDateOfBirth.Value.Date;
        }

        private void ctlDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            DateTime input = ctlDateOfBirth.Value;
            if (!(input.CompareTo(DateTime.Now) < 0 && (DateTime.Now.Year - input.Year) < 150))
            {
                errorProvider.SetError(ctlDateOfBirth, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(ctlDateOfBirth, String.Empty);
                e.Cancel = false;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            if (DateOfBirth == DateTime.MinValue)
            {
                ctlDateOfBirth.Value = DateTime.Now;
            }
            else
            {
                ctlDateOfBirth.Value = DateOfBirth;
            }
            if (chkreward != null)
            {
                for (int i = 0; i < ctlCheckxBoxList.Items.Count; i++)
                {
                    if (chkreward.Contains((Reward)ctlCheckxBoxList.Items[i]))
                    {
                        ctlCheckxBoxList.SetItemChecked(i, true);
                    }
                }
            }
            if (_createNew)
            {
                Text = "Add new user";
                btnOk.Text = "Create";
            }
            else
            {
                Text = "Edit user";
                btnOk.Text = "Update";
            }
        }
    }
}
