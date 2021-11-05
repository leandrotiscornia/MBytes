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

namespace Gestion
{
    public partial class UserControlManagement : UserControl
    {
        public UserControlManagement()
        {
            InitializeComponent();
        }
        Func<DataGridView, int> getDataId = dataGrid => (int)dataGrid["ID", dataGrid.CurrentCell.RowIndex].Value;
        Func<DataGridView, string> getDataName = dataGrid => (string)dataGrid["Name", dataGrid.CurrentCell.RowIndex].Value;
        private void UserControlManagement_Load(object sender, EventArgs e)
        {
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedIndices.Count > 0) loadData();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedIndices.Count > 0)
                register();
            else
                MessageBox.Show("Error");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedIndices.Count > 0 && dgvData.CurrentRow != null)
                modify();
            else
                MessageBox.Show("Error");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedIndices.Count > 0 && dgvData.CurrentRow != null)
                deleteElement();
            else
                MessageBox.Show("Error");
        }
        private void deleteElement()
        {
            switch (lvData.SelectedItems[0].Text)
            {
                case "Teachers":
                    PersonController.deleteTeacher(getDataId(dgvData));
                    loadData();
                    break;
                case "Students":
                    PersonController.deleteStudent(getDataId(dgvData));
                    loadData();
                    break;
                case "Courses":
                    CourseController.deleteCourse(getDataId(dgvData));
                    loadData();
                    break;
                case "Grades":
                    GradeController.deleteGrade(getDataId(dgvData));
                    loadData();
                    break;
                case "Groups":
                    GroupController.deleteGroup(getDataId(dgvData));
                    loadData();
                    break;
                case "Subjects":
                    SubjectController.deleteSubject(getDataId(dgvData));
                    loadData();
                    break;
                default:
                    break;
            }
        }
        private void loadData()
        {
            switch (lvData.SelectedItems[0].Text)
            {
                case "Teachers":
                    dgvData.DataSource = PersonController.listTeacher();
                    break;
                case "Students":
                    dgvData.DataSource = PersonController.listStudent();
                    break;
                case "Courses":
                    dgvData.DataSource = CourseController.listCourses();
                    break;
                case "Grades":
                    dgvData.DataSource = GradeController.listGrades();
                    break;
                case "Groups":
                    dgvData.DataSource = GroupController.listGroupsWithStudents();
                    break;
                case "Subjects":
                    dgvData.DataSource = SubjectController.listSubjects();
                    break;
                default:
                    break;
            }
            if (dgvData.Columns["ID"] != null) dgvData.Columns["ID"].Visible = false;

        }
        private void loadFilter()
        {
            switch (lvData.SelectedItems[0].Text)
            {
                case "Teachers":

                    break;
                case "Students":

                    break;
                case "Courses":

                    break;
                case "Grades":

                    break;
                case "Groups":

                    break;
                case "Subjects":

                    break;
                default:
                    break;
            }
        }
        private void register()
        {
            switch (lvData.SelectedItems[0].Text)
            {
                case "Teachers":
                    FormRegisterTeacher registerTeacher = new FormRegisterTeacher();
                    registerTeacher.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerTeacher.Show();
                    break;
                case "Students":
                    FormRegisterStudent registerStudent = new FormRegisterStudent();
                    registerStudent.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerStudent.Show();
                    break;
                case "Courses":
                    FormRegisterCourse registerCourse = new FormRegisterCourse();
                    registerCourse.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerCourse.Show();
                    break;
                case "Grades":
                    FormRegisterGrade registerGrade = new FormRegisterGrade();
                    registerGrade.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerGrade.Show();
                    break;
                case "Groups":
                    FormRegisterGroup registerGroup = new FormRegisterGroup();
                    registerGroup.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerGroup.Show();
                    break;
                case "Subjects":
                    FormRegisterSubject registerSubject = new FormRegisterSubject();
                    registerSubject.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerSubject.Show();
                    break;
                default:
                    break;
            }
        }
        private void modify()
        {
            switch (lvData.SelectedItems[0].Text)
            {
                case "Teachers":
                    FormModifyTeacher modifyTeacher = new FormModifyTeacher(getDataId(dgvData));
                    modifyTeacher.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyTeacher.Show();
                    break;
                case "Students":
                    FormModifyStudent modifyStudent = new FormModifyStudent(getDataId(dgvData));
                    modifyStudent.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyStudent.Show();
                    break;
                case "Courses":
                    FormModifyCourse modifyCourse = new FormModifyCourse(getDataId(dgvData), getDataName(dgvData));
                    modifyCourse.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyCourse.Show();
                    break;
                case "Grades":
                    FormModifyGrade modifyGrade = new FormModifyGrade(getDataId(dgvData), getDataName(dgvData));
                    modifyGrade.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyGrade.Show();
                    break;
                case "Groups":
                    FormModifyGroup modifyGroup = new FormModifyGroup(getDataId(dgvData));
                    modifyGroup.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyGroup.Show(); 
                    break;
                case "Subjects":
                    FormModifySubject modifySubject = new FormModifySubject(getDataId(dgvData));
                    modifySubject.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifySubject.Show();
                    break;
                default:
                    break;
            }
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            loadData();
        }
    }
}
