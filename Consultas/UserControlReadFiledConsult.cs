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
        public int consultId { get; set; }

        public UserControlReadFiledConsult (int consultId)
        {
            this.consultId = consultId;
        }

        public UserControlReadFiledConsult()
        {
            InitializeComponent();
        }

        private void UserControlReadFiledConsult_Load(object sender, EventArgs e)
        {
            DataTable consultMessages = new DataTable();
            consultMessages = ControllerGetConsultMessages.getConsultMessages(consultId);
            lbxPreviousMessages.DataSource = consultMessages;
            lbxPreviousMessages.DisplayMember = "ConsultText";
            lbxPreviousMessages.DisplayMember = "Time";
            
        }
    }
}
