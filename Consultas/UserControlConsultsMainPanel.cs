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
        }

        


        


    private void UserControlConsultsMainPanel_Load(Object sender, EventArgs e)
        {
            users.Dock = DockStyle.Fill;
            consultsMade.Dock = DockStyle.Fill;
            consultsFiled.Dock = DockStyle.Fill;
            tabPageNewConsult.Controls.Add(users);
            tabPageConsultsMade.Controls.Add(consultsMade);
            tabPageConsultsFiled.Controls.Add(consultsFiled);
            
            
            

        }

        private void tabControlConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlConsults.Controls.Clear();
            Console.WriteLine("Cambia el indice seleccionado");


            if (tabControlConsults.SelectedIndex == 0)
            {
                Console.WriteLine("Selecciono indice 0");
                writeConsult.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(writeConsult);
            }
            else if (tabControlConsults.SelectedIndex == 1)
            {
                Console.WriteLine("Selecciono indice 1");
                
                editConsult.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(editConsult);
            }
            else if (tabControlConsults.SelectedIndex == 2)
            {
                Console.WriteLine("Selecciono indice 2");

                readFiled.Dock = DockStyle.Fill;
                pnlConsults.Controls.Add(readFiled);
            }
        }

        private void tabPageNewConsult_CursorChanged(object sender, EventArgs e)
        {
            writeConsult.receiverId = users.receiverId;
            Console.WriteLine("Usuario: " + users.receiverId);
        }

        private void tabPageConsultsMade_Click(object sender, EventArgs e)
        {
            editConsult.consultId = consultsMade.consultId;
        }

        private void tabPageConsultsFiled_Click(object sender, EventArgs e)
        {
            readFiled.consultId = consultsFiled.consultId;
        }

        private void tabPageNewConsult_Click(object sender, EventArgs e)
        {
            writeConsult.receiverId = users.receiverId;
            Console.WriteLine("Usuario: " + users.receiverId);
        }
    }
}
