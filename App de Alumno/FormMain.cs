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

namespace App_De_Alumno 
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
                if (lvNavigation.SelectedItems[0].Text == "Consultations")
                {
                    UserControlConsultationsMainPanel consultationsPanel = new UserControlConsultationsMainPanel();
                    consultationsPanel.Dock = DockStyle.Fill;
                    pnlFunction.Controls.Add(consultationsPanel);
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlFunction.Controls.Clear();
            UserControlProfile profile = new UserControlProfile();
            profile.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(profile);
        }

        private void btnInscriptions_Click(object sender, EventArgs e)
        {
            pnlFunction.Controls.Clear();
            UserControlStudentInscriptions inscriptions = new UserControlStudentInscriptions();
            inscriptions.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(inscriptions);
        }
    }
}
