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

        public UserControlEditConsult (int consultId)
        {
            this.consultId = consultId;
        }

        public UserControlEditConsult()
        {
            InitializeComponent();
        }
        private void UserControlEditConsult_Load(object sender, EventArgs e)
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ControllerGetConsultMessages.getConsultMessages(consultId);
            
            lbxPreviousMessages.DataSource = consultMessages;
            lbxPreviousMessages.DisplayMember = "ConsultText";
            lbxPreviousMessages.DisplayMember = "Time";
            
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
    }
}
