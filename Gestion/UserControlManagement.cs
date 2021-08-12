using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Gestion
{
    public partial class UserControlManagement: UserControl
    {
        public UserControlManagement()
        {
            InitializeComponent();
        }

        private void UserControlManagement_Load(object sender, EventArgs e)
        {
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedIndices.Count > 0)
                loadData();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            if(lvData.SelectedItems[0].Text == "Teachers")
            {
                dgvData.DataSource = PersonController.listTeacher();
            } else if (lvData.SelectedItems[0].Text == "Students")
            {
                dgvData.DataSource = PersonController.listStudent();
            } else if (lvData.SelectedItems[0].Text == "Courses")
            {

            } else if (lvData.SelectedItems[0].Text == "Groups")
            {

            } else if (lvData.SelectedItems[0].Text == "Subjects")
            {

            }
        }
        private void loadFilter()
        {

        }
    }
}
