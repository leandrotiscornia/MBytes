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
    public partial class UserControlConsultsMainPanel : UserControl
    {
        UserControlNewConsult users = new UserControlNewConsult();
        UserControlConsultsMade consultsMade = new UserControlConsultsMade();
        UserControlConsultsFiled consultsFiled = new UserControlConsultsFiled();


        UserControlWriteConsult writeConsult = new UserControlWriteConsult();
        UserControlEditConsult editConsult = new UserControlEditConsult();
        UserControlReadFiledConsult readFiled = new UserControlReadFiledConsult();
        




        public UserControlConsultsMainPanel()
        {
            InitializeComponent();

            users.Dock = DockStyle.Fill;
            consultsMade.Dock = DockStyle.Fill;
            consultsFiled.Dock = DockStyle.Fill;
            tabPageNewConsult.Controls.Add(users);
            tabPageConsultsMade.Controls.Add(consultsMade);
            tabPageConsultsFiled.Controls.Add(consultsFiled);
            pnlConsults.Controls.Add(writeConsult);

            
            users.SelectedIndexChanged += new EventHandler(users_SelectedIndexChanged);
            consultsMade.SelectedIndexChanged += new EventHandler(consultsMade_SelectedIndexChanged);
            consultsFiled.SelectedIndexChanged += new EventHandler(consultsFiled_SelectedIndexChanged);
        }

        
        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            writeConsult.receiverId = users.userId;
        }
        private void consultsMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            editConsult.consultId = consultsMade.consultId;
            editConsult.topic = consultsMade.topic;
            editConsult.loadMessages();
            editConsult.loadTopic();
        }
        private void consultsFiled_SelectedIndexChanged(object sender, EventArgs e)
        {
            readFiled.consultId = consultsFiled.consultId;
            readFiled.topic = consultsFiled.topic;
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
                consultsMade.loadConsults();
                editConsult.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(editConsult);
            }
            else if (tabControlConsults.SelectedIndex == 2)
            {
                Console.WriteLine("Selecciono indice 2");
                consultsFiled.loadConsults();
                readFiled.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(readFiled);
            }
        }
    }
}
