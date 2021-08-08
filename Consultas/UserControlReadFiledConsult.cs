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
    public partial class UserControlReadFiledConsult : UserControl
    {
        public int consultationId { get; set; }

        public string topic { get; set; }

        public UserControlReadFiledConsult(int consultationId)
        {
            this.consultationId = consultationId;
        }

        public UserControlReadFiledConsult()
        {
            InitializeComponent();
        }

        private void UserControlReadFiledConsult_Load(object sender, EventArgs e)
        {
            loadMessages();
            loadTopic();
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

        }
        public void loadTopic()
        {
            tbTopic.Text = this.topic;
        }
    }
}
