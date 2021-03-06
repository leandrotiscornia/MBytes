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

namespace App_de_Admin
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            DataBaseController.setDefaultConnection();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string message = checkLogin();
            if (message != "") 
                MessageBox.Show("" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                LogController.writeInLog("Log In", "Success", tbUser.Text);
                goToMain();
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMain()
        {
            DataBaseController.setConnection("administrator", "administrator", "3306");
            FormMain mainForm = new FormMain();
            mainForm.Show();
            Hide();
        }
        private string checkLogin()
        {
            try
            {
                string message = PersonController.login(tbUser.Text, tbPassword.Text, 0);
                return message;
            }
            catch (Exception ex)
            {
                LogController.writeInLog("Log In", "Failed", tbUser.Text);
                return ExceptionController.handleException(ex);
            }
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
