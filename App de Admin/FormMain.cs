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
using Autorizacion;
using System.Windows.Forms;
using System.Threading;

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
            if (lvNavigation.SelectedIndices.Count > 0)
            {
                clearUserControls();
                navigate();
            }
                
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
        private void loadManagement()
        {
            UserControlManagement management = new UserControlManagement();
            management.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(management);
        }
        private void loadAuthorization()
        {
            UserControlAuthorization authorization = new UserControlAuthorization();
            authorization.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(authorization);
        }
        private void loadChat()
        {

        }
        private void navigate()
        {
            switch (lvNavigation.SelectedItems[0].Text)
            {
                case "Management":
                    loadManagement();
                    break;
                case "Authorization":
                    loadAuthorization();
                    break;
                case "Chat":
                    break;
                default:
                    break;
            }
        }
        private void clearUserControls()
        {
            foreach (UserControl userControl in pnlFunction.Controls)
                if (userControl != null) userControl.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    Controls.Clear();
                    InitializeComponent();
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    Controls.Clear();
                    InitializeComponent();
                    break;
                default:
                    break;
            }
        }
    }
}
