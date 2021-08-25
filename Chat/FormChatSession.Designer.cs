using System;

namespace Chat
{
    partial class FormChatSession
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbWriteMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rtbReadMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbWriteMessage
            // 
            this.txbWriteMessage.Location = new System.Drawing.Point(12, 286);
            this.txbWriteMessage.Name = "txbWriteMessage";
            this.txbWriteMessage.Size = new System.Drawing.Size(347, 20);
            this.txbWriteMessage.TabIndex = 3;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(131, 329);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(90, 25);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // rtbReadMessages
            // 
            this.rtbReadMessages.Location = new System.Drawing.Point(12, 26);
            this.rtbReadMessages.Name = "rtbReadMessages";
            this.rtbReadMessages.Size = new System.Drawing.Size(347, 223);
            this.rtbReadMessages.TabIndex = 2;
            this.rtbReadMessages.Text = "";

            // 
            // ChatSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 395);
            this.Controls.Add(this.rtbReadMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txbWriteMessage);
            this.Name = "ChatSession";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWriteMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.RichTextBox rtbReadMessages;

    }
}

