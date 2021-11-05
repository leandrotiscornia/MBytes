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
            if (consultationId > 0)
                sendMessage();
            else
                MessageBox.Show("You need to select a consultation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnFileConsult_Click(object sender, EventArgs e)
        {
            if (consultationId > 0)
                fileConsultation();
            else
                MessageBox.Show("You need to select a consultation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void loadMessages()
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ConsultationMessageController.getConsultationMessages(consultationId);
            rtbMessages.Clear();
            foreach (DataRow message in consultMessages.Rows)
            {

                string personName;
                personName = PersonController.getPersonNick(Int32.Parse(message[0].ToString()));
                                        //MessageBox.Show(message[0].ToString());


                rtbMessages.AppendText(personName + "\n");
                rtbMessages.AppendText(message[1].ToString() + "\n");
                rtbMessages.AppendText(message[2].ToString() + "\n \n \n");
            }
            if (ConsultationController.getConsultationState(consultationId) == "Answered")
                ConsultationController.changeConsultationState(consultationId, "Received");
        }
        public void loadTopic()
        {
            tbTopic.Text = this.topic;
        }
        private void sendMessage()
        {
            string message = tbNewMessage.Text;
            ConsultationMessageController.sendConsultationMessage(consultationId, Session.userId, message);
            ConsultationController.changeConsultationState(consultationId, "Done");

        }
        public void fileConsultation()
        {
            ConsultationController.changeConsultationState(consultationId, "Filed");
        }

        private void lbMessageEditConsult_Click(object sender, EventArgs e)
        {

        }
    }
}
