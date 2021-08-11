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
    public partial class UserControlConsultationsMainPanel : UserControl
    {
        UserControlNewConsult users = new UserControlNewConsult();
        UserControlConsultationsMade consultationsMade = new UserControlConsultationsMade();
        UserControlConsultationsFiled consultationssFiled = new UserControlConsultationsFiled();

        UserControlWriteConsult writeConsult = new UserControlWriteConsult();
        UserControlEditConsult editConsult = new UserControlEditConsult();
        UserControlReadFiledConsult readFiled = new UserControlReadFiledConsult();
        
        public UserControlConsultationsMainPanel()
        {
            InitializeComponent();

            users.Dock = DockStyle.Fill;
            consultationsMade.Dock = DockStyle.Fill;
            consultationssFiled.Dock = DockStyle.Fill;
            tabPageNewConsult.Controls.Add(users);
            tabPageConsultsMade.Controls.Add(consultationsMade);
            tabPageConsultsFiled.Controls.Add(consultationssFiled);
            pnlConsults.Controls.Add(writeConsult);

            
            users.SelectedIndexChanged += new EventHandler(users_SelectedIndexChanged);
            consultationsMade.SelectedIndexChanged += new EventHandler(consultsMade_SelectedIndexChanged);
            consultationssFiled.SelectedIndexChanged += new EventHandler(consultsFiled_SelectedIndexChanged);
        }

        
        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            writeConsult.receiverId = users.userId;
        }
        private void consultsMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            editConsult.consultationId = consultationsMade.consultId;
            editConsult.topic = consultationsMade.topic;
            editConsult.loadMessages();
            editConsult.loadTopic();
        }
        private void consultsFiled_SelectedIndexChanged(object sender, EventArgs e)
        {
            readFiled.consultationId = consultationssFiled.consultId;
            readFiled.topic = consultationssFiled.topic;
            readFiled.loadMessages();
            readFiled.loadTopic();
        }

        

        private void tabControlConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlConsults.Controls.Clear();
            writeConsult.receiverId = -1;
            editConsult.consultationId = 0;

            if (tabControlConsults.SelectedIndex == 0)
                loadPersons();
            else if (tabControlConsults.SelectedIndex == 1)
                loadMade();
            else if (tabControlConsults.SelectedIndex == 2)
                loadFiled();
        }
        private void loadPersons()
        {
            users.loadPersons();
            writeConsult.Dock = DockStyle.Fill;
            pnlConsults.Controls.Add(writeConsult);

        }
        private void loadMade()
        {
            consultationsMade.loadConsults();
            editConsult.Dock = DockStyle.Fill;
            pnlConsults.Controls.Add(editConsult);

        }

        private void loadFiled()
        {
            consultationssFiled.loadConsults();
            readFiled.Dock = DockStyle.Fill;
            pnlConsults.Controls.Add(readFiled);

        }
    }
}
