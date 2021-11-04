namespace App_de_Admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Management");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Authorization");
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lvNavigation = new System.Windows.Forms.ListView();
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfiguaration = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.lvNavigation.MultiSelect = false;
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
            // btnConfiguaration
            // 
            this.btnConfiguaration.Location = new System.Drawing.Point(714, 27);
            this.btnConfiguaration.Name = "btnConfiguaration";
            this.btnConfiguaration.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguaration.TabIndex = 2;
            this.btnConfiguaration.Text = "Config";
            this.btnConfiguaration.UseVisualStyleBackColor = true;
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(795, 27);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(75, 23);
            this.btHelp.TabIndex = 3;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(876, 27);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Modify Data";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 498);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btnConfiguaration);
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
        private System.Windows.Forms.Button btnConfiguaration;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Timer timer1;
    }
}