﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace App_De_Alumo
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

       
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string message = checkLogin();
            if (message != "") //TODO Check if user is student
                MessageBox.Show("" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                goToMain();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegisterPerson registerForm = new FormRegisterPerson();
            registerForm.Show();
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMain()
        {
            FormMain mainForm = new FormMain();
            mainForm.Show();
            this.Hide();
        }
        private string checkLogin()
        {
            ControllerLogIn login = new ControllerLogIn(tbUser.Text, tbPassword.Text);
            string message = login.login();
            return message;
        }
    }
}
