namespace Agenda
{
    partial class FormOpenConsult
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
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbPrevious = new System.Windows.Forms.Label();
            this.tbNewMessage = new System.Windows.Forms.TextBox();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(80, 55);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(293, 162);
            this.rtbMessages.TabIndex = 23;
            this.rtbMessages.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(269, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Add Consult";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(21, 226);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(53, 13);
            this.lbMessage.TabIndex = 20;
            this.lbMessage.Text = "Message:";
            // 
            // lbPrevious
            // 
            this.lbPrevious.AutoSize = true;
            this.lbPrevious.Location = new System.Drawing.Point(20, 55);
            this.lbPrevious.Name = "lbPrevious";
            this.lbPrevious.Size = new System.Drawing.Size(48, 13);
            this.lbPrevious.TabIndex = 19;
            this.lbPrevious.Text = "Previous";
            // 
            // tbNewMessage
            // 
            this.tbNewMessage.Location = new System.Drawing.Point(80, 223);
            this.tbNewMessage.Multiline = true;
            this.tbNewMessage.Name = "tbNewMessage";
            this.tbNewMessage.Size = new System.Drawing.Size(293, 93);
            this.tbNewMessage.TabIndex = 18;
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Location = new System.Drawing.Point(37, 29);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(37, 13);
            this.lbTopic.TabIndex = 17;
            this.lbTopic.Text = "Topic:";
            // 
            // tbTopic
            // 
            this.tbTopic.Enabled = false;
            this.tbTopic.Location = new System.Drawing.Point(80, 26);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 16;
            // 
            // FormOpenConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 402);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbPrevious);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.Name = "FormOpenConsult";
            this.Text = "FormOpenConsult";
            this.Load += new System.EventHandler(this.FormOpenConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbPrevious;
        private System.Windows.Forms.TextBox tbNewMessage;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbTopic;
    }
}