using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Usuario
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            lblNewNickName.Visible = false;
            lblNewFirstName.Visible = false;
            lblNewSecondName.Visible = false;
            lblNewFirstSurname.Visible = false;
            lblNewSecondSurname.Visible = false;
            

            txtNewNickName.Visible = false;
            txtNewFirstName.Visible = false;
            txtNewSecondName.Visible = false;
            txtNewFirstSurname.Visible = false;
            txtNewSecondSurname.Visible = false;

            btnConfirmInfo.Visible = false;


        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            pbUserPicture.Image = Properties.Resources.user;
        }

        private void btnModifyProfile_Click(object sender, EventArgs e)
        {
            
            lblNewFirstName.Visible = true;
            lblNewSecondName.Visible = true;
            lblNewFirstSurname.Visible = true;
            lblNewSecondSurname.Visible = true;


           
            txtNewFirstName.Visible = true;
            txtNewSecondName.Visible = true;
            txtNewFirstSurname.Visible = true;
            txtNewSecondSurname.Visible = true;

            btnConfirmInfo.Visible = true;
        }

        private void btnSetNickName_Click(object sender, EventArgs e)
        {
            lblNewNickName.Visible = true;
            txtNewNickName.Visible = true;
            btnConfirmInfo.Visible = true;
        }

        private void btnConfirmInfo_Click(object sender, EventArgs e)
        {
            lblActualFirstName.Text = txtNewFirstName.ToString();
            lblActualSecondName.Text = txtNewFirstSurname.ToString();
            lblActualFirstSurname.Text = txtNewFirstSurname.ToString();
            lblActualSecondSurname.Text = txtNewSecondSurname.ToString();
            btnConfirmInfo.Visible = false;

            
        }

        /*public bool {}
         * - Aca quiero que cuando el usuario de click en el boton Set Nick Name,
         * se culten los labels y text box de FirstName en adelante , quede el text box de 
         * new nick name y el boton de confirm info , darle click a eso boton y asignarle 
         * el nick name al Actual label. 
         */ 
    }
}
