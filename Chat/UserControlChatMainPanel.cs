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
using Datos;


namespace Chat
{
    public partial class UserControlChatMainPanel : UserControl
    {



        public UserControlChatMainPanel()
        {
            InitializeComponent();


        }

        private void btnCreateNewChatSession_Click(object sender, EventArgs e)
        {

            int userRole = Session.userId;


            if (Session.userId == 1)
            {
                UserControlNewChatSession newSession = new UserControlNewChatSession();
                btnCreateNewChatSession.Controls.Add(newSession);
                lbWelcome.Text = "Welcome teacher";
            }
            else if (Session.userId == 2)
            {

                UserControlNewChatSession newSession = new UserControlNewChatSession();
                btnCreateNewChatSession.Controls.Add(newSession);
                lbWelcome.Text = "Welcome student";
            }
        }
        private void btnViewExistingsessions_Click(object sender, EventArgs e) { 

            if (Session.userId == 1)
            {   
        
                UserControlViewExistingSessions viewExistingSession = new UserControlViewExistingSessions();

                btnViewExistingSessions.Controls.Add(viewExistingSession);

            }
            else if (Session.userId == 2)
            {

                UserControlViewExistingSessions viewExistingSession = new UserControlViewExistingSessions();

                btnViewExistingSessions.Controls.Add(viewExistingSession);

            }
        }


           


}



    }
