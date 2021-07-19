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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvConsultsAnswered = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultsReceived = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultsFiled = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenConsult = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultsMade
            // 
            this.lvConsultsMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PersonName,
            this.Topic});
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
            // ID
            // 
            this.ID.DisplayIndex = 2;
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // PersonName
            // 
            this.PersonName.DisplayIndex = 0;
            this.PersonName.Text = "Person Name";
            this.PersonName.Width = 85;
            // 
            // Topic
            // 
            this.Topic.DisplayIndex = 1;
            this.Topic.Text = "Topic";
            this.Topic.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Made";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(261, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(447, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(640, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filed";
            // 
            // lvConsultsAnswered
            // 
            this.lvConsultsAnswered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
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
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Person Name";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Topic";
            this.columnHeader3.Width = 84;
            // 
            // lvConsultsReceived
            // 
            this.lvConsultsReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
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
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Person Name";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Topic";
            this.columnHeader6.Width = 84;
            // 
            // lvConsultsFiled
            // 
            this.lvConsultsFiled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
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
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 0;
            this.columnHeader8.Text = "Person Name";
            this.columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 1;
            this.columnHeader9.Text = "Topic";
            this.columnHeader9.Width = 84;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvConsultsMade);
            this.Name = "UserControlSchedule";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultsMade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PersonName;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ListView lvConsultsAnswered;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvConsultsReceived;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvConsultsFiled;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnOpenConsult;
        private System.Windows.Forms.Button btnReload;
    }
}
