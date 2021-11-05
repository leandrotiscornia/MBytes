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
    public partial class FormRegisterGroup : Form
    {
        private List<int> _gradesId;
        public FormRegisterGroup()
        {
            InitializeComponent();
        }
        
        private void FormRegisterGroup_Load(object sender, EventArgs e)
        {
            loadGrades();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cbGrades.SelectedItem != null && tbGroup.Text != null && cbShift.SelectedItem != null)
                registerGroup();
            else MessageBox.Show("Error");
            Close();
        }
        private void loadGrades()
        {
            _gradesId = new List<int>();
            DataTable grades = GradeController.listGradeNames();
            foreach (DataRow grade in grades.Rows)
            {
                cbGrades.Items.Add(grade[1]);
                _gradesId.Add((int)grade[0]);
            }
        }
        private void registerGroup()
        {
            GroupController.insertGroup(tbGroup.Text, cbShift.SelectedItem.ToString(), _gradesId[cbGrades.SelectedIndex]);
        }


    }
}
