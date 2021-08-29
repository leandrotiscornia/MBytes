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
            this.lvSessions = new System.Windows.Forms.ListView();
            this.btnJoin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSessionName = new System.Windows.Forms.TextBox();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tcChat = new System.Windows.Forms.TabControl();
            this.tpSessions = new System.Windows.Forms.TabPage();
            this.tpRegisters = new System.Windows.Forms.TabPage();
            this.lvRegisters = new System.Windows.Forms.ListView();
            this.registerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerHostID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionHostID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.tcChat.SuspendLayout();
            this.tpSessions.SuspendLayout();
            this.tpRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSessions
            // 
            this.lvSessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sessionId,
            this.sessionHostID,
            this.sessionHostName,
            this.sessionStartTime});
            this.lvSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSessions.HideSelection = false;
            this.lvSessions.Location = new System.Drawing.Point(3, 3);
            this.lvSessions.Name = "lvSessions";
            this.lvSessions.Size = new System.Drawing.Size(368, 296);
            this.lvSessions.TabIndex = 0;
            this.lvSessions.UseCompatibleStateImageBehavior = false;
            this.lvSessions.View = System.Windows.Forms.View.Tile;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(289, 351);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(96, 46);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join Session";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(402, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // tbSessionName
            // 
            this.tbSessionName.Location = new System.Drawing.Point(586, 38);
            this.tbSessionName.Name = "tbSessionName";
            this.tbSessionName.Size = new System.Drawing.Size(186, 20);
            this.tbSessionName.TabIndex = 3;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(402, 38);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(86, 64);
            this.pbProfilePicture.TabIndex = 4;
            this.pbProfilePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Session Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(701, 351);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 46);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Session";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tcChat
            // 
            this.tcChat.Controls.Add(this.tpSessions);
            this.tcChat.Controls.Add(this.tpRegisters);
            this.tcChat.Location = new System.Drawing.Point(3, 17);
            this.tcChat.Name = "tcChat";
            this.tcChat.SelectedIndex = 0;
            this.tcChat.Size = new System.Drawing.Size(382, 328);
            this.tcChat.TabIndex = 7;
            this.tcChat.SelectedIndexChanged += new System.EventHandler(this.tcChat_SelectedIndexChanged);
            // 
            // tpSessions
            // 
            this.tpSessions.Controls.Add(this.lvSessions);
            this.tpSessions.Location = new System.Drawing.Point(4, 22);
            this.tpSessions.Name = "tpSessions";
            this.tpSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tpSessions.Size = new System.Drawing.Size(374, 302);
            this.tpSessions.TabIndex = 0;
            this.tpSessions.Text = "Sessions";
            this.tpSessions.UseVisualStyleBackColor = true;
            // 
            // tpRegisters
            // 
            this.tpRegisters.Controls.Add(this.lvRegisters);
            this.tpRegisters.Location = new System.Drawing.Point(4, 22);
            this.tpRegisters.Name = "tpRegisters";
            this.tpRegisters.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegisters.Size = new System.Drawing.Size(374, 302);
            this.tpRegisters.TabIndex = 1;
            this.tpRegisters.Text = "Registers";
            this.tpRegisters.UseVisualStyleBackColor = true;
            // 
            // lvRegisters
            // 
            this.lvRegisters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registerID,
            this.registerName,
            this.registerHostID,
            this.registerStartTime,
            this.registerEndTime});
            this.lvRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRegisters.HideSelection = false;
            this.lvRegisters.Location = new System.Drawing.Point(3, 3);
            this.lvRegisters.Name = "lvRegisters";
            this.lvRegisters.Size = new System.Drawing.Size(368, 296);
            this.lvRegisters.TabIndex = 1;
            this.lvRegisters.UseCompatibleStateImageBehavior = false;
            this.lvRegisters.View = System.Windows.Forms.View.Tile;
            // 
            // registerName
            // 
            this.registerName.DisplayIndex = 0;
            // 
            // registerHostID
            // 
            this.registerHostID.DisplayIndex = 1;
            // 
            // registerStartTime
            // 
            this.registerStartTime.DisplayIndex = 2;
            // 
            // registerEndTime
            // 
            this.registerEndTime.DisplayIndex = 3;
            // 
            // sessionHostID
            // 
            this.sessionHostID.DisplayIndex = 0;
            // 
            // sessionHostName
            // 
            this.sessionHostName.DisplayIndex = 1;
            // 
            // sessionStartTime
            // 
            this.sessionStartTime.DisplayIndex = 2;
            // 
            // UserControlChatMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcChat);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.tbSessionName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJoin);
            this.Name = "UserControlChatMainPanel";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlChatMainPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.tcChat.ResumeLayout(false);
            this.tpSessions.ResumeLayout(false);
            this.tpRegisters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSessions;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSessionName;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tcChat;
        private System.Windows.Forms.TabPage tpSessions;
        private System.Windows.Forms.TabPage tpRegisters;
        private System.Windows.Forms.ListView lvRegisters;
        private System.Windows.Forms.ColumnHeader sessionId;
        private System.Windows.Forms.ColumnHeader sessionHostID;
        private System.Windows.Forms.ColumnHeader sessionHostName;
        private System.Windows.Forms.ColumnHeader sessionStartTime;
        private System.Windows.Forms.ColumnHeader registerID;
        private System.Windows.Forms.ColumnHeader registerName;
        private System.Windows.Forms.ColumnHeader registerHostID;
        private System.Windows.Forms.ColumnHeader registerStartTime;
        private System.Windows.Forms.ColumnHeader registerEndTime;
    }
}
