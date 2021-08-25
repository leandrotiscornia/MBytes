using Negocio;

namespace Chat
{
    partial class UserControlNewChatSession
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
            this.lbNewSession = new System.Windows.Forms.Label();
            this.tabNewChatSession = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbpChangeling = new System.Windows.Forms.TabPage();
            this.tabNewChatSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNewSession
            // 
            this.lbNewSession.AutoSize = true;
            this.lbNewSession.Location = new System.Drawing.Point(33, 24);
            this.lbNewSession.Name = "lbNewSession";
            this.lbNewSession.Size = new System.Drawing.Size(69, 13);
            this.lbNewSession.TabIndex = 0;
            this.lbNewSession.Text = "New Session";
            // 
            // tabNewChatSession
            // 
            this.tabNewChatSession.Controls.Add(this.tabPage1);
            this.tabNewChatSession.Controls.Add(this.tbpChangeling);
            this.tabNewChatSession.Location = new System.Drawing.Point(30, 59);
            this.tabNewChatSession.Name = "tabNewChatSession";
            this.tabNewChatSession.SelectedIndex = 0;
            this.tabNewChatSession.Size = new System.Drawing.Size(191, 299);
            this.tabNewChatSession.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(183, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subject";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbpChangeling
            // 
            this.tbpChangeling.Location = new System.Drawing.Point(4, 22);
            this.tbpChangeling.Name = "tbpChangeling";
            this.tbpChangeling.Padding = new System.Windows.Forms.Padding(3);
            this.tbpChangeling.Size = new System.Drawing.Size(183, 273);
            this.tbpChangeling.TabIndex = 1;
            this.tbpChangeling.UseVisualStyleBackColor = true;
            this.tbpChangeling.Click += new System.EventHandler(this.tbpChangeling_Click);
            // 
            // UserControlNewChatSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNewChatSession);
            this.Controls.Add(this.lbNewSession);
            this.Name = "UserControlNewChatSession";
            this.Size = new System.Drawing.Size(250, 377);
            this.tabNewChatSession.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewSession;
        private System.Windows.Forms.TabControl tabNewChatSession;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbpChangeling;
    }
}
