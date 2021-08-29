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
    public partial class FormRegisterSubject : Form
    {
        public FormRegisterSubject()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerSubjects();
            Close();
        }

        private void registerSubjects()
        {
            SubjectController.insertSubject(tbName.Text, tbDescription.Text);
        }

    }
}
