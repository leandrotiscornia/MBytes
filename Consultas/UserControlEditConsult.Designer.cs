namespace Consultas
{
    partial class UserControlEditConsult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEditConsult));
            this.btnSend = new System.Windows.Forms.Button();
            this.lbMessageEditConsult = new System.Windows.Forms.Label();
            this.lbPreviousEditConsult = new System.Windows.Forms.Label();
            this.tbNewMessage = new System.Windows.Forms.TextBox();
            this.lbTopicEditConsult = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.btnFileConsult = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessageEditConsult
            // 
            resources.ApplyResources(this.lbMessageEditConsult, "lbMessageEditConsult");
            this.lbMessageEditConsult.Name = "lbMessageEditConsult";
            this.lbMessageEditConsult.Click += new System.EventHandler(this.lbMessageEditConsult_Click);
            // 
            // lbPreviousEditConsult
            // 
            resources.ApplyResources(this.lbPreviousEditConsult, "lbPreviousEditConsult");
            this.lbPreviousEditConsult.Name = "lbPreviousEditConsult";
            // 
            // tbNewMessage
            // 
            resources.ApplyResources(this.tbNewMessage, "tbNewMessage");
            this.tbNewMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMessage.Name = "tbNewMessage";
            // 
            // lbTopicEditConsult
            // 
            resources.ApplyResources(this.lbTopicEditConsult, "lbTopicEditConsult");
            this.lbTopicEditConsult.Name = "lbTopicEditConsult";
            // 
            // tbTopic
            // 
            resources.ApplyResources(this.tbTopic, "tbTopic");
            this.tbTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            // 
            // btnFileConsult
            // 
            resources.ApplyResources(this.btnFileConsult, "btnFileConsult");
            this.btnFileConsult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFileConsult.Name = "btnFileConsult";
            this.btnFileConsult.UseVisualStyleBackColor = false;
            this.btnFileConsult.Click += new System.EventHandler(this.btnFileConsult_Click);
            // 
            // rtbMessages
            // 
            resources.ApplyResources(this.rtbMessages, "rtbMessages");
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            // 
            // UserControlEditConsult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnFileConsult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessageEditConsult);
            this.Controls.Add(this.lbPreviousEditConsult);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopicEditConsult);
            this.Controls.Add(this.tbTopic);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "UserControlEditConsult";
            this.Load += new System.EventHandler(this.UserControlEditConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbMessageEditConsult;
        private System.Windows.Forms.Label lbPreviousEditConsult;
        private System.Windows.Forms.TextBox tbNewMessage;
        private System.Windows.Forms.Label lbTopicEditConsult;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Button btnFileConsult;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}
