namespace Consultas
{
    partial class UserControlConsultationsMade
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
            this.Person_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvConsultsMade
            // 
            this.lvConsultsMade.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvConsultsMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Person_Name,
            this.Topic,
            this.State,
            this.CI});
            this.lvConsultsMade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsultsMade.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lvConsultsMade.HideSelection = false;
            this.lvConsultsMade.Location = new System.Drawing.Point(0, 0);
            this.lvConsultsMade.Name = "lvConsultsMade";
            this.lvConsultsMade.Size = new System.Drawing.Size(400, 400);
            this.lvConsultsMade.TabIndex = 0;
            this.lvConsultsMade.UseCompatibleStateImageBehavior = false;
            this.lvConsultsMade.View = System.Windows.Forms.View.Tile;
            this.lvConsultsMade.SelectedIndexChanged += new System.EventHandler(this.lvConsultsMade_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.DisplayIndex = 2;
            this.ID.Text = "ID";
            // 
            // Person_Name
            // 
            this.Person_Name.Text = "Person_Name";
            // 
            // Topic
            // 
            this.Topic.DisplayIndex = 0;
            this.Topic.Text = "Topic";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // UserControlConsultationsMade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvConsultsMade);
            this.Name = "UserControlConsultationsMade";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlConsultsMade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultsMade;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Person_Name;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader CI;
    }
}
