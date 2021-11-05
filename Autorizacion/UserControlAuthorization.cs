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

namespace Autorizacion
{
    public partial class UserControlAuthorization : UserControl
    {
        private DataTable inscriptions;
        public UserControlAuthorization()
        {
            InitializeComponent();
        }
        Func<DataGridViewRow, int> getSubjectId = dgvr => int.Parse((string)dgvr.Cells["Subject ID"].Value);
        Func<DataGridViewRow, int> getGroupId = dgvr => int.Parse((string)dgvr.Cells["Group ID"].Value);
        Func<DataGridViewRow, string> getCI = dgvr => (string)dgvr.Cells["CI"].Value;

        private void UserControlAuthorization_Load(object sender, EventArgs e)
        {
            loadRequests();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            revokeRequests();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            denyRequests();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            acceptRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelDeny();
        }
        private void loadRequests()
        {
            inscriptions = GroupController.listInscriptions();
            IEnumerable<DataRow> requestedQuery =
                from inscription
                in inscriptions.AsEnumerable()
                where inscription.Field<string>("Status") == "Requested"
                select inscription;
            DataTable requested = new DataTable();
            if (requestedQuery.Count() != 0) requested = requestedQuery.CopyToDataTable();
            dgvRequested.DataSource = requested;

            IEnumerable<DataRow> acceptedQuery =
                from inscription
                in inscriptions.AsEnumerable()
                where inscription.Field<string>("Status") == "Accepted"
                select inscription;
            DataTable accepted = new DataTable();
            if (acceptedQuery.Count() != 0) accepted = acceptedQuery.CopyToDataTable();
            dgvAccepted.DataSource = accepted;

            IEnumerable<DataRow> deniedQuery =
                from inscription
                in inscriptions.AsEnumerable()
                where inscription.Field<string>("Status") == "Denied"
                select inscription;
            DataTable denied = new DataTable();
            if (deniedQuery.Count() != 0) denied = deniedQuery.CopyToDataTable();
            dgvDenied.DataSource = denied;

            if (dgvRequested.Columns["Group ID"] != null) dgvRequested.Columns["Group ID"].Visible = false;
            if (dgvAccepted.Columns["Group ID"] != null) dgvAccepted.Columns["Group ID"].Visible = false;
            if (dgvDenied.Columns["Group ID"] != null) dgvDenied.Columns["Group ID"].Visible = false;
            if (dgvRequested.Columns["Subject ID"] != null) dgvRequested.Columns["Subject ID"].Visible = false;
            if (dgvAccepted.Columns["Subject ID"] != null) dgvAccepted.Columns["Subject ID"].Visible = false;
            if (dgvDenied.Columns["Subject ID"] != null) dgvDenied.Columns["Subject ID"].Visible = false;
        }
        private void acceptRequest()
        {
            foreach (DataGridViewRow request in dgvRequested.SelectedRows)
            {
                if ((string)request.Cells["Type"].Value == "Student")
                    GroupController.updateStudentRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Accepted");
                else
                    GroupController.updateTeacherRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Accepted");
            }
            loadRequests();

        }
        private void denyRequests()
        {
            foreach (DataGridViewRow request in dgvRequested.SelectedRows)
            {
                if ((string)request.Cells["Type"].Value == "Student")
                    GroupController.updateStudentRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Denied");
                else
                    GroupController.updateTeacherRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Denied");
            }
            loadRequests();
        }
        private void revokeRequests()
        {
            foreach (DataGridViewRow request in dgvAccepted.SelectedRows)
            {
                if ((string)request.Cells["Type"].Value == "Student")
                    GroupController.updateStudentRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Denied");
                else
                    GroupController.updateTeacherRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Denied");
            }
            loadRequests();
        }
        private void cancelDeny()
        {
            foreach (DataGridViewRow request in dgvDenied.SelectedRows)
            {
                if ((string)request.Cells["Type"].Value == "Student")
                    GroupController.updateStudentRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Requested");
                else
                    GroupController.updateTeacherRequestStatus(getCI(request), getGroupId(request), getSubjectId(request), "Requested");
            }
            loadRequests();
        }
    }
}
