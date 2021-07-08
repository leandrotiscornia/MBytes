using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Usuario
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {




        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ControllerLogIn login = new ControllerLogIn(tbUser.Text, tbPassword.Text);
            string message = login.login();
            if (message != "")
                MessageBox.Show("" + message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            { 
            FormMain mainForm = new FormMain();
            mainForm.Show();
            this.Hide();
            }

        }

   
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
