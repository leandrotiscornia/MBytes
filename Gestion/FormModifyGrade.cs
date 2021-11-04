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
    public partial class FormModifyGrade : Form
    {
        public string gradeName { get; set; }
        public int gradeId { get; set; }
        public FormModifyGrade(int gradeId, string gradeName)
        {
            InitializeComponent();
            this.gradeId = gradeId;
            this.gradeName = gradeName;
        }
        Func<DataGridViewRow, object[]> 
            getValues = dataGridRow => 
            new object[] {
            dataGridRow.Cells[0].Value,
            dataGridRow.Cells[1].Value,
            dataGridRow.Cells[2].Value};

        Func<DataGridViewRow, int> getSubjectId = subject => (int)subject.Cells["ID"].Value;
        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0) unassignSubject();
        }

        private void FormModifyGrade_Load(object sender, EventArgs e)
        {
            loadSubjects();
        }
        private void loadSubjects()
        {
            lblGradeName.Text += gradeName;
            DataTable gradeSubjects = SubjectController.listGradeSubjects(gradeId);
            DataTable restSubjects = SubjectController.listRestSubjects(gradeId);
            dgvGrade.Columns.Add("ID", "ID");
            dgvGrade.Columns.Add("Name", "Name");
            dgvGrade.Columns.Add("Description", "Description");

            dgvSubjects.Columns.Add("ID", "ID");
            dgvSubjects.Columns.Add("Name", "Name");
            dgvSubjects.Columns.Add("Description", "Description");

            foreach (DataRow gradeSubject in gradeSubjects.Rows)
                dgvGrade.Rows.Add(gradeSubject.ItemArray);
            foreach (DataRow restSubject in restSubjects.Rows)
                dgvSubjects.Rows.Add(restSubject.ItemArray);
            dgvSubjects.Columns["ID"].Visible = false;
            dgvGrade.Columns["ID"].Visible = false;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0) assignSubject();
        }
        private void assignSubject()
        {
            dgvGrade.Rows.Add(getValues(dgvSubjects.SelectedRows[0]));
            dgvSubjects.Rows.RemoveAt(dgvSubjects.SelectedRows[0].Index);
        }
        private void unassignSubject()
        {
            dgvSubjects.Rows.Add(getValues(dgvGrade.SelectedRows[0]));
            dgvGrade.Rows.RemoveAt(dgvGrade.SelectedRows[0].Index);
        }
        private void modifyGrade()
        {
            
            List<int> subjects = new List<int>();
            foreach (DataGridViewRow subject in dgvGrade.Rows)
                subjects.Add(getSubjectId(subject));
            GradeController.modifyGrade(gradeId, subjects);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyGrade();
            Close();
        }
    }
}
