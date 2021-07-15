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
            int senderId = Session.userId;
            string topic = tbTopic.Text;
            string consultMessage = tbNewMessage.Text;
            Console.WriteLine("" + receiverId);
            ControllerNewConsult.newConsult(senderId, receiverId, topic);
            ControllerSendConsultMessage.sendConsultMessage(senderId, consultMessage);
        }

        private void UserControlWriteConsult_Load(object sender, EventArgs e)
        {
            
        }
    }
}
