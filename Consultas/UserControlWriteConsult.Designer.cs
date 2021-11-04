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
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbNewMessage = new System.Windows.Forms.TextBox();
            this.lbMessageWriteConsult = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTopic
            // 
            this.tbTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTopic.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTopic.Location = new System.Drawing.Point(71, 38);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 0;
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Location = new System.Drawing.Point(28, 41);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(37, 13);
            this.lbTopic.TabIndex = 1;
            this.lbTopic.Text = "Topic:";
            // 
            // tbNewMessage
            // 
            this.tbNewMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNewMessage.Location = new System.Drawing.Point(71, 75);
            this.tbNewMessage.Multiline = true;
            this.tbNewMessage.Name = "tbNewMessage";
            this.tbNewMessage.Size = new System.Drawing.Size(293, 271);
            this.tbNewMessage.TabIndex = 3;
            // 
            // lbMessageWriteConsult
            // 
            this.lbMessageWriteConsult.AutoSize = true;
            this.lbMessageWriteConsult.Location = new System.Drawing.Point(12, 78);
            this.lbMessageWriteConsult.Name = "lbMessageWriteConsult";
            this.lbMessageWriteConsult.Size = new System.Drawing.Size(53, 13);
            this.lbMessageWriteConsult.TabIndex = 5;
            this.lbMessageWriteConsult.Text = "Message:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(260, 352);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send Consult";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UserControlWriteConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessageWriteConsult);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "UserControlWriteConsult";
            this.Size = new System.Drawing.Size(400, 400);
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
