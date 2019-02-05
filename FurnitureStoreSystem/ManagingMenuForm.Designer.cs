namespace FurnitureStoreSystem
{
    partial class ManagingMenuForm
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
            this.ManagingMenuLabel = new System.Windows.Forms.Label();
            this.ManageUsersButton = new System.Windows.Forms.Button();
            this.ManageItemsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagingMenuLabel
            // 
            this.ManagingMenuLabel.AutoSize = true;
            this.ManagingMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagingMenuLabel.Location = new System.Drawing.Point(12, 9);
            this.ManagingMenuLabel.Name = "ManagingMenuLabel";
            this.ManagingMenuLabel.Size = new System.Drawing.Size(123, 20);
            this.ManagingMenuLabel.TabIndex = 0;
            this.ManagingMenuLabel.Text = "Managing Menu";
            // 
            // ManageUsersButton
            // 
            this.ManageUsersButton.Location = new System.Drawing.Point(16, 71);
            this.ManageUsersButton.Name = "ManageUsersButton";
            this.ManageUsersButton.Size = new System.Drawing.Size(119, 23);
            this.ManageUsersButton.TabIndex = 1;
            this.ManageUsersButton.Text = "Manage Users";
            this.ManageUsersButton.UseVisualStyleBackColor = true;
            this.ManageUsersButton.Click += new System.EventHandler(this.ManageUsersButton_Click);
            // 
            // ManageItemsButton
            // 
            this.ManageItemsButton.Location = new System.Drawing.Point(16, 42);
            this.ManageItemsButton.Name = "ManageItemsButton";
            this.ManageItemsButton.Size = new System.Drawing.Size(119, 23);
            this.ManageItemsButton.TabIndex = 2;
            this.ManageItemsButton.Text = "Manage Items";
            this.ManageItemsButton.UseVisualStyleBackColor = true;
            this.ManageItemsButton.Click += new System.EventHandler(this.ManageItemsButton_Click);
            // 
            // ManagingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 112);
            this.Controls.Add(this.ManageItemsButton);
            this.Controls.Add(this.ManageUsersButton);
            this.Controls.Add(this.ManagingMenuLabel);
            this.Name = "ManagingMenuForm";
            this.Text = "Managing Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagingMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManagingMenuLabel;
        private System.Windows.Forms.Button ManageUsersButton;
        private System.Windows.Forms.Button ManageItemsButton;
    }
}