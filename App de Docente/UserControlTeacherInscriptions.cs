using System;
using Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Docente
{
    public partial class UserControlTeacherInscriptions : UserControl
    {
        Func<DataGridViewRow, int> getId = dgvr => (int)dgvr.Cells["ID"].Value;
        public UserControlTeacherInscriptions()
        {
            InitializeComponent();
        }

        private void UserControlTeacherInscriptions_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            loadGroups();
            loadInscriptions();
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            sendRequests();
            loadData();
        }

        
        private void loadGroups()
        {
            DataTable groups = GroupController.listGroups();
            dgvGroups.DataSource = groups;
            if (dgvGroups.Columns["ID"] != null) dgvGroups.Columns["ID"].Visible = false;
        }
        private void loadSubjects()
        {
            DataTable subjects = GroupController.listClassSubjects(getId(dgvGroups.SelectedRows[0]),Session.ci);
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
            GroupController.requestTeacherInscription(Session.ci, getId(dgvGroups.SelectedRows[0]), subjects);
            loadInscriptions();
            loadSubjects();
        }
        private void loadInscriptions()
        {
            DataTable inscriptions = GroupController.loadTeacherInscriptions(Session.ci);
            dgvPending.DataSource = inscriptions;
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
                loadSubjects();
        }
    }
}
