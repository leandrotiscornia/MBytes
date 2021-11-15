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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlChatMainPanel));
            this.lvSessions = new System.Windows.Forms.ListView();
            this.sessionHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionHostID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HostCI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnJoin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.CI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.tcChat.SuspendLayout();
            this.tpSessions.SuspendLayout();
            this.tpRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSessions
            // 
            resources.ApplyResources(this.lvSessions, "lvSessions");
            this.lvSessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sessionHostName,
            this.sessionId,
            this.sessionHostID,
            this.sessionStartTime,
            this.HostCI});
            this.lvSessions.HideSelection = false;
            this.lvSessions.Name = "lvSessions";
            this.lvSessions.UseCompatibleStateImageBehavior = false;
            this.lvSessions.View = System.Windows.Forms.View.Tile;
            // 
            // sessionHostName
            // 
            resources.ApplyResources(this.sessionHostName, "sessionHostName");
            // 
            // sessionId
            // 
            resources.ApplyResources(this.sessionId, "sessionId");
            // 
            // sessionHostID
            // 
            resources.ApplyResources(this.sessionHostID, "sessionHostID");
            // 
            // sessionStartTime
            // 
            resources.ApplyResources(this.sessionStartTime, "sessionStartTime");
            // 
            // HostCI
            // 
            resources.ApplyResources(this.HostCI, "HostCI");
            // 
            // btnJoin
            // 
            resources.ApplyResources(this.btnJoin, "btnJoin");
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSubjects);
            this.groupBox1.Controls.Add(this.cbGroups);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbSubjects
            // 
            resources.ApplyResources(this.cbSubjects, "cbSubjects");
            this.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Name = "cbSubjects";
            // 
            // cbGroups
            // 
            resources.ApplyResources(this.cbGroups, "cbGroups");
            this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbSessionName
            // 
            resources.ApplyResources(this.tbSessionName, "tbSessionName");
            this.tbSessionName.Name = "tbSessionName";
            // 
            // pbProfilePicture
            // 
            resources.ApplyResources(this.pbProfilePicture, "pbProfilePicture");
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tcChat
            // 
            resources.ApplyResources(this.tcChat, "tcChat");
            this.tcChat.Controls.Add(this.tpSessions);
            this.tcChat.Controls.Add(this.tpRegisters);
            this.tcChat.Name = "tcChat";
            this.tcChat.SelectedIndex = 0;
            this.tcChat.SelectedIndexChanged += new System.EventHandler(this.tcChat_SelectedIndexChanged);
            // 
            // tpSessions
            // 
            resources.ApplyResources(this.tpSessions, "tpSessions");
            this.tpSessions.Controls.Add(this.lvSessions);
            this.tpSessions.Name = "tpSessions";
            this.tpSessions.UseVisualStyleBackColor = true;
            // 
            // tpRegisters
            // 
            resources.ApplyResources(this.tpRegisters, "tpRegisters");
            this.tpRegisters.Controls.Add(this.lvRegisters);
            this.tpRegisters.Name = "tpRegisters";
            this.tpRegisters.UseVisualStyleBackColor = true;
            // 
            // lvRegisters
            // 
            resources.ApplyResources(this.lvRegisters, "lvRegisters");
            this.lvRegisters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registerID,
            this.registerName,
            this.registerHostID,
            this.registerStartTime,
            this.registerEndTime,
            this.CI});
            this.lvRegisters.HideSelection = false;
            this.lvRegisters.Name = "lvRegisters";
            this.lvRegisters.UseCompatibleStateImageBehavior = false;
            // 
            // registerID
            // 
            resources.ApplyResources(this.registerID, "registerID");
            // 
            // registerName
            // 
            resources.ApplyResources(this.registerName, "registerName");
            // 
            // registerHostID
            // 
            resources.ApplyResources(this.registerHostID, "registerHostID");
            // 
            // registerStartTime
            // 
            resources.ApplyResources(this.registerStartTime, "registerStartTime");
            // 
            // registerEndTime
            // 
            resources.ApplyResources(this.registerEndTime, "registerEndTime");
            // 
            // CI
            // 
            resources.ApplyResources(this.CI, "CI");
            // 
            // UserControlChatMainPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcChat);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.tbSessionName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJoin);
            this.Name = "UserControlChatMainPanel";
            this.Load += new System.EventHandler(this.UserControlChatMainPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.ColumnHeader HostCI;
        private System.Windows.Forms.ColumnHeader CI;
    }
}
