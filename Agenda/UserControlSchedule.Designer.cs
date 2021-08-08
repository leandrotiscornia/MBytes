namespace Agenda
{
    partial class UserControlSchedule
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
            this.lvConsultsMade = new System.Windows.Forms.ListView();
            this.IDMade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonNameMade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicMade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMade = new System.Windows.Forms.Label();
            this.lbAnswered = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.lbFiled = new System.Windows.Forms.Label();
            this.lvConsultsAnswered = new System.Windows.Forms.ListView();
            this.IDAnswered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonNameAnswered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicAnsewered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultsReceived = new System.Windows.Forms.ListView();
            this.IDReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonNameReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultsFiled = new System.Windows.Forms.ListView();
            this.IDFiled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonNameFiled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicFiled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenConsult = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultsMade
            // 
            this.lvConsultsMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDMade,
            this.PersonNameMade,
            this.TopicMade});
            this.lvConsultsMade.FullRowSelect = true;
            this.lvConsultsMade.HideSelection = false;
            this.lvConsultsMade.Location = new System.Drawing.Point(36, 30);
            this.lvConsultsMade.MultiSelect = false;
            this.lvConsultsMade.Name = "lvConsultsMade";
            this.lvConsultsMade.Size = new System.Drawing.Size(174, 321);
            this.lvConsultsMade.TabIndex = 0;
            this.lvConsultsMade.UseCompatibleStateImageBehavior = false;
            this.lvConsultsMade.View = System.Windows.Forms.View.Details;
            this.lvConsultsMade.SelectedIndexChanged += new System.EventHandler(this.lvConsultsMade_SelectedIndexChanged);
            this.lvConsultsMade.Enter += new System.EventHandler(this.lvConsultsMade_Enter);
            // 
            // IDMade
            // 
            this.IDMade.DisplayIndex = 2;
            this.IDMade.Text = "ID";
            this.IDMade.Width = 0;
            // 
            // PersonNameMade
            // 
            this.PersonNameMade.DisplayIndex = 0;
            this.PersonNameMade.Text = "Person Name";
            this.PersonNameMade.Width = 85;
            // 
            // TopicMade
            // 
            this.TopicMade.DisplayIndex = 1;
            this.TopicMade.Text = "Topic";
            this.TopicMade.Width = 84;
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMade.ForeColor = System.Drawing.Color.Red;
            this.lbMade.Location = new System.Drawing.Point(98, 7);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(49, 20);
            this.lbMade.TabIndex = 4;
            this.lbMade.Text = "Made";
            // 
            // lbAnswered
            // 
            this.lbAnswered.AutoSize = true;
            this.lbAnswered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswered.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbAnswered.Location = new System.Drawing.Point(261, 7);
            this.lbAnswered.Name = "lbAnswered";
            this.lbAnswered.Size = new System.Drawing.Size(80, 20);
            this.lbAnswered.TabIndex = 5;
            this.lbAnswered.Text = "Answered";
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceived.ForeColor = System.Drawing.Color.Green;
            this.lbReceived.Location = new System.Drawing.Point(447, 7);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(75, 20);
            this.lbReceived.TabIndex = 6;
            this.lbReceived.Text = "Received";
            // 
            // lbFiled
            // 
            this.lbFiled.AutoSize = true;
            this.lbFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiled.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbFiled.Location = new System.Drawing.Point(640, 7);
            this.lbFiled.Name = "lbFiled";
            this.lbFiled.Size = new System.Drawing.Size(43, 20);
            this.lbFiled.TabIndex = 7;
            this.lbFiled.Text = "Filed";
            // 
            // lvConsultsAnswered
            // 
            this.lvConsultsAnswered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDAnswered,
            this.PersonNameAnswered,
            this.TopicAnsewered});
            this.lvConsultsAnswered.FullRowSelect = true;
            this.lvConsultsAnswered.HideSelection = false;
            this.lvConsultsAnswered.Location = new System.Drawing.Point(216, 30);
            this.lvConsultsAnswered.MultiSelect = false;
            this.lvConsultsAnswered.Name = "lvConsultsAnswered";
            this.lvConsultsAnswered.Size = new System.Drawing.Size(174, 321);
            this.lvConsultsAnswered.TabIndex = 8;
            this.lvConsultsAnswered.UseCompatibleStateImageBehavior = false;
            this.lvConsultsAnswered.View = System.Windows.Forms.View.Details;
            this.lvConsultsAnswered.SelectedIndexChanged += new System.EventHandler(this.lvConsultsAnswered_SelectedIndexChanged);
            this.lvConsultsAnswered.Enter += new System.EventHandler(this.lvConsultsAnswered_Enter);
            // 
            // IDAnswered
            // 
            this.IDAnswered.DisplayIndex = 2;
            this.IDAnswered.Text = "ID";
            this.IDAnswered.Width = 0;
            // 
            // PersonNameAnswered
            // 
            this.PersonNameAnswered.DisplayIndex = 0;
            this.PersonNameAnswered.Text = "Person Name";
            this.PersonNameAnswered.Width = 85;
            // 
            // TopicAnsewered
            // 
            this.TopicAnsewered.DisplayIndex = 1;
            this.TopicAnsewered.Text = "Topic";
            this.TopicAnsewered.Width = 84;
            // 
            // lvConsultsReceived
            // 
            this.lvConsultsReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDReceived,
            this.PersonNameReceived,
            this.TopicReceived});
            this.lvConsultsReceived.FullRowSelect = true;
            this.lvConsultsReceived.HideSelection = false;
            this.lvConsultsReceived.Location = new System.Drawing.Point(396, 30);
            this.lvConsultsReceived.MultiSelect = false;
            this.lvConsultsReceived.Name = "lvConsultsReceived";
            this.lvConsultsReceived.Size = new System.Drawing.Size(174, 321);
            this.lvConsultsReceived.TabIndex = 9;
            this.lvConsultsReceived.UseCompatibleStateImageBehavior = false;
            this.lvConsultsReceived.View = System.Windows.Forms.View.Details;
            this.lvConsultsReceived.SelectedIndexChanged += new System.EventHandler(this.lvConsultsReceived_SelectedIndexChanged);
            this.lvConsultsReceived.Enter += new System.EventHandler(this.lvConsultsReceived_Enter);
            // 
            // IDReceived
            // 
            this.IDReceived.DisplayIndex = 2;
            this.IDReceived.Text = "ID";
            this.IDReceived.Width = 0;
            // 
            // PersonNameReceived
            // 
            this.PersonNameReceived.DisplayIndex = 0;
            this.PersonNameReceived.Text = "Person Name";
            this.PersonNameReceived.Width = 85;
            // 
            // TopicReceived
            // 
            this.TopicReceived.DisplayIndex = 1;
            this.TopicReceived.Text = "Topic";
            this.TopicReceived.Width = 84;
            // 
            // lvConsultsFiled
            // 
            this.lvConsultsFiled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDFiled,
            this.PersonNameFiled,
            this.TopicFiled});
            this.lvConsultsFiled.FullRowSelect = true;
            this.lvConsultsFiled.HideSelection = false;
            this.lvConsultsFiled.Location = new System.Drawing.Point(576, 30);
            this.lvConsultsFiled.MultiSelect = false;
            this.lvConsultsFiled.Name = "lvConsultsFiled";
            this.lvConsultsFiled.Size = new System.Drawing.Size(174, 321);
            this.lvConsultsFiled.TabIndex = 10;
            this.lvConsultsFiled.UseCompatibleStateImageBehavior = false;
            this.lvConsultsFiled.View = System.Windows.Forms.View.Details;
            this.lvConsultsFiled.SelectedIndexChanged += new System.EventHandler(this.lvConsultsFiled_SelectedIndexChanged);
            this.lvConsultsFiled.Enter += new System.EventHandler(this.lvConsultsFiled_Enter);
            // 
            // IDFiled
            // 
            this.IDFiled.DisplayIndex = 2;
            this.IDFiled.Text = "ID";
            this.IDFiled.Width = 0;
            // 
            // PersonNameFiled
            // 
            this.PersonNameFiled.DisplayIndex = 0;
            this.PersonNameFiled.Text = "Person Name";
            this.PersonNameFiled.Width = 85;
            // 
            // TopicFiled
            // 
            this.TopicFiled.DisplayIndex = 1;
            this.TopicFiled.Text = "Topic";
            this.TopicFiled.Width = 84;
            // 
            // btnOpenConsult
            // 
            this.btnOpenConsult.Location = new System.Drawing.Point(576, 357);
            this.btnOpenConsult.Name = "btnOpenConsult";
            this.btnOpenConsult.Size = new System.Drawing.Size(174, 23);
            this.btnOpenConsult.TabIndex = 11;
            this.btnOpenConsult.Text = "Open Consult";
            this.btnOpenConsult.UseVisualStyleBackColor = true;
            this.btnOpenConsult.Click += new System.EventHandler(this.btnOpenConsult_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(36, 357);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(174, 23);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload Consults";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // UserControlSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnOpenConsult);
            this.Controls.Add(this.lvConsultsFiled);
            this.Controls.Add(this.lvConsultsReceived);
            this.Controls.Add(this.lvConsultsAnswered);
            this.Controls.Add(this.lbFiled);
            this.Controls.Add(this.lbReceived);
            this.Controls.Add(this.lbAnswered);
            this.Controls.Add(this.lbMade);
            this.Controls.Add(this.lvConsultsMade);
            this.Name = "UserControlSchedule";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultsMade;
        private System.Windows.Forms.Label lbMade;
        private System.Windows.Forms.Label lbAnswered;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label lbFiled;
        private System.Windows.Forms.ColumnHeader IDMade;
        private System.Windows.Forms.ColumnHeader PersonNameMade;
        private System.Windows.Forms.ColumnHeader TopicMade;
        private System.Windows.Forms.ListView lvConsultsAnswered;
        private System.Windows.Forms.ColumnHeader IDAnswered;
        private System.Windows.Forms.ColumnHeader PersonNameAnswered;
        private System.Windows.Forms.ColumnHeader TopicAnsewered;
        private System.Windows.Forms.ListView lvConsultsReceived;
        private System.Windows.Forms.ColumnHeader IDReceived;
        private System.Windows.Forms.ColumnHeader PersonNameReceived;
        private System.Windows.Forms.ColumnHeader TopicReceived;
        private System.Windows.Forms.ListView lvConsultsFiled;
        private System.Windows.Forms.ColumnHeader IDFiled;
        private System.Windows.Forms.ColumnHeader PersonNameFiled;
        private System.Windows.Forms.ColumnHeader TopicFiled;
        private System.Windows.Forms.Button btnOpenConsult;
        private System.Windows.Forms.Button btnReload;
    }
}
