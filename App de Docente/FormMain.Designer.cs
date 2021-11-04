namespace App_de_Docente
{
    partial class FormMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Schedule");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Chat");
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lvNavigation = new System.Windows.Forms.ListView();
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnInscriptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFunction
            // 
            this.pnlFunction.Location = new System.Drawing.Point(149, 70);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(800, 400);
            this.pnlFunction.TabIndex = 0;
            // 
            // lvNavigation
            // 
            this.lvNavigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Function});
            this.lvNavigation.HideSelection = false;
            this.lvNavigation.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvNavigation.Location = new System.Drawing.Point(12, 70);
            this.lvNavigation.Name = "lvNavigation";
            this.lvNavigation.Size = new System.Drawing.Size(121, 400);
            this.lvNavigation.TabIndex = 1;
            this.lvNavigation.UseCompatibleStateImageBehavior = false;
            this.lvNavigation.View = System.Windows.Forms.View.Details;
            this.lvNavigation.SelectedIndexChanged += new System.EventHandler(this.lvNavigation_SelectedIndexChanged);
            // 
            // Function
            // 
            this.Function.Text = "Function";
            this.Function.Width = 124;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Location = new System.Drawing.Point(714, 27);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguration.TabIndex = 2;
            this.btnConfiguration.Text = "Config";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(795, 27);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(876, 27);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnInscriptions
            // 
            this.btnInscriptions.Location = new System.Drawing.Point(633, 27);
            this.btnInscriptions.Name = "btnInscriptions";
            this.btnInscriptions.Size = new System.Drawing.Size(75, 23);
            this.btnInscriptions.TabIndex = 6;
            this.btnInscriptions.Text = "Inscriptions";
            this.btnInscriptions.UseVisualStyleBackColor = true;
            this.btnInscriptions.Click += new System.EventHandler(this.btnInscriptions_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 498);
            this.Controls.Add(this.btnInscriptions);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.lvNavigation);
            this.Controls.Add(this.pnlFunction);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.ListView lvNavigation;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnInscriptions;
    }
}