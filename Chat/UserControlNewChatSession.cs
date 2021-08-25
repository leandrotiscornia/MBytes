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

namespace Chat
{
    public partial class UserControlNewChatSession : UserControl
    {

        public UserControlNewChatSession()
        {
            InitializeComponent();
        }

        private void tbpChangeling_Click(object sender, EventArgs e)
        {
            if (Session.userId == 1)
            {
                tbpChangeling.Text = "Groups";

            }
            else if (Session.userId == 2)
            {
                tbpChangeling.Text = "Teachers";
            }

        }
    }
}
