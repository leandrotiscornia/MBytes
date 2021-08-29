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
    public partial class FormModifyTeacher : Form
    {
        public int teacherId { get; set; }
        public FormModifyTeacher(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
        }
        private void modifyData()
        {
            string[] data = new string[6];
            data[0] = teacherId.ToString();
            data[2] = tbFirstName.Text;
            data[3] = tbSecondName.Text;
            data[4] = tbFirstSurname.Text;
            data[5] = tbSecondSurname.Text;
            PersonController.modifyPerson(data);
        }

        private void loadData()
        {
            List<string> data = PersonController.getProfileData(teacherId);
            tbCI.Text = data[1];
            tbFirstName.Text = data[2];
            tbSecondName.Text = data[3];
            tbFirstSurname.Text = data[4];
            tbSecondSurname.Text = data[5];
        }
        private void FormModifyTeacher_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyData();
            Close();
        }
    }
}
