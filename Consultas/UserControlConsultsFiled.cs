using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Consultas
{
    public partial class UserControlConsultsFiled : UserControl
    {
        public int consultId { get; set; }

        public UserControlConsultsFiled()
        {
            InitializeComponent();
        }
        
        private void UserControlConsultsFiled_Load(object sender, EventArgs e)
        {
            DataTable consultsTable = new DataTable();
            consultsTable = ControllerGetConsults.getConsultsDone(Session.userId);
            ListViewItem item;

            foreach (DataRow consult in consultsTable.Rows)
            {
                if(consult[4].ToString() == "Filed")
                { 
                item = new ListViewItem("ID", consult[0].ToString());
                item.SubItems.Add(consult[1].ToString() + " " + consult[2].ToString());
                item.SubItems.Add(consult[3].ToString());
                lvFiledConsults.Items.Add(item);
                }
            }

        }
        private void lvFiledConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFiledConsults.SelectedIndices.Count > 0)
                this.consultId = Int32.Parse(lvFiledConsults.SelectedItems[0].Text);
        }
    }
}
