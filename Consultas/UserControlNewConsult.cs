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
    public partial class UserControlNewConsult : UserControl
    {
        public int receiverId {get; set;}
    
        public UserControlNewConsult()
        {
            InitializeComponent();
        }

        private void UserControlNewConsult_Load(object sender, EventArgs e)
        {
            loadPersons();
        }

        private void lvNewConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNewConsults.SelectedIndices.Count > 0 && lvNewConsults.Items.Count > 0)
                    this.receiverId = Int32.Parse(lvNewConsults.SelectedItems[0].Text);
        }

        private void loadPersons()
        {
            DataTable personsTable = new DataTable();
            personsTable = ControllerGetAgendaUsers.GetAgendaUsers();
            ListViewItem item; 

            foreach (DataRow person in personsTable.Rows)
            {
                Console.WriteLine("" + person[0].ToString());
                item = new ListViewItem(person[0].ToString());
                item.SubItems.Add(person[2].ToString() + person[4].ToString());
                item.SubItems.Add(person[1].ToString());
                item.SubItems.Add(person[6].ToString());
                lvNewConsults.Items.Add(item);
            }

        }
        
    }
}
