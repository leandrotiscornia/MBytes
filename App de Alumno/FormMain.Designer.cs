namespace App_De_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lvNavigation = new System.Windows.Forms.ListView();
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btHelp = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnInscriptions = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlFunction
            // 
            resources.ApplyResources(this.pnlFunction, "pnlFunction");
            this.pnlFunction.Name = "pnlFunction";
            // 
            // lvNavigation
            // 
            resources.ApplyResources(this.lvNavigation, "lvNavigation");
            this.lvNavigation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvNavigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Function});
            this.lvNavigation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lvNavigation.HideSelection = false;
            this.lvNavigation.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvNavigation.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvNavigation.Items1")))});
            this.lvNavigation.MultiSelect = false;
            this.lvNavigation.Name = "lvNavigation";
            this.lvNavigation.UseCompatibleStateImageBehavior = false;
            this.lvNavigation.View = System.Windows.Forms.View.Details;
            this.lvNavigation.SelectedIndexChanged += new System.EventHandler(this.lvNavigation_SelectedIndexChanged);
            // 
            // Function
            // 
            resources.ApplyResources(this.Function, "Function");
            // 
            // btHelp
            // 
            resources.ApplyResources(this.btHelp, "btHelp");
            this.btHelp.Name = "btHelp";
            this.btHelp.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            resources.ApplyResources(this.btnProfile, "btnProfile");
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnInscriptions
            // 
            resources.ApplyResources(this.btnInscriptions, "btnInscriptions");
            this.btnInscriptions.Name = "btnInscriptions";
            this.btnInscriptions.UseVisualStyleBackColor = true;
            this.btnInscriptions.Click += new System.EventHandler(this.btnInscriptions_Click);
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.btnInscriptions);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.lvNavigation);
            this.Controls.Add(this.pnlFunction);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.ListView lvNavigation;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnInscriptions;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label1;
    }
}