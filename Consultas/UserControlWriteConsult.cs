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
    public partial class UserControlWriteConsult : UserControl
    {
        public int receiverId { get; set; }


        public UserControlWriteConsult(int receiverId)
        {
            this.receiverId = receiverId;
        }

        public UserControlWriteConsult()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (receiverId > -1)
                sendConsultation();
            else
                MessageBox.Show("You need to select a teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UserControlWriteConsult_Load(object sender, EventArgs e)
        {
            receiverId = -1;
        }
        private void sendConsultation()
        {
            int senderId = Session.userId;
            string topic = tbTopic.Text;
            string consultationMessage = tbNewMessage.Text;
            Console.WriteLine("" + receiverId);
            ConsultationController.newConsultation(senderId, receiverId, topic, consultationMessage);
        }
    }
}
