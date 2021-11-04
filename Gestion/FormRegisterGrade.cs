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
    public partial class FormRegisterGrade : Form
    {
        public List<int> courseId { get; set; }
        
        public FormRegisterGrade()
        {
            InitializeComponent();
        }
        Func<DataGridViewRow, object[]>
            getValues = dataGridRow =>
            new object[] {
            dataGridRow.Cells[0].Value,
            dataGridRow.Cells[1].Value,
            dataGridRow.Cells[2].Value};

        Func<DataGridViewRow, int> getSubjectId = subject => (int)subject.Cells["ID"].Value;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRegisterGrade_Load(object sender, EventArgs e)
        {
            loadSubjects();
            loadCourses();
        }
        private void loadCourses()
        {
            courseId = new List<int>();
            DataTable courses = CourseController.listCourses();
            foreach(DataRow course in courses.Rows)
            {
                courseId.Add((int)course[0]);
                cbCourses.Items.Add(course[1]);
            }
        }
        private void loadSubjects()
        {
            DataTable restSubjects = SubjectController.listSubjects();
            dgvGrade.Columns.Add("ID", "ID");
            dgvGrade.Columns.Add("Name", "Name");
            dgvGrade.Columns.Add("Description", "Description");

            dgvSubjects.Columns.Add("ID", "ID");
            dgvSubjects.Columns.Add("Name", "Name");
            dgvSubjects.Columns.Add("Description", "Description");

            foreach (DataRow restSubject in restSubjects.Rows)
                dgvSubjects.Rows.Add(restSubject.ItemArray);
            dgvSubjects.Columns["ID"].Visible = false;
            dgvGrade.Columns["ID"].Visible = false;
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
        private void addGrade()
        {
            List<int> subjects = new List<int>();
            foreach (DataGridViewRow subject in dgvGrade.Rows)
                subjects.Add(getSubjectId(subject));
            GradeController.insertGrade(courseId[cbCourses.SelectedIndex],subjects);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCourses.SelectedItem != null)
                addGrade();
            Close();
        }
        
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0) assignSubject();
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if(dgvGrade.SelectedRows.Count > 0) unassignSubject();
        }

    }
}
