using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;

namespace App_De_Alumno
{
    public partial class UserControlStudentInscriptions : UserControl
    {
        public UserControlStudentInscriptions()
        {
            InitializeComponent();
        }
        Func<DataGridViewRow, int> getId = dgvr => (int)dgvr.Cells["ID"].Value;
        private void UserControlStudentInscriptions_Load(object sender, EventArgs e)
        {
            loadGroups();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            sendRequests();
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
                loadSubjects();
        }
        private void loadGroups()
        {
            DataTable groups = GroupController.listGroups();
            dgvGroups.DataSource = groups;
            if (dgvGroups.Columns["ID"] != null) dgvGroups.Columns["ID"].Visible = false;
        }
        private void loadSubjects()
        {
            DataTable subjects = GroupController.listSubjectsByGroup((int)dgvGroups["ID", dgvGroups.CurrentCell.RowIndex].Value);
            dgvSubjects.DataSource = subjects;
            if (dgvSubjects.Columns["ID"] != null) dgvSubjects.Columns["ID"].Visible = false;
        }
        private void sendRequests()
        {
            List<int> subjects = new List<int>();
            foreach (DataGridViewRow subject in dgvSubjects.SelectedRows)
            {
                subjects.Add(getId(subject));
            }
            GroupController.requestInscription(Session.ci, getId(dgvGroups.SelectedRows[0]), subjects);
        }
    }
}
