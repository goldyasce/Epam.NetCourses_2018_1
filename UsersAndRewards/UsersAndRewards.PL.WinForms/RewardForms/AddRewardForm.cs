using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms.RewardForms
{
    public partial class AddRewardForm : Form
    {
        private readonly bool _createNew = true;
        public string Title { get; private set; }
        public string Description { get; private set; }

        public AddRewardForm()
        {
            InitializeComponent();
        }

        public AddRewardForm(Reward reward)
        {
            InitializeComponent();

            Title = reward.Title;
            Description = reward.Description;
            _createNew = false;
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            Title = txtTitle.Text.Trim();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTitle.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 50)
            {
                errorProvider1.SetError(txtTitle, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text.Trim();
        }

        private void AddRewardForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = Title;
            txtDescription.Text = Description;
            if (_createNew)
            {
                Text = "Add new reward";
                btnOk.Text = "Create";
            }
            else
            {
                Text = "Edit reward";
                btnOk.Text = "Update";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTitle.Text.Trim();
            if (input.Length > 250)
            {
                errorProvider1.SetError(txtTitle, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTitle, String.Empty);
                e.Cancel = false;
            }
        }

        //private void txtDescription_Validating(object sender, CancelEventArgs e)
        //{
        //    string input = txtDescription.Text.Trim();
        //    if (String.IsNullOrEmpty(input))
        //    {
        //        errorProvider1.SetError(txtDescription, "Некорректное значение!");
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtDescription, String.Empty);
        //        e.Cancel = false;
        //    }
        //}
    }
}
