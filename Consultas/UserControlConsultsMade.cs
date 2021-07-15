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
    public partial class UserControlConsultsMade : UserControl
    {
        public int consultId { get; set; }
        public UserControlConsultsMade()
        {
            InitializeComponent();
        }
        private void UserControlConsultsMade_Load(object sender, EventArgs e)
        {
            DataTable consultsTable = new DataTable();
            consultsTable = ControllerGetConsults.getConsultsDone(Session.userId);
            ListViewItem item;

            foreach (DataRow consult in consultsTable.Rows)
            {
                if(consult[4].ToString() != "Filed")
                {
                    item = new ListViewItem("ID", consult[0].ToString());
                    item.SubItems.Add(consult[1].ToString() + " " + consult[2].ToString());
                    item.SubItems.Add(consult[3].ToString());
                    item.SubItems.Add(consult[4].ToString());
                    lvConsultsMade.Items.Add(item);
                }
                
            }
            
        }
        private void lvConsultsMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsMade.SelectedIndices.Count > 0)
                this.consultId = Int32.Parse(lvConsultsMade.Items[0].Text);
        }
    }
}
