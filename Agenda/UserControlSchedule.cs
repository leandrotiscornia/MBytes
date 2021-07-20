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


namespace Agenda
{
    public partial class UserControlSchedule : UserControl
    {
        private int _consultId;
        private string _topic;
        private string _state;
        public UserControlSchedule()
        {
            InitializeComponent();
        }

        private void UserControlSchedule_Load(object sender, EventArgs e)
        {
            loadConsults();
        }

        private void lvConsultsMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsMade.SelectedIndices.Count > 0)
            {
                this._consultId = Int32.Parse(lvConsultsMade.SelectedItems[0].Text);
                this._topic = lvConsultsMade.SelectedItems[0].SubItems[2].Text;
                this._state = "Made";
            }
            else
                this._consultId = 0;
        }

        private void lvConsultsAnswered_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsAnswered.SelectedIndices.Count > 0)
            {
                this._consultId = Int32.Parse(lvConsultsAnswered.SelectedItems[0].Text);
                this._topic = lvConsultsAnswered.SelectedItems[0].SubItems[2].Text;
                this._state = "Answered";
            }
            else
                this._consultId = 0;
        }

        private void lvConsultsReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsReceived.SelectedIndices.Count > 0)
            {
                this._consultId = Int32.Parse(lvConsultsReceived.SelectedItems[0].Text);
                this._topic = lvConsultsReceived.SelectedItems[0].SubItems[2].Text;
                this._state = "Received";
            }
            else
                this._consultId = 0;
        }

        private void lvConsultsFiled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultsFiled.SelectedIndices.Count > 0)
            {
                this._consultId = Int32.Parse(lvConsultsFiled.SelectedItems[0].Text);
                this._topic = lvConsultsFiled.SelectedItems[0].SubItems[2].Text;
                this._state = "Filed";
            }   
            else
                this._consultId = 0;
        }
        private void loadConsults()
        {
            DataTable consults = new DataTable();
            consults = ControllerGetConsults.getConsultsReceived(Session.userId);
            ListViewItem item;
            clearLists();
            foreach (DataRow consult in consults.Rows)
            {
                item = new ListViewItem(consult[0].ToString());
                item.SubItems.Add(consult[1].ToString() + " " + consult[2].ToString());
                item.SubItems.Add(consult[3].ToString());
                switch (consult[4].ToString())
                {
                    case "Done":
                        lvConsultsMade.Items.Add(item);
                        break;
                    case "Answered":
                        lvConsultsAnswered.Items.Add(item);
                        break;
                    case "Received":
                        lvConsultsReceived.Items.Add(item);
                        break;
                    case "Filed":
                        lvConsultsFiled.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnOpenConsult_Click(object sender, EventArgs e)
        {
            if (_consultId == 0)
                MessageBox.Show("You need to select a consult to open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormOpenConsult openConsult = new FormOpenConsult(_consultId,_topic, _state);
                openConsult.Show();
            }
        }
        
        private void btnReload_Click(object sender, EventArgs e)
        {
            loadConsults();
        }
        private void clearLists()
        {
            lvConsultsMade.Items.Clear();
            lvConsultsReceived.Items.Clear();
            lvConsultsAnswered.Items.Clear();
            lvConsultsFiled.Items.Clear();
        }

        private void lvConsultsFiled_Enter(object sender, EventArgs e)
        {
            lvConsultsMade.SelectedIndices.Clear();
            lvConsultsReceived.SelectedIndices.Clear();
            lvConsultsAnswered.SelectedIndices.Clear();
        }

        private void lvConsultsReceived_Enter(object sender, EventArgs e)
        {
            lvConsultsMade.SelectedIndices.Clear();
            lvConsultsAnswered.SelectedIndices.Clear();
            lvConsultsFiled.SelectedIndices.Clear();
        }

        private void lvConsultsAnswered_Enter(object sender, EventArgs e)
        {
            lvConsultsFiled.SelectedIndices.Clear();
            lvConsultsMade.SelectedIndices.Clear();
            lvConsultsReceived.SelectedIndices.Clear();
        }

        private void lvConsultsMade_Enter(object sender, EventArgs e)
        {
            lvConsultsReceived.SelectedIndices.Clear();
            lvConsultsFiled.SelectedIndices.Clear();
            lvConsultsAnswered.SelectedIndices.Clear();
        }
    }
}
