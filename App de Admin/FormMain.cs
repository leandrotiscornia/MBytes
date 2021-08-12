using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Gestion;
using System.Windows.Forms;

namespace App_de_Admin
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void lvNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFunction.Controls.Clear();
            if (lvNavigation.SelectedIndices.Count > 0)
            {
                if (lvNavigation.SelectedItems[0].Text == "Management")
                {
                    UserControlManagement management = new UserControlManagement();
                    management.Dock = DockStyle.Fill;
                    pnlFunction.Controls.Add(management);
                }
                else if (lvNavigation.SelectedItems[0].Text == "Authorization")
                {

                }
                else if (lvNavigation.SelectedItems[0].Text == "Chat")
                {

                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
