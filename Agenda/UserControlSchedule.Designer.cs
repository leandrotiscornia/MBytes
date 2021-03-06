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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSchedule));
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
            resources.ApplyResources(this.lvConsultsMade, "lvConsultsMade");
            this.lvConsultsMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDMade,
            this.PersonNameMade,
            this.TopicMade});
            this.lvConsultsMade.FullRowSelect = true;
            this.lvConsultsMade.HideSelection = false;
            this.lvConsultsMade.MultiSelect = false;
            this.lvConsultsMade.Name = "lvConsultsMade";
            this.lvConsultsMade.UseCompatibleStateImageBehavior = false;
            this.lvConsultsMade.View = System.Windows.Forms.View.Details;
            this.lvConsultsMade.SelectedIndexChanged += new System.EventHandler(this.lvConsultsMade_SelectedIndexChanged);
            this.lvConsultsMade.Enter += new System.EventHandler(this.lvConsultsMade_Enter);
            // 
            // IDMade
            // 
            resources.ApplyResources(this.IDMade, "IDMade");
            // 
            // PersonNameMade
            // 
            resources.ApplyResources(this.PersonNameMade, "PersonNameMade");
            // 
            // TopicMade
            // 
            resources.ApplyResources(this.TopicMade, "TopicMade");
            // 
            // lbMade
            // 
            resources.ApplyResources(this.lbMade, "lbMade");
            this.lbMade.ForeColor = System.Drawing.Color.Red;
            this.lbMade.Name = "lbMade";
            // 
            // lbAnswered
            // 
            resources.ApplyResources(this.lbAnswered, "lbAnswered");
            this.lbAnswered.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbAnswered.Name = "lbAnswered";
            // 
            // lbReceived
            // 
            resources.ApplyResources(this.lbReceived, "lbReceived");
            this.lbReceived.ForeColor = System.Drawing.Color.Green;
            this.lbReceived.Name = "lbReceived";
            // 
            // lbFiled
            // 
            resources.ApplyResources(this.lbFiled, "lbFiled");
            this.lbFiled.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbFiled.Name = "lbFiled";
            // 
            // lvConsultsAnswered
            // 
            resources.ApplyResources(this.lvConsultsAnswered, "lvConsultsAnswered");
            this.lvConsultsAnswered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDAnswered,
            this.PersonNameAnswered,
            this.TopicAnsewered});
            this.lvConsultsAnswered.FullRowSelect = true;
            this.lvConsultsAnswered.HideSelection = false;
            this.lvConsultsAnswered.MultiSelect = false;
            this.lvConsultsAnswered.Name = "lvConsultsAnswered";
            this.lvConsultsAnswered.UseCompatibleStateImageBehavior = false;
            this.lvConsultsAnswered.View = System.Windows.Forms.View.Details;
            this.lvConsultsAnswered.SelectedIndexChanged += new System.EventHandler(this.lvConsultsAnswered_SelectedIndexChanged);
            this.lvConsultsAnswered.Enter += new System.EventHandler(this.lvConsultsAnswered_Enter);
            // 
            // IDAnswered
            // 
            resources.ApplyResources(this.IDAnswered, "IDAnswered");
            // 
            // PersonNameAnswered
            // 
            resources.ApplyResources(this.PersonNameAnswered, "PersonNameAnswered");
            // 
            // TopicAnsewered
            // 
            resources.ApplyResources(this.TopicAnsewered, "TopicAnsewered");
            // 
            // lvConsultsReceived
            // 
            resources.ApplyResources(this.lvConsultsReceived, "lvConsultsReceived");
            this.lvConsultsReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDReceived,
            this.PersonNameReceived,
            this.TopicReceived});
            this.lvConsultsReceived.FullRowSelect = true;
            this.lvConsultsReceived.HideSelection = false;
            this.lvConsultsReceived.MultiSelect = false;
            this.lvConsultsReceived.Name = "lvConsultsReceived";
            this.lvConsultsReceived.UseCompatibleStateImageBehavior = false;
            this.lvConsultsReceived.View = System.Windows.Forms.View.Details;
            this.lvConsultsReceived.SelectedIndexChanged += new System.EventHandler(this.lvConsultsReceived_SelectedIndexChanged);
            this.lvConsultsReceived.Enter += new System.EventHandler(this.lvConsultsReceived_Enter);
            // 
            // IDReceived
            // 
            resources.ApplyResources(this.IDReceived, "IDReceived");
            // 
            // PersonNameReceived
            // 
            resources.ApplyResources(this.PersonNameReceived, "PersonNameReceived");
            // 
            // TopicReceived
            // 
            resources.ApplyResources(this.TopicReceived, "TopicReceived");
            // 
            // lvConsultsFiled
            // 
            resources.ApplyResources(this.lvConsultsFiled, "lvConsultsFiled");
            this.lvConsultsFiled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDFiled,
            this.PersonNameFiled,
            this.TopicFiled});
            this.lvConsultsFiled.FullRowSelect = true;
            this.lvConsultsFiled.HideSelection = false;
            this.lvConsultsFiled.MultiSelect = false;
            this.lvConsultsFiled.Name = "lvConsultsFiled";
            this.lvConsultsFiled.UseCompatibleStateImageBehavior = false;
            this.lvConsultsFiled.View = System.Windows.Forms.View.Details;
            this.lvConsultsFiled.SelectedIndexChanged += new System.EventHandler(this.lvConsultsFiled_SelectedIndexChanged);
            this.lvConsultsFiled.Enter += new System.EventHandler(this.lvConsultsFiled_Enter);
            // 
            // IDFiled
            // 
            resources.ApplyResources(this.IDFiled, "IDFiled");
            // 
            // PersonNameFiled
            // 
            resources.ApplyResources(this.PersonNameFiled, "PersonNameFiled");
            // 
            // TopicFiled
            // 
            resources.ApplyResources(this.TopicFiled, "TopicFiled");
            // 
            // btnOpenConsult
            // 
            resources.ApplyResources(this.btnOpenConsult, "btnOpenConsult");
            this.btnOpenConsult.Name = "btnOpenConsult";
            this.btnOpenConsult.UseVisualStyleBackColor = true;
            this.btnOpenConsult.Click += new System.EventHandler(this.btnOpenConsult_Click);
            // 
            // btnReload
            // 
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // UserControlSchedule
            // 
            resources.ApplyResources(this, "$this");
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
