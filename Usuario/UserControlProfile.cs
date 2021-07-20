using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuario
{
    public partial class UserControlProfile : UserControl
    {
        public UserControlProfile()
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

            ModifyProfile();
        }

        private void btnSetNickName_Click(object sender, EventArgs e)
        {
            SetNickName();
        }

        private void btnChangeUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmInfo_Click(object sender, EventArgs e)
        {
            ConfirmInfo(sender, e);
        }
        public void ModifyProfile()
        {
            pbModifyUserProfile.Visible = true;
            lblModifyUserProfile.Visible = true;
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

        public void SetNickName()
        {
            pbModifyUserProfile.Visible = true;
            lblModifyUserProfile.Visible = true;
            lblNewNickName.Visible = true;
            txtNewNickName.Visible = true;
            btnConfirmInfo.Visible = true;

        }

        public void ChangeUserName()
        {
            pbModifyUserProfile.Visible = true;
            lblModifyUserProfile.Visible = true;
            lblNewUserName.Visible = true;
            txtNewUserName.Visible = true;
            btnConfirmInfo.Visible = true;

        }
        public void ConfirmInfo(object sender, EventArgs e)
        {
            lblActualFirstName.Text = txtNewFirstName.ToString();
            lblActualSecondName.Text = txtNewFirstSurname.ToString();
            lblActualFirstSurname.Text = txtNewFirstSurname.ToString();
            lblActualSecondSurname.Text = txtNewSecondSurname.ToString();
            HideSetProfileInformation();
            btnConfirmInfo.Visible = false;
           
            if (btnConfirmInfo.Visible == false)
            {
                SetNickName();
                lblActualNickName.Text = txtNewNickName.ToString();
                lblUserNickName.Text = txtNewNickName.ToString();
                HideSetNickName();

            }
            btnConfirmInfo.Visible = true;
            if (btnConfirmInfo.Visible == true) {
                ChangeUserName();
                lblActualUserName.Text = txtNewUserName.ToString();
                HideChangeUserName();
            }
        }
        public void HideSetProfileInformation()
        {
            pbModifyUserProfile.Visible = false;
            lblModifyUserProfile.Visible = false;
            lblNewFirstName.Visible = false;
            lblNewSecondName.Visible = false;
            lblNewFirstSurname.Visible = false;
            lblNewSecondSurname.Visible = false;
            txtNewFirstName.Visible = false;
            txtNewSecondName.Visible = false;
            txtNewFirstSurname.Visible = false;
            txtNewSecondSurname.Visible = false;

        }

        public void HideSetNickName()
        {
            pbModifyUserProfile.Visible = false;
            lblModifyUserProfile.Visible = false;
            lblNewNickName.Visible = false;
            txtNewNickName.Visible = false;
            btnConfirmInfo.Visible = false;
        }

        public void HideChangeUserName()
        {
            pbModifyUserProfile.Visible = false;
            lblModifyUserProfile.Visible = false;
            lblNewUserName.Visible = false;
            txtNewUserName.Visible = false;
            btnConfirmInfo.Visible = false;
        }

        private void pbCloseButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
