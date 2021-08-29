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
    public partial class FormModifyGroup : Form
    {
        public int groupId { get; set; }
        public FormModifyGroup(int groupId)
        {
            this.groupId = groupId;
            InitializeComponent();
        }

        private void FormModifyGroup_Load(object sender, EventArgs e)
        {
            loadGroup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyGroup();
            Close();
        }
        private void loadGroup()
        {
            List<string> groupData = GroupController.getGroupData(groupId);
            tbGrade.Text = groupData[0];
            tbGroup.Text = groupData[1];
            cbShift.SelectedItem = groupData[2];
        }
        private void modifyGroup()
        {
            GroupController.modifyGroup(tbGroup.Text, cbShift.Text, groupId);
        }
        private void clearInscriptions()
        {
            GroupController.clearInscriptions(groupId);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInscriptions();
            Close();
        }
    }
}
