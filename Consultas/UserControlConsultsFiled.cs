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
    public partial class UserControlConsultationsFiled : UserControl
    {

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user selects an item in the ListView")]
        public event EventHandler SelectedIndexChanged;

        public int consultId { get; set; }
        public string topic { get; set; }

        public UserControlConsultationsFiled()
        {
            InitializeComponent();
        }
        
     
        private void lvFiledConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFiledConsults.SelectedIndices.Count > 0)
            {
                this.consultId = Int32.Parse(lvFiledConsults.SelectedItems[0].Text);
                this.topic = lvFiledConsults.SelectedItems[0].SubItems[2].Text;
            }
            SelectedIndexChanged?.Invoke(this, e);
        }

        public void loadConsults()
        {
            DataTable consultsTable = new DataTable();
            consultsTable = ControllerConsultation.getConsultationsDone(Session.userId);
            ListViewItem item;
            lvFiledConsults.Items.Clear();
            foreach (DataRow consult in consultsTable.Rows)
            {
                if (consult[4].ToString() == "Filed")
                {
                    item = new ListViewItem(consult[0].ToString());
                    item.SubItems.Add(consult[1].ToString() + " " + consult[2].ToString());
                    item.SubItems.Add(consult[3].ToString());
                    item.SubItems.Add(consult[4].ToString());
                    lvFiledConsults.Items.Add(item);
                }
            }
        }

        private void UserControlConsultsFiled_Load(object sender, EventArgs e)
        {
            loadConsults();
        }
    }
}
