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
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(261, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Add Consult";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessageEditConsult
            // 
            this.lbMessageEditConsult.AutoSize = true;
            this.lbMessageEditConsult.Location = new System.Drawing.Point(13, 231);
            this.lbMessageEditConsult.Name = "lbMessageEditConsult";
            this.lbMessageEditConsult.Size = new System.Drawing.Size(53, 13);
            this.lbMessageEditConsult.TabIndex = 12;
            this.lbMessageEditConsult.Text = "Message:";
            // 
            // lbPreviousEditConsult
            // 
            this.lbPreviousEditConsult.AutoSize = true;
            this.lbPreviousEditConsult.Location = new System.Drawing.Point(12, 60);
            this.lbPreviousEditConsult.Name = "lbPreviousEditConsult";
            this.lbPreviousEditConsult.Size = new System.Drawing.Size(48, 13);
            this.lbPreviousEditConsult.TabIndex = 11;
            this.lbPreviousEditConsult.Text = "Previous";
            // 
            // tbNewMessage
            // 
            this.tbNewMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMessage.Location = new System.Drawing.Point(72, 228);
            this.tbNewMessage.Multiline = true;
            this.tbNewMessage.Name = "tbNewMessage";
            this.tbNewMessage.Size = new System.Drawing.Size(293, 93);
            this.tbNewMessage.TabIndex = 10;
            // 
            // lbTopicEditConsult
            // 
            this.lbTopicEditConsult.AutoSize = true;
            this.lbTopicEditConsult.Location = new System.Drawing.Point(29, 34);
            this.lbTopicEditConsult.Name = "lbTopicEditConsult";
            this.lbTopicEditConsult.Size = new System.Drawing.Size(37, 13);
            this.lbTopicEditConsult.TabIndex = 8;
            this.lbTopicEditConsult.Text = "Topic:";
            // 
            // tbTopic
            // 
            this.tbTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTopic.Enabled = false;
            this.tbTopic.Location = new System.Drawing.Point(72, 31);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 7;
            // 
            // btnFileConsult
            // 
            this.btnFileConsult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFileConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileConsult.Location = new System.Drawing.Point(72, 345);
            this.btnFileConsult.Name = "btnFileConsult";
            this.btnFileConsult.Size = new System.Drawing.Size(104, 23);
            this.btnFileConsult.TabIndex = 14;
            this.btnFileConsult.Text = "File Consult";
            this.btnFileConsult.UseVisualStyleBackColor = false;
            this.btnFileConsult.Click += new System.EventHandler(this.btnFileConsult_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Location = new System.Drawing.Point(72, 60);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(293, 162);
            this.rtbMessages.TabIndex = 15;
            this.rtbMessages.Text = "";
            // 
            // UserControlEditConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(400, 400);
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
