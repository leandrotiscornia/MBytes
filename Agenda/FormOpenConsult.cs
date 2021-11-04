using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Agenda
{
    public partial class FormOpenConsultation : Form
    {


        private int _consultationId;
        private string _topic;
        private string _state;
        public FormOpenConsultation(int consultationId, string topic, string state)
        {
            InitializeComponent();
            this._consultationId = consultationId;
            this._topic = topic;
            this._state = state;
        }

        private void loadMessages()
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ConsultationMessageController.getConsultationMessages(_consultationId);
            rtbMessages.Clear();
            foreach (DataRow message in consultMessages.Rows)
            {
                string personName;
                personName = PersonController.getPersonNick(Int32.Parse(message[0].ToString()));
                rtbMessages.AppendText(personName + "\n");
                rtbMessages.AppendText(message[1].ToString() + "\n");
                rtbMessages.AppendText(message[2].ToString() + "\n \n \n");
            }

        }
        private void hideButton()
        {
            if (_state == "Filed")
                btnSend.Hide();
        }
        private void loadTopic()
        {
            tbTopic.Text = this._topic;
        }

        private void FormOpenConsult_Load(object sender, EventArgs e)
        {
            loadMessages();
            loadTopic();
            hideButton();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbNewMessage.Text;
            ConsultationMessageController.sendConsultationMessage(_consultationId, Session.userId, message);
            ConsultationController.changeConsultationState(_consultationId, "Answered");
            this.Close();
        }

       
    }
}