namespace UsersAndRewards.PL.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlTabPage1 = new System.Windows.Forms.TabPage();
            this.ctlUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTabPage2 = new System.Windows.Forms.TabPage();
            this.ctlReward = new System.Windows.Forms.DataGridView();
            this.ID_Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenuReward = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctlMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddReward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateReward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab.SuspendLayout();
            this.ctlTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUser)).BeginInit();
            this.ctlContextMenuUser.SuspendLayout();
            this.ctlTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlReward)).BeginInit();
            this.ctlContextMenuReward.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlTab
            // 
            this.ctlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlTab.Controls.Add(this.ctlTabPage1);
            this.ctlTab.Controls.Add(this.ctlTabPage2);
            this.ctlTab.Location = new System.Drawing.Point(0, 23);
            this.ctlTab.Margin = new System.Windows.Forms.Padding(2);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(600, 343);
            this.ctlTab.TabIndex = 0;
            // 
            // ctlTabPage1
            // 
            this.ctlTabPage1.Controls.Add(this.ctlUser);
            this.ctlTabPage1.Location = new System.Drawing.Point(4, 22);
            this.ctlTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.ctlTabPage1.Name = "ctlTabPage1";
            this.ctlTabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.ctlTabPage1.Size = new System.Drawing.Size(592, 317);
            this.ctlTabPage1.TabIndex = 0;
            this.ctlTabPage1.Text = "Users";
            this.ctlTabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlUser
            // 
            this.ctlUser.AllowUserToAddRows = false;
            this.ctlUser.AllowUserToDeleteRows = false;
            this.ctlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ctlUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ctlUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.Age,
            this.Rewards});
            this.ctlUser.ContextMenuStrip = this.ctlContextMenuUser;
            this.ctlUser.Location = new System.Drawing.Point(2, 2);
            this.ctlUser.Margin = new System.Windows.Forms.Padding(2);
            this.ctlUser.MultiSelect = false;
            this.ctlUser.Name = "ctlUser";
            this.ctlUser.ReadOnly = true;
            this.ctlUser.RowTemplate.Height = 24;
            this.ctlUser.Size = new System.Drawing.Size(590, 314);
            this.ctlUser.TabIndex = 0;
            this.ctlUser.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUser_ColumnHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "User ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 68;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 82;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 83;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 91;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 51;
            // 
            // Rewards
            // 
            this.Rewards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rewards.DataPropertyName = "Rewards";
            this.Rewards.HeaderText = "Rewards";
            this.Rewards.Name = "Rewards";
            this.Rewards.ReadOnly = true;
            // 
            // ctlContextMenuUser
            // 
            this.ctlContextMenuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlContextMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.ctlContextMenuUser.Name = "ctlContextMenuUser";
            this.ctlContextMenuUser.Size = new System.Drawing.Size(147, 70);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addUserToolStripMenuItem.Text = "Add user...";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.updateUserToolStripMenuItem.Text = "Update user...";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user...";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // ctlTabPage2
            // 
            this.ctlTabPage2.Controls.Add(this.ctlReward);
            this.ctlTabPage2.Location = new System.Drawing.Point(4, 22);
            this.ctlTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.ctlTabPage2.Name = "ctlTabPage2";
            this.ctlTabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.ctlTabPage2.Size = new System.Drawing.Size(592, 317);
            this.ctlTabPage2.TabIndex = 1;
            this.ctlTabPage2.Text = "Rewards";
            this.ctlTabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlReward
            // 
            this.ctlReward.AllowUserToAddRows = false;
            this.ctlReward.AllowUserToDeleteRows = false;
            this.ctlReward.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ctlReward.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ctlReward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Reward,
            this.Title,
            this.Description});
            this.ctlReward.ContextMenuStrip = this.ctlContextMenuReward;
            this.ctlReward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlReward.Location = new System.Drawing.Point(2, 2);
            this.ctlReward.Margin = new System.Windows.Forms.Padding(2);
            this.ctlReward.Name = "ctlReward";
            this.ctlReward.ReadOnly = true;
            this.ctlReward.RowTemplate.Height = 24;
            this.ctlReward.Size = new System.Drawing.Size(588, 313);
            this.ctlReward.TabIndex = 0;
            this.ctlReward.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlReward_ColumnHeaderMouseClick);
            // 
            // ID_Reward
            // 
            this.ID_Reward.DataPropertyName = "ID";
            this.ID_Reward.HeaderText = "ID";
            this.ID_Reward.Name = "ID_Reward";
            this.ID_Reward.ReadOnly = true;
            this.ID_Reward.Visible = false;
            this.ID_Reward.Width = 50;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 52;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // ctlContextMenuReward
            // 
            this.ctlContextMenuReward.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlContextMenuReward.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRewardToolStripMenuItem,
            this.updateRewardToolStripMenuItem,
            this.deleteRewardToolStripMenuItem});
            this.ctlContextMenuReward.Name = "ctlContextMenuReward";
            this.ctlContextMenuReward.Size = new System.Drawing.Size(161, 70);
            // 
            // addRewardToolStripMenuItem
            // 
            this.addRewardToolStripMenuItem.Name = "addRewardToolStripMenuItem";
            this.addRewardToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addRewardToolStripMenuItem.Text = "Add reward...";
            this.addRewardToolStripMenuItem.Click += new System.EventHandler(this.addRewardToolStripMenuItem_Click);
            // 
            // updateRewardToolStripMenuItem
            // 
            this.updateRewardToolStripMenuItem.Name = "updateRewardToolStripMenuItem";
            this.updateRewardToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateRewardToolStripMenuItem.Text = "Update reward...";
            this.updateRewardToolStripMenuItem.Click += new System.EventHandler(this.updateRewardToolStripMenuItem_Click);
            // 
            // deleteRewardToolStripMenuItem
            // 
            this.deleteRewardToolStripMenuItem.Name = "deleteRewardToolStripMenuItem";
            this.deleteRewardToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteRewardToolStripMenuItem.Text = "Delete reward...";
            this.deleteRewardToolStripMenuItem.Click += new System.EventHandler(this.deleteRewardToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlMenuFile,
            this.userToolStripMenuItem,
            this.rewardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ctlMenuFile
            // 
            this.ctlMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuExit});
            this.ctlMenuFile.Name = "ctlMenuFile";
            this.ctlMenuFile.Size = new System.Drawing.Size(37, 20);
            this.ctlMenuFile.Text = "File";
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(92, 22);
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUser,
            this.btnUpdateUser,
            this.btnDeleteUser});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(146, 22);
            this.btnAddUser.Text = "Add user...";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(146, 22);
            this.btnUpdateUser.Text = "Update user...";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click_1);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(146, 22);
            this.btnDeleteUser.Text = "Delete user...";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
            // 
            // rewardToolStripMenuItem
            // 
            this.rewardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddReward,
            this.btnUpdateReward,
            this.btnDeleteReward});
            this.rewardToolStripMenuItem.Name = "rewardToolStripMenuItem";
            this.rewardToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rewardToolStripMenuItem.Text = "Reward";
            // 
            // btnAddReward
            // 
            this.btnAddReward.Name = "btnAddReward";
            this.btnAddReward.Size = new System.Drawing.Size(160, 22);
            this.btnAddReward.Text = "Add reward...";
            this.btnAddReward.Click += new System.EventHandler(this.btnAddReward_Click_1);
            // 
            // btnUpdateReward
            // 
            this.btnUpdateReward.Name = "btnUpdateReward";
            this.btnUpdateReward.Size = new System.Drawing.Size(160, 22);
            this.btnUpdateReward.Text = "Update reward...";
            this.btnUpdateReward.Click += new System.EventHandler(this.btnUpdateReward_Click_1);
            // 
            // btnDeleteReward
            // 
            this.btnDeleteReward.Name = "btnDeleteReward";
            this.btnDeleteReward.Size = new System.Drawing.Size(160, 22);
            this.btnDeleteReward.Text = "Delete reward...";
            this.btnDeleteReward.Click += new System.EventHandler(this.btnDeleteReward_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Users and Rewards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctlTab.ResumeLayout(false);
            this.ctlTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUser)).EndInit();
            this.ctlContextMenuUser.ResumeLayout(false);
            this.ctlTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlReward)).EndInit();
            this.ctlContextMenuReward.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage ctlTabPage1;
        private System.Windows.Forms.TabPage ctlTabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctlMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuExit;
        private System.Windows.Forms.DataGridView ctlUser;
        private System.Windows.Forms.DataGridView ctlReward;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddUser;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem rewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddReward;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateReward;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteReward;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuUser;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuReward;
        private System.Windows.Forms.ToolStripMenuItem addRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRewardToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Reward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

