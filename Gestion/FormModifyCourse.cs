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
    public partial class FormModifyCourse : Form
    {
        public int courseId { get; set; }
        public string oldCourseName { get; set; }
        public FormModifyCourse(int courseId, string oldCourseName)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.oldCourseName = oldCourseName;
        }

        private void FormModifyCourse_Load(object sender, EventArgs e)
        {
            loadCourseData();
        }
        private void loadCourseData()
        {
            string[] data = CourseController.getCourseInfo(courseId);
            tbName.Text = data[0];
            nudGrades.Value = decimal.Parse(data[1]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            CourseController.modifyCourse(courseId, tbName.Text, Convert.ToInt32(nudGrades.Value), oldCourseName);
            Close();
        }
    }
}
