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
    public partial class FormOpenConsult : Form
    {


        private int _consultId;
        private string _topic;
        private string _state;
        public FormOpenConsult(int consultId, string topic, string state)
        {
            InitializeComponent();
            this._consultId = consultId;
            this._topic = topic;
            this._state = state;
        }

        private void loadMessages()
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ControllerGetConsultMessages.getConsultMessages(_consultId);
            rtbMessages.Clear();
            foreach (DataRow message in consultMessages.Rows)
            {
                string personName;
                personName = ControllerGetPerson.getPersonNick(Int32.Parse(message[0].ToString()));
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
            ControllerSendConsultMessage.sendConsultMessage(_consultId, Session.userId, message);
            ControllerChangeConsultState.changeConsultState(_consultId, "Answered");
            this.Close();
        }

       
    }
}