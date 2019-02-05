using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// For DB purposes
using System.Data.SqlClient;
using System.Configuration;

namespace FurnitureStoreSystem
{
    public partial class ManagingMenuForm : Form
    {
        public AuthorizationForm af;
        public ManagingItemsForm mif;
        public ManagingUsersForm muf;

        public ManagingMenuForm()
        {
            InitializeComponent();
        }

        public ManagingMenuForm(AuthorizationForm af)
        {
            InitializeComponent();
            this.af = af;
        }

        private void ManageItemsButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            mif = new ManagingItemsForm(this);
            mif.Visible = true;
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            muf = new ManagingUsersForm(this);
            muf.Visible = true;
        }

        private void ManagingMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            af.Visible = true;
        }
    }
}
