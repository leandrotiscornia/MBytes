namespace Agenda
{
    partial class FormOpenConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpenConsultation));
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
            resources.ApplyResources(this.rtbMessages, "rtbMessages");
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessage
            // 
            resources.ApplyResources(this.lbMessage, "lbMessage");
            this.lbMessage.Name = "lbMessage";
            // 
            // lbPrevious
            // 
            resources.ApplyResources(this.lbPrevious, "lbPrevious");
            this.lbPrevious.Name = "lbPrevious";
            // 
            // tbNewMessage
            // 
            resources.ApplyResources(this.tbNewMessage, "tbNewMessage");
            this.tbNewMessage.Name = "tbNewMessage";
            // 
            // lbTopic
            // 
            resources.ApplyResources(this.lbTopic, "lbTopic");
            this.lbTopic.Name = "lbTopic";
            // 
            // tbTopic
            // 
            resources.ApplyResources(this.tbTopic, "tbTopic");
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            // 
            // FormOpenConsultation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbPrevious);
            this.Controls.Add(this.tbNewMessage);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.Name = "FormOpenConsultation";
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