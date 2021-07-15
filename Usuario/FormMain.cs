using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Consultas;

namespace Usuario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        private void lvNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFunction.Controls.Clear();
            if (lvNavigation.SelectedIndices.Count > 0)
            {
                if (lvNavigation.SelectedItems[0].Text == "Consults")
                {
                    UserControlConsultsMainPanel consultsPanel = new UserControlConsultsMainPanel();
                   // consultsPanel.Dock = DockStyle.Fill;
                    pnlFunction.Controls.Add(consultsPanel);
                }
                    


            }
        }
    }
}
