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
    public partial class FormRegisterCourse : Form
    {
        public FormRegisterCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerCourse();
            Close();
        }

        private void registerCourse()
        {
            CourseController.insertCourse(tbName.Text, Convert.ToInt32(nudGrades.Value));
        }

     
    }
}
