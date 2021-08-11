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
    public partial class UserControlConsultationsMade : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user selects an item in the ListView")]
        public event EventHandler SelectedIndexChanged;

        public int consultId { get; set; }
        public string topic { get; set; }


        public UserControlConsultationsMade()
        {
            InitializeComponent();
        }
       
        private void lvConsultsMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsMade.SelectedIndices.Count > 0)
            {
                consultId = Int32.Parse(lvConsultsMade.SelectedItems[0].Text);
                topic = lvConsultsMade.SelectedItems[0].SubItems[2].Text;
            }
            else
                consultId = 0;
                
            SelectedIndexChanged?.Invoke(this, e);
        }


        public void loadConsults()
        {
            DataTable consultsTable = new DataTable();
            consultsTable = ConsultationController.getConsultationsDone(Session.userId);
            ListViewItem item;
            lvConsultsMade.Items.Clear();
            foreach (DataRow consult in consultsTable.Rows)
            {
                if(consult[4].ToString() != "Filed")
                {
                item = new ListViewItem(consult[0].ToString());
                item.SubItems.Add(consult[1].ToString() + " " + consult[2].ToString());
                item.SubItems.Add(consult[3].ToString());
                item.SubItems.Add(consult[4].ToString());
                lvConsultsMade.Items.Add(item);
                }
            }
            
        }

        private void UserControlConsultsMade_Load(object sender, EventArgs e)
        {
            loadConsults();
        }
    }
}
