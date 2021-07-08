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
            string ci = tbCI.Text;
            string firstName = tbFirstName.Text;
            string secondName = tbSecondName.Text;
            string firstSurname = tbFirstSurname.Text;
            string secondSurname = tbSecondSurname.Text;
            string[] personData = new string[] { ci,firstName, secondName,firstSurname,secondSurname};
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            if (password == tbConfirmPassword.Text) {
                if (cbRole.SelectedItem.ToString() == "Student")
                {
                    ControllerInsertStudent.insertStudent(personData, userName, password);
                } else if (cbRole.SelectedItem.ToString() =="Teacher")
                    ControllerInsertTeacher.insertTeacher(personData,userName, password);
            } else
                MessageBox.Show("Passwords does not match","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void FormRegisterPerson_Load(object sender, EventArgs e)
        {

        }

        private void pnlUserRoles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSecondSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
