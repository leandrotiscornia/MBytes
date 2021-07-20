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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewMessage = new System.Windows.Forms.TextBox();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.btnFileConsult = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(261, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Add Consult";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Message:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Previous";
            // 
            // tbNewMessage
            // 
            this.tbNewMessage.Location = new System.Drawing.Point(72, 228);
            this.tbNewMessage.Multiline = true;
            this.tbNewMessage.Name = "tbNewMessage";
            this.tbNewMessage.Size = new System.Drawing.Size(293, 93);
            this.tbNewMessage.TabIndex = 10;
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Location = new System.Drawing.Point(29, 34);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(37, 13);
            this.lbTopic.TabIndex = 8;
            this.lbTopic.Text = "Topic:";
            // 
            // tbTopic
            // 
            this.tbTopic.Enabled = false;
            this.tbTopic.Location = new System.Drawing.Point(72, 31);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 7;
            // 
            // btnFileConsult
            // 
            this.btnFileConsult.Location = new System.Drawing.Point(72, 345);
            this.btnFileConsult.Name = "btnFileConsult";
            this.btnFileConsult.Size = new System.Drawing.Size(104, 23);
            this.btnFileConsult.TabIndex = 14;
            this.btnFileConsult.Text = "File Consult";
            this.btnFileConsult.UseVisualStyleBackColor = true;
            this.btnFileConsult.Click += new System.EventHandler(this.btnFileConsult_Click);
            // 
            // rtbMessages
            // 
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
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnFileConsult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.Name = "UserControlEditConsult";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlEditConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewMessage;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Button btnFileConsult;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}
