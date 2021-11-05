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
            switch (lvData.SelectedIndices[0])
            {
                case 0:
                    PersonController.deleteTeacher(getDataId(dgvData));
                    loadData();
                    break;
                case 1:
                    PersonController.deleteStudent(getDataId(dgvData));
                    loadData();
                    break;
                case 2:
                    CourseController.deleteCourse(getDataId(dgvData));
                    loadData();
                    break;
                case 3:
                    GradeController.deleteGrade(getDataId(dgvData));
                    loadData();
                    break;
                case 4:
                    GroupController.deleteGroup(getDataId(dgvData));
                    loadData();
                    break;
                case 5:
                    SubjectController.deleteSubject(getDataId(dgvData));
                    loadData();
                    break;
                default:
                    break;
            }
        }
        private void loadData()
        {
            switch (lvData.SelectedIndices[0])
            {
                case 0:
                    dgvData.DataSource = PersonController.listTeacher();
                    break;
                case 1:
                    dgvData.DataSource = PersonController.listStudent();
                    break;
                case 2:
                    dgvData.DataSource = CourseController.listCourses();
                    break;
                case 3:
                    dgvData.DataSource = GradeController.listGrades();
                    break;
                case 4:
                    dgvData.DataSource = SubjectController.listSubjects();
                    break;
                case 5:
                    dgvData.DataSource = GroupController.listGroupsWithStudents();
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
            switch (lvData.SelectedIndices[0])
            {
                case 0:
                    FormRegisterTeacher registerTeacher = new FormRegisterTeacher();
                    registerTeacher.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerTeacher.Show();
                    break;
                case 1:
                    FormRegisterStudent registerStudent = new FormRegisterStudent();
                    registerStudent.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerStudent.Show();
                    break;
                case 2:
                    FormRegisterCourse registerCourse = new FormRegisterCourse();
                    registerCourse.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerCourse.Show();
                    break;
                case 3:
                    FormRegisterGrade registerGrade = new FormRegisterGrade();
                    registerGrade.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerGrade.Show();
                    break;
               
                case 4:
                    FormRegisterSubject registerSubject = new FormRegisterSubject();
                    registerSubject.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerSubject.Show();
                    break;
                case 5:
                    FormRegisterGroup registerGroup = new FormRegisterGroup();
                    registerGroup.FormClosing += new FormClosingEventHandler(Form_Closing);
                    registerGroup.Show();
                    break;
                default:
                    break;
            }
        }
        private void modify()
        {
            switch (lvData.SelectedIndices[0])
            {
                case 0:
                    FormModifyTeacher modifyTeacher = new FormModifyTeacher(getDataId(dgvData));
                    modifyTeacher.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyTeacher.Show();
                    break;
                case 1:
                    FormModifyStudent modifyStudent = new FormModifyStudent(getDataId(dgvData));
                    modifyStudent.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyStudent.Show();
                    break;
                case 2:
                    FormModifyCourse modifyCourse = new FormModifyCourse(getDataId(dgvData), getDataName(dgvData));
                    modifyCourse.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyCourse.Show();
                    break;
                case 3:
                    FormModifyGrade modifyGrade = new FormModifyGrade(getDataId(dgvData), getDataName(dgvData));
                    modifyGrade.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyGrade.Show();
                    break;
                
                case 4:
                    FormModifySubject modifySubject = new FormModifySubject(getDataId(dgvData));
                    modifySubject.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifySubject.Show();
                    break;
                case 5:
                    FormModifyGroup modifyGroup = new FormModifyGroup(getDataId(dgvData));
                    modifyGroup.FormClosing += new FormClosingEventHandler(Form_Closing);
                    modifyGroup.Show();
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
