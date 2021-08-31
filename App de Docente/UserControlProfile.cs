using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Negocio;

namespace App_de_Docente
{

    public partial class UserControlProfile : UserControl
    {
        public UserControlProfile()
        {
            InitializeComponent();
            pictureSelector.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }
        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            hideModifyProfileInfo();
            loadUserData();
        }
       

        private void loadUserData()
        {
            List<string> profileData = PersonController.getProfileData(Session.userId);
            lblActualUserName.Text = profileData[0];
            lbActualCI.Text = profileData[1];
            lblActualFirstName.Text = profileData[2];
            lblActualSecondName.Text = profileData[3];
            lblActualFirstSurname.Text = profileData[4];
            lblActualSecondSurname.Text = profileData[5];
            lblActualNickName.Text = profileData[6];
            txtNewUserName.Text = profileData[0];
            txtNewNickName.Text = profileData[6];
            txtNewFirstName.Text = profileData[2];
            txtNewSecondName.Text = profileData[3];
            txtNewFirstSurname.Text = profileData[4];
            txtNewSecondSurname.Text = profileData[5];
            loadPicture();
        }

        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            ChangeUserName();
        }
        public void hideModifyProfileInfo()
        {
            gbChangeNickName.Hide();
            gbChangeUserName.Hide();
            gbModifyProfile.Hide();
            btnConfirmInfo.Hide();
            btnConfirmNickName.Hide();
            btnConfirmUserName.Hide();
            gbPictureModifyUserProfile.Hide();
        }
        public void modifyProfile()
        {
            hideModifyProfileInfo();
            gbPictureModifyUserProfile.Show();
            gbModifyProfile.Show();
            btnConfirmInfo.Show();
        }

        public void setNickName()
        {
            hideModifyProfileInfo();
            gbChangeNickName.Show();
            btnConfirmNickName.Show();
            gbPictureModifyUserProfile.Show();
        }

        public void ChangeUserName()
        {
            hideModifyProfileInfo();
            gbPictureModifyUserProfile.Show();
            gbChangeUserName.Show();
            btnConfirmUserName.Show();
        }
        public void modifyData()
        {
            string[] personInfo = new string[6];
            personInfo[0] = Session.userId.ToString();
            personInfo[1] = lbActualCI.Text;
            personInfo[2] = txtNewFirstName.Text;
            personInfo[3] = txtNewSecondName.Text;
            personInfo[4] = txtNewFirstSurname.Text;
            personInfo[5] = txtNewSecondSurname.Text;
            PersonController.modifyPerson(personInfo);
            hideModifyProfileInfo();
        }
        public void modifyUserName()
        {
            PersonController.modifyUserName(txtNewUserName.Text, Session.userId);
        }

        public void modifyNickName()
        {
            PersonController.modifyNickName(txtNewNickName.Text);
        }
        private void btnConfirmNickName_Click(object sender, EventArgs e)
        {
            if (txtNewNickName.Text != null)
            {
                modifyNickName();
                hideModifyProfileInfo();
                loadUserData();
            }
            else
                MessageBox.Show("You need to set a nickname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConfirmUserName_Click(object sender, EventArgs e)
        {
            if (txtNewUserName != null)
            {
                modifyUserName();
                hideModifyProfileInfo();
                loadUserData();
            }
            else
                MessageBox.Show("You need to set a user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSetNickName_Click(object sender, EventArgs e)
        {
            setNickName();
        }

        private void btnModifyProfile_Click(object sender, EventArgs e)
        {
            modifyProfile();
        }
        private void savePicture()
        {
            if (pictureSelector.ShowDialog() == DialogResult.OK)
            {
                File.Copy(pictureSelector.FileName, Path.Combine(PictureController.getPicturePath(), Session.ci), true);
                loadPicture();
            }
        }
        private void loadPicture()
        {
            if (File.Exists(Path.Combine(PictureController.getPicturePath(), Session.ci)))
                pbUserPicture.Image = Image.FromFile(Path.Combine(PictureController.getPicturePath(), Session.ci));
        }
        private void btnConfirmInfo_Click(object sender, EventArgs e)
        {
            if (txtNewFirstName.Text == null)
                MessageBox.Show("You need to set a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtNewFirstSurname.Text == null)
                MessageBox.Show("You need to set a surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                modifyData();
                hideModifyProfileInfo();
                loadUserData();
            }
        }
        private void btnChangePicture_Click_1(object sender, EventArgs e)
        {
            savePicture();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not added yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

 
    }
}

