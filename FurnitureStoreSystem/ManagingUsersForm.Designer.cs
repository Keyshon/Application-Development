namespace FurnitureStoreSystem
{
    partial class ManagingUsersForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.ItemsTable = new System.Windows.Forms.DataGridView();
            this.EditUserGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.EditUserAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.EditUserPasswordLabel = new System.Windows.Forms.Label();
            this.EditUserAccountNameLabel = new System.Windows.Forms.Label();
            this.EditUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddUserGroupBox = new System.Windows.Forms.GroupBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddUserAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.AddUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddUserAccountNameLabel = new System.Windows.Forms.Label();
            this.AddUserPasswordLabel = new System.Windows.Forms.Label();
            this.ManageUsersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).BeginInit();
            this.EditUserGroupBox.SuspendLayout();
            this.AddUserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 279);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ItemsTable
            // 
            this.ItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsTable.Location = new System.Drawing.Point(247, 49);
            this.ItemsTable.Name = "ItemsTable";
            this.ItemsTable.Size = new System.Drawing.Size(274, 253);
            this.ItemsTable.TabIndex = 8;
            // 
            // EditUserGroupBox
            // 
            this.EditUserGroupBox.Controls.Add(this.DeleteUserButton);
            this.EditUserGroupBox.Controls.Add(this.EditUserButton);
            this.EditUserGroupBox.Controls.Add(this.EditUserAccountNameTextBox);
            this.EditUserGroupBox.Controls.Add(this.EditUserPasswordLabel);
            this.EditUserGroupBox.Controls.Add(this.EditUserAccountNameLabel);
            this.EditUserGroupBox.Controls.Add(this.EditUserPasswordTextBox);
            this.EditUserGroupBox.Location = new System.Drawing.Point(16, 155);
            this.EditUserGroupBox.Name = "EditUserGroupBox";
            this.EditUserGroupBox.Size = new System.Drawing.Size(225, 118);
            this.EditUserGroupBox.TabIndex = 7;
            this.EditUserGroupBox.TabStop = false;
            this.EditUserGroupBox.Text = "Edit User";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(116, 87);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(99, 23);
            this.DeleteUserButton.TabIndex = 17;
            this.DeleteUserButton.Text = "Delete";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(115, 58);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(100, 23);
            this.EditUserButton.TabIndex = 10;
            this.EditUserButton.Text = "Edit";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // EditUserAccountNameTextBox
            // 
            this.EditUserAccountNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.EditUserAccountNameTextBox.Name = "EditUserAccountNameTextBox";
            this.EditUserAccountNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditUserAccountNameTextBox.TabIndex = 14;
            // 
            // EditUserPasswordLabel
            // 
            this.EditUserPasswordLabel.AutoSize = true;
            this.EditUserPasswordLabel.Location = new System.Drawing.Point(111, 16);
            this.EditUserPasswordLabel.Name = "EditUserPasswordLabel";
            this.EditUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.EditUserPasswordLabel.TabIndex = 12;
            this.EditUserPasswordLabel.Text = "Password";
            // 
            // EditUserAccountNameLabel
            // 
            this.EditUserAccountNameLabel.AutoSize = true;
            this.EditUserAccountNameLabel.Location = new System.Drawing.Point(6, 16);
            this.EditUserAccountNameLabel.Name = "EditUserAccountNameLabel";
            this.EditUserAccountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.EditUserAccountNameLabel.TabIndex = 11;
            this.EditUserAccountNameLabel.Text = "Account Name";
            // 
            // EditUserPasswordTextBox
            // 
            this.EditUserPasswordTextBox.Location = new System.Drawing.Point(115, 32);
            this.EditUserPasswordTextBox.Name = "EditUserPasswordTextBox";
            this.EditUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditUserPasswordTextBox.TabIndex = 15;
            // 
            // AddUserGroupBox
            // 
            this.AddUserGroupBox.Controls.Add(this.AddUserButton);
            this.AddUserGroupBox.Controls.Add(this.AddUserAccountNameTextBox);
            this.AddUserGroupBox.Controls.Add(this.AddUserPasswordTextBox);
            this.AddUserGroupBox.Controls.Add(this.AddUserAccountNameLabel);
            this.AddUserGroupBox.Controls.Add(this.AddUserPasswordLabel);
            this.AddUserGroupBox.Location = new System.Drawing.Point(15, 49);
            this.AddUserGroupBox.Name = "AddUserGroupBox";
            this.AddUserGroupBox.Size = new System.Drawing.Size(226, 89);
            this.AddUserGroupBox.TabIndex = 6;
            this.AddUserGroupBox.TabStop = false;
            this.AddUserGroupBox.Text = "Add User";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(115, 58);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 23);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddUserAccountNameTextBox
            // 
            this.AddUserAccountNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.AddUserAccountNameTextBox.Name = "AddUserAccountNameTextBox";
            this.AddUserAccountNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUserAccountNameTextBox.TabIndex = 7;
            // 
            // AddUserPasswordTextBox
            // 
            this.AddUserPasswordTextBox.Location = new System.Drawing.Point(115, 32);
            this.AddUserPasswordTextBox.Name = "AddUserPasswordTextBox";
            this.AddUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUserPasswordTextBox.TabIndex = 8;
            // 
            // AddUserAccountNameLabel
            // 
            this.AddUserAccountNameLabel.AutoSize = true;
            this.AddUserAccountNameLabel.Location = new System.Drawing.Point(6, 16);
            this.AddUserAccountNameLabel.Name = "AddUserAccountNameLabel";
            this.AddUserAccountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.AddUserAccountNameLabel.TabIndex = 4;
            this.AddUserAccountNameLabel.Text = "Account Name";
            // 
            // AddUserPasswordLabel
            // 
            this.AddUserPasswordLabel.AutoSize = true;
            this.AddUserPasswordLabel.Location = new System.Drawing.Point(112, 16);
            this.AddUserPasswordLabel.Name = "AddUserPasswordLabel";
            this.AddUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.AddUserPasswordLabel.TabIndex = 5;
            this.AddUserPasswordLabel.Text = "Password";
            // 
            // ManageUsersLabel
            // 
            this.ManageUsersLabel.AutoSize = true;
            this.ManageUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageUsersLabel.Location = new System.Drawing.Point(12, 9);
            this.ManageUsersLabel.Name = "ManageUsersLabel";
            this.ManageUsersLabel.Size = new System.Drawing.Size(113, 20);
            this.ManageUsersLabel.TabIndex = 5;
            this.ManageUsersLabel.Text = "Manage Users";
            // 
            // ManagingUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 317);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ItemsTable);
            this.Controls.Add(this.EditUserGroupBox);
            this.Controls.Add(this.AddUserGroupBox);
            this.Controls.Add(this.ManageUsersLabel);
            this.Name = "ManagingUsersForm";
            this.Text = "ManagingUsersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagingUsersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).EndInit();
            this.EditUserGroupBox.ResumeLayout(false);
            this.EditUserGroupBox.PerformLayout();
            this.AddUserGroupBox.ResumeLayout(false);
            this.AddUserGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView ItemsTable;
        private System.Windows.Forms.GroupBox EditUserGroupBox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.TextBox EditUserAccountNameTextBox;
        private System.Windows.Forms.Label EditUserPasswordLabel;
        private System.Windows.Forms.Label EditUserAccountNameLabel;
        private System.Windows.Forms.TextBox EditUserPasswordTextBox;
        private System.Windows.Forms.GroupBox AddUserGroupBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox AddUserAccountNameTextBox;
        private System.Windows.Forms.TextBox AddUserPasswordTextBox;
        private System.Windows.Forms.Label AddUserAccountNameLabel;
        private System.Windows.Forms.Label AddUserPasswordLabel;
        private System.Windows.Forms.Label ManageUsersLabel;
    }
}