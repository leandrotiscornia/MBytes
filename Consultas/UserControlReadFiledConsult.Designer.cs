namespace Consultas
{
    partial class UserControlReadFiledConsult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReadFiledConsult));
            this.lbPreviousFiled = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbPreviousFiled
            // 
            resources.ApplyResources(this.lbPreviousFiled, "lbPreviousFiled");
            this.lbPreviousFiled.Name = "lbPreviousFiled";
            // 
            // lbTopic
            // 
            resources.ApplyResources(this.lbTopic, "lbTopic");
            this.lbTopic.Name = "lbTopic";
            // 
            // tbTopic
            // 
            resources.ApplyResources(this.tbTopic, "tbTopic");
            this.tbTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTopic.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            // 
            // rtbMessages
            // 
            resources.ApplyResources(this.rtbMessages, "rtbMessages");
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            // 
            // UserControlReadFiledConsult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.lbPreviousFiled);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "UserControlReadFiledConsult";
            this.Load += new System.EventHandler(this.UserControlReadFiledConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPreviousFiled;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}
