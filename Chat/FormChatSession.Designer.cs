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
            this.messageHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // messageHost
            // 
            this.messageHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageHost.Location = new System.Drawing.Point(0, 0);
            this.messageHost.Name = "messageHost";
            this.messageHost.Size = new System.Drawing.Size(703, 707);
            this.messageHost.TabIndex = 0;
            this.messageHost.Text = "elementHost1";
            this.messageHost.Child = null;
            // 
            // FormChatSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 707);
            this.Controls.Add(this.messageHost);
            this.Name = "FormChatSession";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChatSession_FormClosing);
            this.Load += new System.EventHandler(this.FormChatSession_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost messageHost;
    }
}

