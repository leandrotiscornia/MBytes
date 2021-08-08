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
            Console.WriteLine("Cambia el indice seleccionado");


            if (tabControlConsults.SelectedIndex == 0)
            {
                users.loadPersons();
                Console.WriteLine("Selecciono indice 0");
                writeConsult.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(writeConsult);
            }
            else if (tabControlConsults.SelectedIndex == 1)
            {
                Console.WriteLine("Selecciono indice 1");
                consultationsMade.loadConsults();
                editConsult.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(editConsult);
            }
            else if (tabControlConsults.SelectedIndex == 2)
            {
                Console.WriteLine("Selecciono indice 2");
                consultationssFiled.loadConsults();
                readFiled.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(readFiled);
            }
        }
    }
}
