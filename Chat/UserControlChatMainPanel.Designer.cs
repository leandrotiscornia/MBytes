using Negocio;

namespace Chat
{
    partial class UserControlChatMainPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCreateNewChatSession = new System.Windows.Forms.Button();
            this.btnViewExistingSessions = new System.Windows.Forms.Button();
            this.lbConnected = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnCreateNewChatSession
            // 
            this.btnCreateNewChatSession.Location = new System.Drawing.Point(333, 110);
            this.btnCreateNewChatSession.Name = "btnCreateNewChatSession";
            this.btnCreateNewChatSession.Size = new System.Drawing.Size(182, 65);
            this.btnCreateNewChatSession.TabIndex = 1;
            this.btnCreateNewChatSession.Text = "Create New Chat Session";
            this.btnCreateNewChatSession.UseVisualStyleBackColor = true;
            this.btnCreateNewChatSession.Click += new System.EventHandler(this.btnCreateNewChatSession_Click);
            // 
            // btnViewExistingSessions
            // 
            this.btnViewExistingSessions.Location = new System.Drawing.Point(333, 240);
            this.btnViewExistingSessions.Name = "btnViewExistingSessions";
            this.btnViewExistingSessions.Size = new System.Drawing.Size(182, 73);
            this.btnViewExistingSessions.TabIndex = 2;
            this.btnViewExistingSessions.Text = "View Existing Sessions";
            this.btnViewExistingSessions.UseVisualStyleBackColor = true;
            // 
            // lbConnected
            // 
            this.lbConnected.AutoSize = true;
            this.lbConnected.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnected.Location = new System.Drawing.Point(46, 59);
            this.lbConnected.Name = "lbConnected";
            this.lbConnected.Size = new System.Drawing.Size(61, 16);
            this.lbConnected.TabIndex = 4;
            this.lbConnected.Text = "Conected ";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AllowDrop = true;
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(40, 16);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(35, 17);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.UseCompatibleTextRendering = true;
            // 
            // UserControlChatMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbConnected);
            this.Controls.Add(this.btnViewExistingSessions);
            this.Controls.Add(this.btnCreateNewChatSession);
            this.Controls.Add(this.listView1);
            this.Name = "UserControlChatMainPanel";
            this.Size = new System.Drawing.Size(597, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnCreateNewChatSession;
        private System.Windows.Forms.Button btnViewExistingSessions;
        private System.Windows.Forms.Label lbConnected;
        private System.Windows.Forms.Label lbWelcome;
    }
}
