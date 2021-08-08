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
        public int consultationId { get; set; }
        public string topic { get; set; }

        public UserControlEditConsult(int consultId)
        {
            this.consultationId = consultId;
        }

        public UserControlEditConsult()
        {
            InitializeComponent();
        }
        private void UserControlEditConsult_Load(object sender, EventArgs e)
        {
            loadMessages();
            loadTopic();
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbNewMessage.Text;
            ControllerConsultationMessage.sendConsultationMessage(consultationId, Session.userId, message);
            ControllerConsultation.changeConsultationState(consultationId, "Done");
        }
        private void btnFileConsult_Click(object sender, EventArgs e)
        {
            ControllerConsultation.changeConsultationState(consultationId, "Filed");
        }
        public void loadMessages()
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ControllerConsultationMessage.getConsultationMessages(consultationId);
            rtbMessages.Clear();
            foreach (DataRow message in consultMessages.Rows)
            {

                string personName;
                personName = ControllerPerson.getPersonNick(Int32.Parse(message[0].ToString()));
                                        //MessageBox.Show(message[0].ToString());


                rtbMessages.AppendText(personName + "\n");
                rtbMessages.AppendText(message[1].ToString() + "\n");
                rtbMessages.AppendText(message[2].ToString() + "\n \n \n");
            }
            if (ControllerConsultation.getConsultationState(consultationId) == "Answered")
                ControllerConsultation.changeConsultationState(consultationId, "Received");
        }
        public void loadTopic()
        {
            tbTopic.Text = this.topic;
        }
    }
}
