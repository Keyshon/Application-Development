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
    public partial class AuthorizationForm : Form
    {
        public ManagingMenuForm mmf;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            mmf = new ManagingMenuForm(this);
            mmf.Visible = true;
        }
    }
}
