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
    public partial class FormModifySubject : Form
    {
        public int subjectId { get; set; }
        public FormModifySubject(int subjectId)
        {
            InitializeComponent();
            this.subjectId = subjectId;
        }
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifySubject();
            Close();
        }

        private void modifySubject()
        {
            SubjectController.modifySubject(subjectId, tbName.Text, tbDescription.Text);
        }
        private void loadSubjectData()
        {
            List<string> subjectData = SubjectController.getSubjectData(subjectId);
            tbName.Text = subjectData[0];
            tbDescription.Text = subjectData[1];
        }
        private void FormModifySubject_Load(object sender, EventArgs e)
        {
            loadSubjectData();
        }
    }
}
