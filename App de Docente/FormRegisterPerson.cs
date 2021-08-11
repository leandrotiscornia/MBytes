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

namespace App_de_Docente
{
    public partial class FormRegisterPerson : Form
    {
        public FormRegisterPerson()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string textboxCheckresult = checkTextBoxes();
            string existenceCheckResult = checkUserExistence();

            if (textboxCheckresult != null)
                errorMessage(textboxCheckresult);
            else if (existenceCheckResult != null)
                errorMessage(existenceCheckResult);
            else
                registerUser();
        }
        private string checkUserExistence()
        {
            if (DataBaseController.checkExistence("users", "User_Login", tbUserName.Text) == tbUserName.Text)
                return "That user already exist";
            else if (DataBaseController.checkExistence("persons", "CI", tbCI.Text) == tbCI.Text)
                return "That person already exist";
            else
                return null;
        }
        private void registerUser()
        {
            string ci = tbCI.Text;
            string firstName = tbFirstName.Text;
            string secondName = tbSecondName.Text;
            string firstSurname = tbFirstSurname.Text;
            string secondSurname = tbSecondSurname.Text;
            string[] personData = new string[] { ci, firstName, secondName, firstSurname, secondSurname };

            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            if (password == tbConfirmPassword.Text)
            {
                PersonController.insertTeacher(personData, userName, password);
            }
            else
                errorMessage("Passwords does not match");
        }
       private string checkTextBoxes()
        {
            if (tbUserName.Text == "")
                return "You need an user name";
            else if (tbPassword.Text == "" || tbConfirmPassword.Text == "")
                return "You need a password";
            else if (tbCI.Text == "")
                return "You need a CI";
            else if (tbFirstName.Text == "")
                return "I'm sure you do have a name";
            else if (tbFirstSurname.Text == "")
                return "We don't admit people without surnames";
            else
                return null;
        }
        private void errorMessage(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
