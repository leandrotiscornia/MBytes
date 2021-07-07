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
            label1.Text = "userId:"+Session.userId.ToString();
            label2.Text = "userRole:"+Session.userRole;
            label3.Text = "passwrod:"+Session.userPassword;
        }
    }
}
