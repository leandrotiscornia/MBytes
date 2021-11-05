namespace Consultas
{
    partial class UserControlWriteConsult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWriteConsult));
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbNewMessage = new System.Windows.Forms.TextBox();
            this.lbMessageWriteConsult = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTopic
            // 
            resources.ApplyResources(this.tbTopic, "tbTopic");
            this.tbTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTopic.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTopic.Name = "tbTopic";
            // 
            // lbTopic
            // 
            resources.ApplyResources(this.lbTopic, "lbTopic");
            this.lbTopic.Name = "lbTopic";
            // 
            // tbNewMessage
            // 
            resources.ApplyResources(this.tbNewMessage, "tbNewMessage");
            this.tbNewMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNewMessage.Name = "tbNewMessage";
            // 
            // lbMessageWriteConsult
            // 
            resources.ApplyResources(this.lbMessageWriteConsult, "lbMessageWriteConsult");
            this.lbMessageWriteConsult.Name = "lbMessageWriteConsult";
            this.lbMessageWriteConsult.Click += new System.EventHandler(this.lbMessageWriteConsult_Click);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UserControlWriteConsult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessageWriteConsult);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "UserControlWriteConsult";
            this.Load += new System.EventHandler(this.UserControlWriteConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbNewMessage;
        private System.Windows.Forms.Label lbMessageWriteConsult;
        private System.Windows.Forms.Button btnSend;
    }
}
