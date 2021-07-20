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

namespace Usuario
{
    
        public partial class UserControlProfile : UserControl
        {
            
            public UserControlProfile()
            {
                InitializeComponent();
            }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            HideModifyProfileInfo();
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
            
                ChangeUserName();
            }

            private void btnConfirmInfo_Click(object sender, EventArgs e)
            {

                 modifyData();
            }

            public void HideModifyProfileInfo()
            {
                gbChangeNickName.Hide();
                gbChangeUserName.Hide();
                gbModifyProfile.Hide();
                btnConfirmInfo.Hide();
            }
            public void ModifyProfile()
            {
                gbPictureModifyUserProfile.Show();
                gbModifyProfile.Show();
                btnConfirmInfo.Show();
            }

            public void SetNickName()
            {
                gbChangeNickName.Show();
                btnConfirmInfo.Show();

            }

            public void ChangeUserName()
            {
                gbPictureModifyUserProfile.Show();
                gbChangeUserName.Show();
                btnConfirmInfo.Show();

            }
            
            public void HideSetProfileInformation()
            {
                gbPictureModifyUserProfile.Hide();
                gbModifyProfile.Hide();
                btnConfirmInfo.Hide();

        }

        public void modifyData()
        {
            string[] personInfo = new string[5];
            personInfo[0] = Session.userId.ToString();
            personInfo[1] = lblCI.Text;
            personInfo[2] = txtNewFirstName.Text;
            personInfo[3] = txtNewFirstSurname.Text;
            personInfo[4] = txtNewSecondName.Text;
            personInfo[5] = txtNewSecondSurname.Text;
            ControllerModifyPerson.modifyPerson(personInfo);
        }

        
          public void modifyUserName()
            {
                ControllerModifyUserName.modifyUserName(txtNewUserName.Text,Session.userId);
            }

            public void modifyNickName()
            {
            
               ControllerModifyNickName.modifyNickName(txtNewNickName.Text, Session.ci);  
            }

      

        public void personInformationToCharge()
        {
            // Aca se cargan los datos de Negocio y que herede ModelPerson 

        }
        public void HideSetNickName()
        {
              gbPictureModifyUserProfile.Hide();
              gbChangeNickName.Hide();
              btnConfirmInfo.Hide();   
        }

        public void HideChangeUserName()
        {
             gbPictureModifyUserProfile.Hide();
             gbChangeUserName.Hide();
             btnConfirmInfo.Hide();
        }

            

        private void btnConfirmNickName_Click(object sender, EventArgs e) 
        {
            modifyNickName();
        }

        private void btnConfirmUserName_Click(object sender, EventArgs e) 
        {
            modifyUserName();
        }

        
    }
    }

