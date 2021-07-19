namespace Consultas
{
    partial class UserControlConsultsMainPanel
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
            this.tabControlConsults.Controls.Add(this.tabPageNewConsult);
            this.tabControlConsults.Controls.Add(this.tabPageConsultsMade);
            this.tabControlConsults.Controls.Add(this.tabPageConsultsFiled);
            this.tabControlConsults.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlConsults.Location = new System.Drawing.Point(0, 0);
            this.tabControlConsults.Name = "tabControlConsults";
            this.tabControlConsults.SelectedIndex = 0;
            this.tabControlConsults.Size = new System.Drawing.Size(386, 400);
            this.tabControlConsults.TabIndex = 0;
            this.tabControlConsults.SelectedIndexChanged += new System.EventHandler(this.tabControlConsults_SelectedIndexChanged);
            // 
            // tabPageNewConsult
            // 
            this.tabPageNewConsult.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewConsult.Name = "tabPageNewConsult";
            this.tabPageNewConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewConsult.Size = new System.Drawing.Size(378, 374);
            this.tabPageNewConsult.TabIndex = 0;
            this.tabPageNewConsult.Text = "New Consult";
            this.tabPageNewConsult.UseVisualStyleBackColor = true;
            // 
            // tabPageConsultsMade
            // 
            this.tabPageConsultsMade.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultsMade.Name = "tabPageConsultsMade";
            this.tabPageConsultsMade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultsMade.Size = new System.Drawing.Size(378, 374);
            this.tabPageConsultsMade.TabIndex = 1;
            this.tabPageConsultsMade.Text = "Consults Done";
            this.tabPageConsultsMade.UseVisualStyleBackColor = true;
            // 
            // tabPageConsultsFiled
            // 
            this.tabPageConsultsFiled.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultsFiled.Name = "tabPageConsultsFiled";
            this.tabPageConsultsFiled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultsFiled.Size = new System.Drawing.Size(378, 374);
            this.tabPageConsultsFiled.TabIndex = 2;
            this.tabPageConsultsFiled.Text = "Consults Filed";
            this.tabPageConsultsFiled.UseVisualStyleBackColor = true;
            // 
            // pnlConsults
            // 
            this.pnlConsults.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConsults.Location = new System.Drawing.Point(401, 0);
            this.pnlConsults.Name = "pnlConsults";
            this.pnlConsults.Size = new System.Drawing.Size(399, 400);
            this.pnlConsults.TabIndex = 1;
            // 
            // UserControlConsultsMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConsults);
            this.Controls.Add(this.tabControlConsults);
            this.Name = "UserControlConsultsMainPanel";
            this.Size = new System.Drawing.Size(800, 400);
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
