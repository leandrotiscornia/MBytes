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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lvNavigation = new System.Windows.Forms.ListView();
            this.Funcionalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.lvNavigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Funcionalidad});
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
            // Funcionalidad
            // 
            resources.ApplyResources(this.Funcionalidad, "Funcionalidad");
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanguage);
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
        private System.Windows.Forms.ColumnHeader Funcionalidad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label1;
    }
}