namespace Consultas
{
    partial class UserControlConsultationsMainPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlConsultationsMainPanel));
            this.tabControlConsults = new System.Windows.Forms.TabControl();
            this.tabPageNewConsult = new System.Windows.Forms.TabPage();
            this.tabPageConsultsMade = new System.Windows.Forms.TabPage();
            this.tabPageConsultsFiled = new System.Windows.Forms.TabPage();
            this.pnlConsults = new System.Windows.Forms.Panel();
            this.tabControlConsults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConsults
            // 
            resources.ApplyResources(this.tabControlConsults, "tabControlConsults");
            this.tabControlConsults.Controls.Add(this.tabPageNewConsult);
            this.tabControlConsults.Controls.Add(this.tabPageConsultsMade);
            this.tabControlConsults.Controls.Add(this.tabPageConsultsFiled);
            this.tabControlConsults.Name = "tabControlConsults";
            this.tabControlConsults.SelectedIndex = 0;
            this.tabControlConsults.SelectedIndexChanged += new System.EventHandler(this.tabControlConsults_SelectedIndexChanged);
            // 
            // tabPageNewConsult
            // 
            resources.ApplyResources(this.tabPageNewConsult, "tabPageNewConsult");
            this.tabPageNewConsult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageNewConsult.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPageNewConsult.Name = "tabPageNewConsult";
            // 
            // tabPageConsultsMade
            // 
            resources.ApplyResources(this.tabPageConsultsMade, "tabPageConsultsMade");
            this.tabPageConsultsMade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageConsultsMade.Name = "tabPageConsultsMade";
            // 
            // tabPageConsultsFiled
            // 
            resources.ApplyResources(this.tabPageConsultsFiled, "tabPageConsultsFiled");
            this.tabPageConsultsFiled.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageConsultsFiled.Name = "tabPageConsultsFiled";
            // 
            // pnlConsults
            // 
            resources.ApplyResources(this.pnlConsults, "pnlConsults");
            this.pnlConsults.Name = "pnlConsults";
            // 
            // UserControlConsultationsMainPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pnlConsults);
            this.Controls.Add(this.tabControlConsults);
            this.Name = "UserControlConsultationsMainPanel";
            this.tabControlConsults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConsults;
        private System.Windows.Forms.TabPage tabPageNewConsult;
        private System.Windows.Forms.TabPage tabPageConsultsMade;
        private System.Windows.Forms.TabPage tabPageConsultsFiled;
        private System.Windows.Forms.Panel pnlConsults;
    }
}
