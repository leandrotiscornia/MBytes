namespace Usuario
{
    partial class FormUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserProfile));
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.btnModifyProfile = new System.Windows.Forms.Button();
            this.btnSetNickName = new System.Windows.Forms.Button();
            this.pbUserInfo = new System.Windows.Forms.PictureBox();
            this.pbUserConfig = new System.Windows.Forms.PictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstSurName = new System.Windows.Forms.Label();
            this.lblSecondSurname = new System.Windows.Forms.Label();
            this.lblChangePicture = new System.Windows.Forms.Label();
            this.lblModifyProfile = new System.Windows.Forms.Label();
            this.lblSetNickName = new System.Windows.Forms.Label();
            this.btnChangeUserName = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblChangeUserName = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblUserConfig = new System.Windows.Forms.Label();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActualNickName = new System.Windows.Forms.Label();
            this.lblActualFirstName = new System.Windows.Forms.Label();
            this.lblActualSecondName = new System.Windows.Forms.Label();
            this.lblActualFirstSurname = new System.Windows.Forms.Label();
            this.lblActualSecondSurname = new System.Windows.Forms.Label();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.txtNewSecondName = new System.Windows.Forms.TextBox();
            this.txtNewFirstSurname = new System.Windows.Forms.TextBox();
            this.txtNewSecondSurname = new System.Windows.Forms.TextBox();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.lblNewSecondName = new System.Windows.Forms.Label();
            this.lblNewFirstSurname = new System.Windows.Forms.Label();
            this.lblNewSecondSurname = new System.Windows.Forms.Label();
            this.txtNewNickName = new System.Windows.Forms.TextBox();
            this.lblNewNickName = new System.Windows.Forms.Label();
            this.btnConfirmInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.Location = new System.Drawing.Point(682, 129);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(117, 23);
            this.btnChangePicture.TabIndex = 0;
            this.btnChangePicture.Text = "Change Picture..";
            this.btnChangePicture.UseVisualStyleBackColor = true;
            this.btnChangePicture.Click += new System.EventHandler(this.btnChangePicture_Click);
            // 
            // btnModifyProfile
            // 
            this.btnModifyProfile.Location = new System.Drawing.Point(682, 167);
            this.btnModifyProfile.Name = "btnModifyProfile";
            this.btnModifyProfile.Size = new System.Drawing.Size(117, 23);
            this.btnModifyProfile.TabIndex = 1;
            this.btnModifyProfile.Text = "Modify Profile..";
            this.btnModifyProfile.UseVisualStyleBackColor = true;
            this.btnModifyProfile.Click += new System.EventHandler(this.btnModifyProfile_Click);
            // 
            // btnSetNickName
            // 
            this.btnSetNickName.Location = new System.Drawing.Point(682, 204);
            this.btnSetNickName.Name = "btnSetNickName";
            this.btnSetNickName.Size = new System.Drawing.Size(117, 23);
            this.btnSetNickName.TabIndex = 2;
            this.btnSetNickName.Text = "Set Nick Name..";
            this.btnSetNickName.UseVisualStyleBackColor = true;
            this.btnSetNickName.Click += new System.EventHandler(this.btnSetNickName_Click);
            // 
            // pbUserInfo
            // 
            this.pbUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbUserInfo.Image")));
            this.pbUserInfo.Location = new System.Drawing.Point(9, 59);
            this.pbUserInfo.Name = "pbUserInfo";
            this.pbUserInfo.Size = new System.Drawing.Size(64, 64);
            this.pbUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUserInfo.TabIndex = 3;
            this.pbUserInfo.TabStop = false;
            // 
            // pbUserConfig
            // 
            this.pbUserConfig.Image = ((System.Drawing.Image)(resources.GetObject("pbUserConfig.Image")));
            this.pbUserConfig.Location = new System.Drawing.Point(727, 59);
            this.pbUserConfig.Name = "pbUserConfig";
            this.pbUserConfig.Size = new System.Drawing.Size(64, 64);
            this.pbUserConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUserConfig.TabIndex = 4;
            this.pbUserConfig.TabStop = false;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(10, 139);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(63, 13);
            this.lblNickName.TabIndex = 5;
            this.lblNickName.Text = "Nick Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 177);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(12, 214);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(78, 13);
            this.lblSecondName.TabIndex = 7;
            this.lblSecondName.Text = "Second Name:";
            // 
            // lblFirstSurName
            // 
            this.lblFirstSurName.AutoSize = true;
            this.lblFirstSurName.Location = new System.Drawing.Point(12, 252);
            this.lblFirstSurName.Name = "lblFirstSurName";
            this.lblFirstSurName.Size = new System.Drawing.Size(74, 13);
            this.lblFirstSurName.TabIndex = 8;
            this.lblFirstSurName.Text = "First Surname:";
            // 
            // lblSecondSurname
            // 
            this.lblSecondSurname.AutoSize = true;
            this.lblSecondSurname.Location = new System.Drawing.Point(10, 291);
            this.lblSecondSurname.Name = "lblSecondSurname";
            this.lblSecondSurname.Size = new System.Drawing.Size(92, 13);
            this.lblSecondSurname.TabIndex = 9;
            this.lblSecondSurname.Text = "Second Surname:";
            // 
            // lblChangePicture
            // 
            this.lblChangePicture.AutoSize = true;
            this.lblChangePicture.Location = new System.Drawing.Point(518, 134);
            this.lblChangePicture.Name = "lblChangePicture";
            this.lblChangePicture.Size = new System.Drawing.Size(140, 13);
            this.lblChangePicture.TabIndex = 10;
            this.lblChangePicture.Text = "Change Your Profile Picture:";
            // 
            // lblModifyProfile
            // 
            this.lblModifyProfile.AutoSize = true;
            this.lblModifyProfile.Location = new System.Drawing.Point(518, 172);
            this.lblModifyProfile.Name = "lblModifyProfile";
            this.lblModifyProfile.Size = new System.Drawing.Size(153, 13);
            this.lblModifyProfile.TabIndex = 11;
            this.lblModifyProfile.Text = "Modify Your Profile Information:";
            // 
            // lblSetNickName
            // 
            this.lblSetNickName.AutoSize = true;
            this.lblSetNickName.Location = new System.Drawing.Point(518, 209);
            this.lblSetNickName.Name = "lblSetNickName";
            this.lblSetNickName.Size = new System.Drawing.Size(107, 13);
            this.lblSetNickName.TabIndex = 12;
            this.lblSetNickName.Text = "Set Your Nick Name:";
            // 
            // btnChangeUserName
            // 
            this.btnChangeUserName.Location = new System.Drawing.Point(682, 242);
            this.btnChangeUserName.Name = "btnChangeUserName";
            this.btnChangeUserName.Size = new System.Drawing.Size(117, 23);
            this.btnChangeUserName.TabIndex = 13;
            this.btnChangeUserName.Text = "Change User Name..";
            this.btnChangeUserName.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(682, 281);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(117, 23);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Change Password..";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // lblChangeUserName
            // 
            this.lblChangeUserName.AutoSize = true;
            this.lblChangeUserName.Location = new System.Drawing.Point(518, 247);
            this.lblChangeUserName.Name = "lblChangeUserName";
            this.lblChangeUserName.Size = new System.Drawing.Size(128, 13);
            this.lblChangeUserName.TabIndex = 15;
            this.lblChangeUserName.Text = "Change Your User Name:";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(518, 286);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(121, 13);
            this.lblChangePassword.TabIndex = 16;
            this.lblChangePassword.Text = "Change Your Password:";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(79, 83);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(116, 13);
            this.lblUserInfo.TabIndex = 17;
            this.lblUserInfo.Text = "User Profile Information";
            // 
            // lblUserConfig
            // 
            this.lblUserConfig.AutoSize = true;
            this.lblUserConfig.Location = new System.Drawing.Point(627, 83);
            this.lblUserConfig.Name = "lblUserConfig";
            this.lblUserConfig.Size = new System.Drawing.Size(94, 13);
            this.lblUserConfig.TabIndex = 18;
            this.lblUserConfig.Text = "User Configuration";
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Image = global::Usuario.Properties.Resources.user;
            this.pbUserPicture.Location = new System.Drawing.Point(351, 12);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(64, 64);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUserPicture.TabIndex = 19;
            this.pbUserPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "  ";
            // 
            // lblActualNickName
            // 
            this.lblActualNickName.AutoSize = true;
            this.lblActualNickName.Location = new System.Drawing.Point(122, 139);
            this.lblActualNickName.Name = "lblActualNickName";
            this.lblActualNickName.Size = new System.Drawing.Size(13, 13);
            this.lblActualNickName.TabIndex = 21;
            this.lblActualNickName.Text = "  ";
            // 
            // lblActualFirstName
            // 
            this.lblActualFirstName.AutoSize = true;
            this.lblActualFirstName.Location = new System.Drawing.Point(122, 177);
            this.lblActualFirstName.Name = "lblActualFirstName";
            this.lblActualFirstName.Size = new System.Drawing.Size(13, 13);
            this.lblActualFirstName.TabIndex = 22;
            this.lblActualFirstName.Text = "  ";
            // 
            // lblActualSecondName
            // 
            this.lblActualSecondName.AutoSize = true;
            this.lblActualSecondName.Location = new System.Drawing.Point(122, 214);
            this.lblActualSecondName.Name = "lblActualSecondName";
            this.lblActualSecondName.Size = new System.Drawing.Size(13, 13);
            this.lblActualSecondName.TabIndex = 23;
            this.lblActualSecondName.Text = "  ";
            // 
            // lblActualFirstSurname
            // 
            this.lblActualFirstSurname.AutoSize = true;
            this.lblActualFirstSurname.Location = new System.Drawing.Point(122, 252);
            this.lblActualFirstSurname.Name = "lblActualFirstSurname";
            this.lblActualFirstSurname.Size = new System.Drawing.Size(13, 13);
            this.lblActualFirstSurname.TabIndex = 24;
            this.lblActualFirstSurname.Text = "  ";
            // 
            // lblActualSecondSurname
            // 
            this.lblActualSecondSurname.AutoSize = true;
            this.lblActualSecondSurname.Location = new System.Drawing.Point(122, 291);
            this.lblActualSecondSurname.Name = "lblActualSecondSurname";
            this.lblActualSecondSurname.Size = new System.Drawing.Size(13, 13);
            this.lblActualSecondSurname.TabIndex = 25;
            this.lblActualSecondSurname.Text = "  ";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Location = new System.Drawing.Point(351, 170);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtNewFirstName.TabIndex = 26;
            // 
            // txtNewSecondName
            // 
            this.txtNewSecondName.Location = new System.Drawing.Point(351, 207);
            this.txtNewSecondName.Name = "txtNewSecondName";
            this.txtNewSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtNewSecondName.TabIndex = 27;
            // 
            // txtNewFirstSurname
            // 
            this.txtNewFirstSurname.Location = new System.Drawing.Point(351, 245);
            this.txtNewFirstSurname.Name = "txtNewFirstSurname";
            this.txtNewFirstSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNewFirstSurname.TabIndex = 28;
            // 
            // txtNewSecondSurname
            // 
            this.txtNewSecondSurname.Location = new System.Drawing.Point(351, 284);
            this.txtNewSecondSurname.Name = "txtNewSecondSurname";
            this.txtNewSecondSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNewSecondSurname.TabIndex = 29;
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(234, 177);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(82, 13);
            this.lblNewFirstName.TabIndex = 30;
            this.lblNewFirstName.Text = "New First Name";
            // 
            // lblNewSecondName
            // 
            this.lblNewSecondName.AutoSize = true;
            this.lblNewSecondName.Location = new System.Drawing.Point(234, 214);
            this.lblNewSecondName.Name = "lblNewSecondName";
            this.lblNewSecondName.Size = new System.Drawing.Size(100, 13);
            this.lblNewSecondName.TabIndex = 31;
            this.lblNewSecondName.Text = "New Second Name";
            // 
            // lblNewFirstSurname
            // 
            this.lblNewFirstSurname.AutoSize = true;
            this.lblNewFirstSurname.Location = new System.Drawing.Point(234, 252);
            this.lblNewFirstSurname.Name = "lblNewFirstSurname";
            this.lblNewFirstSurname.Size = new System.Drawing.Size(96, 13);
            this.lblNewFirstSurname.TabIndex = 32;
            this.lblNewFirstSurname.Text = "New First Surname";
            // 
            // lblNewSecondSurname
            // 
            this.lblNewSecondSurname.AutoSize = true;
            this.lblNewSecondSurname.Location = new System.Drawing.Point(234, 291);
            this.lblNewSecondSurname.Name = "lblNewSecondSurname";
            this.lblNewSecondSurname.Size = new System.Drawing.Size(114, 13);
            this.lblNewSecondSurname.TabIndex = 33;
            this.lblNewSecondSurname.Text = "New Second Surname";
            // 
            // txtNewNickName
            // 
            this.txtNewNickName.Location = new System.Drawing.Point(351, 136);
            this.txtNewNickName.Name = "txtNewNickName";
            this.txtNewNickName.Size = new System.Drawing.Size(100, 20);
            this.txtNewNickName.TabIndex = 34;
            // 
            // lblNewNickName
            // 
            this.lblNewNickName.AutoSize = true;
            this.lblNewNickName.Location = new System.Drawing.Point(234, 139);
            this.lblNewNickName.Name = "lblNewNickName";
            this.lblNewNickName.Size = new System.Drawing.Size(85, 13);
            this.lblNewNickName.TabIndex = 35;
            this.lblNewNickName.Text = "New Nick Name";
            // 
            // btnConfirmInfo
            // 
            this.btnConfirmInfo.Location = new System.Drawing.Point(331, 324);
            this.btnConfirmInfo.Name = "btnConfirmInfo";
            this.btnConfirmInfo.Size = new System.Drawing.Size(120, 23);
            this.btnConfirmInfo.TabIndex = 36;
            this.btnConfirmInfo.Text = "Confirm Information";
            this.btnConfirmInfo.UseVisualStyleBackColor = true;
            this.btnConfirmInfo.Click += new System.EventHandler(this.btnConfirmInfo_Click);
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 359);
            this.Controls.Add(this.btnConfirmInfo);
            this.Controls.Add(this.lblNewNickName);
            this.Controls.Add(this.txtNewNickName);
            this.Controls.Add(this.lblNewSecondSurname);
            this.Controls.Add(this.lblNewFirstSurname);
            this.Controls.Add(this.lblNewSecondName);
            this.Controls.Add(this.lblNewFirstName);
            this.Controls.Add(this.txtNewSecondSurname);
            this.Controls.Add(this.txtNewFirstSurname);
            this.Controls.Add(this.txtNewSecondName);
            this.Controls.Add(this.txtNewFirstName);
            this.Controls.Add(this.lblActualSecondSurname);
            this.Controls.Add(this.lblActualFirstSurname);
            this.Controls.Add(this.lblActualSecondName);
            this.Controls.Add(this.lblActualFirstName);
            this.Controls.Add(this.lblActualNickName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbUserPicture);
            this.Controls.Add(this.lblUserConfig);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.lblChangeUserName);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeUserName);
            this.Controls.Add(this.lblSetNickName);
            this.Controls.Add(this.lblModifyProfile);
            this.Controls.Add(this.lblChangePicture);
            this.Controls.Add(this.lblSecondSurname);
            this.Controls.Add(this.lblFirstSurName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.pbUserConfig);
            this.Controls.Add(this.pbUserInfo);
            this.Controls.Add(this.btnSetNickName);
            this.Controls.Add(this.btnModifyProfile);
            this.Controls.Add(this.btnChangePicture);
            this.Name = "FormUserProfile";
            this.Text = "FormUserProfile";
            this.Load += new System.EventHandler(this.FormUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.Button btnModifyProfile;
        private System.Windows.Forms.Button btnSetNickName;
        private System.Windows.Forms.PictureBox pbUserInfo;
        private System.Windows.Forms.PictureBox pbUserConfig;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstSurName;
        private System.Windows.Forms.Label lblSecondSurname;
        private System.Windows.Forms.Label lblChangePicture;
        private System.Windows.Forms.Label lblModifyProfile;
        private System.Windows.Forms.Label lblSetNickName;
        private System.Windows.Forms.Button btnChangeUserName;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblChangeUserName;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblUserConfig;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblActualNickName;
        private System.Windows.Forms.Label lblActualFirstName;
        private System.Windows.Forms.Label lblActualSecondName;
        private System.Windows.Forms.Label lblActualFirstSurname;
        private System.Windows.Forms.Label lblActualSecondSurname;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.TextBox txtNewSecondName;
        private System.Windows.Forms.TextBox txtNewFirstSurname;
        private System.Windows.Forms.TextBox txtNewSecondSurname;
        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Label lblNewSecondName;
        private System.Windows.Forms.Label lblNewFirstSurname;
        private System.Windows.Forms.Label lblNewSecondSurname;
        private System.Windows.Forms.TextBox txtNewNickName;
        private System.Windows.Forms.Label lblNewNickName;
        private System.Windows.Forms.Button btnConfirmInfo;
    }
}