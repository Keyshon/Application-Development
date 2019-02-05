namespace FurnitureStoreSystem
{
    partial class ManagingItemsForm
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
            this.ManageItemsLabel = new System.Windows.Forms.Label();
            this.AddItemGroupBox = new System.Windows.Forms.GroupBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AddItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddItemNameTextBox = new System.Windows.Forms.TextBox();
            this.AddItemQuantityLabel = new System.Windows.Forms.Label();
            this.AddItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddItemNameLabel = new System.Windows.Forms.Label();
            this.AddItemPriceLabel = new System.Windows.Forms.Label();
            this.EditItemGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.EditItemNameTextBox = new System.Windows.Forms.TextBox();
            this.EditItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.EditItemPriceLabel = new System.Windows.Forms.Label();
            this.EditItemNameLabel = new System.Windows.Forms.Label();
            this.EditItemQuantityLabel = new System.Windows.Forms.Label();
            this.EditItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemsTable = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddItemGroupBox.SuspendLayout();
            this.EditItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageItemsLabel
            // 
            this.ManageItemsLabel.AutoSize = true;
            this.ManageItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageItemsLabel.Location = new System.Drawing.Point(12, 9);
            this.ManageItemsLabel.Name = "ManageItemsLabel";
            this.ManageItemsLabel.Size = new System.Drawing.Size(111, 20);
            this.ManageItemsLabel.TabIndex = 0;
            this.ManageItemsLabel.Text = "Manage Items";
            // 
            // AddItemGroupBox
            // 
            this.AddItemGroupBox.Controls.Add(this.AddItemButton);
            this.AddItemGroupBox.Controls.Add(this.AddItemQuantityTextBox);
            this.AddItemGroupBox.Controls.Add(this.AddItemNameTextBox);
            this.AddItemGroupBox.Controls.Add(this.AddItemQuantityLabel);
            this.AddItemGroupBox.Controls.Add(this.AddItemPriceTextBox);
            this.AddItemGroupBox.Controls.Add(this.AddItemNameLabel);
            this.AddItemGroupBox.Controls.Add(this.AddItemPriceLabel);
            this.AddItemGroupBox.Location = new System.Drawing.Point(15, 49);
            this.AddItemGroupBox.Name = "AddItemGroupBox";
            this.AddItemGroupBox.Size = new System.Drawing.Size(331, 89);
            this.AddItemGroupBox.TabIndex = 1;
            this.AddItemGroupBox.TabStop = false;
            this.AddItemGroupBox.Text = "Add Item";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(222, 58);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(99, 23);
            this.AddItemButton.TabIndex = 4;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // AddItemQuantityTextBox
            // 
            this.AddItemQuantityTextBox.Location = new System.Drawing.Point(221, 32);
            this.AddItemQuantityTextBox.Name = "AddItemQuantityTextBox";
            this.AddItemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddItemQuantityTextBox.TabIndex = 9;
            // 
            // AddItemNameTextBox
            // 
            this.AddItemNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.AddItemNameTextBox.Name = "AddItemNameTextBox";
            this.AddItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddItemNameTextBox.TabIndex = 7;
            // 
            // AddItemQuantityLabel
            // 
            this.AddItemQuantityLabel.AutoSize = true;
            this.AddItemQuantityLabel.Location = new System.Drawing.Point(219, 16);
            this.AddItemQuantityLabel.Name = "AddItemQuantityLabel";
            this.AddItemQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.AddItemQuantityLabel.TabIndex = 6;
            this.AddItemQuantityLabel.Text = "Quantity";
            // 
            // AddItemPriceTextBox
            // 
            this.AddItemPriceTextBox.Location = new System.Drawing.Point(115, 32);
            this.AddItemPriceTextBox.Name = "AddItemPriceTextBox";
            this.AddItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddItemPriceTextBox.TabIndex = 8;
            // 
            // AddItemNameLabel
            // 
            this.AddItemNameLabel.AutoSize = true;
            this.AddItemNameLabel.Location = new System.Drawing.Point(6, 16);
            this.AddItemNameLabel.Name = "AddItemNameLabel";
            this.AddItemNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AddItemNameLabel.TabIndex = 4;
            this.AddItemNameLabel.Text = "Name";
            // 
            // AddItemPriceLabel
            // 
            this.AddItemPriceLabel.AutoSize = true;
            this.AddItemPriceLabel.Location = new System.Drawing.Point(112, 16);
            this.AddItemPriceLabel.Name = "AddItemPriceLabel";
            this.AddItemPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.AddItemPriceLabel.TabIndex = 5;
            this.AddItemPriceLabel.Text = "Price";
            // 
            // EditItemGroupBox
            // 
            this.EditItemGroupBox.Controls.Add(this.DeleteItemButton);
            this.EditItemGroupBox.Controls.Add(this.EditItemButton);
            this.EditItemGroupBox.Controls.Add(this.EditItemNameTextBox);
            this.EditItemGroupBox.Controls.Add(this.EditItemQuantityTextBox);
            this.EditItemGroupBox.Controls.Add(this.EditItemPriceLabel);
            this.EditItemGroupBox.Controls.Add(this.EditItemNameLabel);
            this.EditItemGroupBox.Controls.Add(this.EditItemQuantityLabel);
            this.EditItemGroupBox.Controls.Add(this.EditItemPriceTextBox);
            this.EditItemGroupBox.Location = new System.Drawing.Point(16, 155);
            this.EditItemGroupBox.Name = "EditItemGroupBox";
            this.EditItemGroupBox.Size = new System.Drawing.Size(330, 118);
            this.EditItemGroupBox.TabIndex = 2;
            this.EditItemGroupBox.TabStop = false;
            this.EditItemGroupBox.Text = "Edit Item";
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(221, 87);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(99, 23);
            this.DeleteItemButton.TabIndex = 17;
            this.DeleteItemButton.Text = "Delete";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // EditItemButton
            // 
            this.EditItemButton.Location = new System.Drawing.Point(220, 58);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(100, 23);
            this.EditItemButton.TabIndex = 10;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // EditItemNameTextBox
            // 
            this.EditItemNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.EditItemNameTextBox.Name = "EditItemNameTextBox";
            this.EditItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditItemNameTextBox.TabIndex = 14;
            // 
            // EditItemQuantityTextBox
            // 
            this.EditItemQuantityTextBox.Location = new System.Drawing.Point(221, 32);
            this.EditItemQuantityTextBox.Name = "EditItemQuantityTextBox";
            this.EditItemQuantityTextBox.Size = new System.Drawing.Size(99, 20);
            this.EditItemQuantityTextBox.TabIndex = 16;
            // 
            // EditItemPriceLabel
            // 
            this.EditItemPriceLabel.AutoSize = true;
            this.EditItemPriceLabel.Location = new System.Drawing.Point(111, 16);
            this.EditItemPriceLabel.Name = "EditItemPriceLabel";
            this.EditItemPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.EditItemPriceLabel.TabIndex = 12;
            this.EditItemPriceLabel.Text = "Price";
            // 
            // EditItemNameLabel
            // 
            this.EditItemNameLabel.AutoSize = true;
            this.EditItemNameLabel.Location = new System.Drawing.Point(6, 16);
            this.EditItemNameLabel.Name = "EditItemNameLabel";
            this.EditItemNameLabel.Size = new System.Drawing.Size(35, 13);
            this.EditItemNameLabel.TabIndex = 11;
            this.EditItemNameLabel.Text = "Name";
            // 
            // EditItemQuantityLabel
            // 
            this.EditItemQuantityLabel.AutoSize = true;
            this.EditItemQuantityLabel.Location = new System.Drawing.Point(218, 16);
            this.EditItemQuantityLabel.Name = "EditItemQuantityLabel";
            this.EditItemQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.EditItemQuantityLabel.TabIndex = 13;
            this.EditItemQuantityLabel.Text = "Quantity";
            // 
            // EditItemPriceTextBox
            // 
            this.EditItemPriceTextBox.Location = new System.Drawing.Point(115, 32);
            this.EditItemPriceTextBox.Name = "EditItemPriceTextBox";
            this.EditItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditItemPriceTextBox.TabIndex = 15;
            // 
            // ItemsTable
            // 
            this.ItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsTable.Location = new System.Drawing.Point(352, 49);
            this.ItemsTable.Name = "ItemsTable";
            this.ItemsTable.Size = new System.Drawing.Size(274, 253);
            this.ItemsTable.TabIndex = 3;
            this.ItemsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsTable_CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 279);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManagingItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 315);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ItemsTable);
            this.Controls.Add(this.EditItemGroupBox);
            this.Controls.Add(this.AddItemGroupBox);
            this.Controls.Add(this.ManageItemsLabel);
            this.Name = "ManagingItemsForm";
            this.Text = "Manage Items";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagingItemsForm_FormClosed);
            this.AddItemGroupBox.ResumeLayout(false);
            this.AddItemGroupBox.PerformLayout();
            this.EditItemGroupBox.ResumeLayout(false);
            this.EditItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageItemsLabel;
        private System.Windows.Forms.GroupBox AddItemGroupBox;
        private System.Windows.Forms.GroupBox EditItemGroupBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox AddItemQuantityTextBox;
        private System.Windows.Forms.TextBox AddItemNameTextBox;
        private System.Windows.Forms.Label AddItemQuantityLabel;
        private System.Windows.Forms.TextBox AddItemPriceTextBox;
        private System.Windows.Forms.Label AddItemNameLabel;
        private System.Windows.Forms.Label AddItemPriceLabel;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.TextBox EditItemNameTextBox;
        private System.Windows.Forms.TextBox EditItemQuantityTextBox;
        private System.Windows.Forms.Label EditItemPriceLabel;
        private System.Windows.Forms.Label EditItemNameLabel;
        private System.Windows.Forms.Label EditItemQuantityLabel;
        private System.Windows.Forms.TextBox EditItemPriceTextBox;
        private System.Windows.Forms.DataGridView ItemsTable;
        private System.Windows.Forms.Button BackButton;
    }
}