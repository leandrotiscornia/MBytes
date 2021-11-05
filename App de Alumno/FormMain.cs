using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Chat;
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
            GC.Collect();
            if (lvNavigation.SelectedIndices.Count > 0)
            {
                if (lvNavigation.SelectedItems[0].Text == "Consultations")
                {
                    UserControlConsultationsMainPanel consultationsPanel = new UserControlConsultationsMainPanel();
                    consultationsPanel.Dock = DockStyle.Fill;
                    pnlFunction.Controls.Add(consultationsPanel);
                }
                else if (lvNavigation.SelectedItems[0].Text == "Chat")
                {
                    UserControlChatMainPanel chat = new UserControlChatMainPanel();
                    chat.Dock = DockStyle.Fill;
                    pnlFunction.Controls.Add(chat);
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
            GC.Collect();
            UserControlProfile profile = new UserControlProfile();
            profile.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(profile);
        }

        private void btnInscriptions_Click(object sender, EventArgs e)
        {
            pnlFunction.Controls.Clear();
            GC.Collect();
            UserControlStudentInscriptions inscriptions = new UserControlStudentInscriptions();
            inscriptions.Dock = DockStyle.Fill;
            pnlFunction.Controls.Add(inscriptions);
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    Controls.Clear();
                    InitializeComponent();
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    Controls.Clear();
                    InitializeComponent();
                    break;
                default:
                    break;
            }


        }
    }
}
