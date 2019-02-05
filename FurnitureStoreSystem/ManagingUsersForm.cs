using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStoreSystem
{
    public partial class ManagingUsersForm : Form
    {
        public ManagingMenuForm mmf;

        public ManagingUsersForm()
        {
            InitializeComponent();
        }

        public ManagingUsersForm(ManagingMenuForm mmf)
        {
            InitializeComponent();
            this.mmf = mmf;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added!");
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited!");
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            mmf.Visible = true;
        }

        private void ManagingUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mmf.Visible = true;
        }
    }
}
