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
    public partial class UserControlEditConsult : UserControl
    {
        public int consultId { get; set; }
        public string topic { get; set; }

        public UserControlEditConsult(int consultId)
        {
            this.consultId = consultId;
        }

        public UserControlEditConsult()
        {
            InitializeComponent();
        }
        private void UserControlEditConsult_Load(object sender, EventArgs e)
        {
            loadMessages();
            loadTopic();
            ControllerChangeConsultState.changeConsultState(consultId, "Received");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbNewMessage.Text;
            ControllerSendConsultMessage.sendConsultMessage(consultId, Session.userId, message);
            ControllerChangeConsultState.changeConsultState(consultId, "Done");
        }
        private void btnFileConsult_Click(object sender, EventArgs e)
        {
            ControllerChangeConsultState.changeConsultState(consultId, "Filed");
        }
        public void loadMessages()
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ControllerGetConsultMessages.getConsultMessages(consultId);
            rtbMessages.Clear();
            foreach (DataRow message in consultMessages.Rows)
            {

                string personName;
                personName = ControllerGetPerson.getPersonNick(Int32.Parse(message[0].ToString()));
                                        //MessageBox.Show(message[0].ToString());


                rtbMessages.AppendText(personName + "\n");
                rtbMessages.AppendText(message[1].ToString() + "\n");
                rtbMessages.AppendText(message[2].ToString() + "\n \n \n");
            }
        }
        public void loadTopic()
        {
            tbTopic.Text = this.topic;
        }
    }
}
