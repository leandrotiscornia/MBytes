using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;

namespace Gestion
{
    public partial class FormModifyStudent : Form
    {
        public int userId { get; set; }


        public FormModifyStudent(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyData();
            Close();
        }

        private void modifyData()
        {
            string[] data = new string[6];
            data[0] = userId.ToString();
            data[2] = tbFirstName.Text;
            data[3] = tbSecondName.Text;
            data[4] = tbFirstSurname.Text;
            data[5] = tbSecondSurname.Text;
            PersonController.modifyPerson(data);
        }

        private void loadData()
        {
            List<string> data = PersonController.getProfileData(userId);
            tbCI.Text = data[1];
            tbFirstName.Text = data[2];
            tbSecondName.Text = data[3];
            tbFirstSurname.Text = data[4];
            tbSecondSurname.Text = data[5];
        }

        private void FormModifyStudent_Shown(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
