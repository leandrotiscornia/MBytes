namespace Consultas
{
    partial class UserControlConsultsFiled
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
            this.lvFiledConsults = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Person_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFiledConsults
            // 
            this.lvFiledConsults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Person_Name,
            this.Topic,
            this.State});
            this.lvFiledConsults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiledConsults.HideSelection = false;
            this.lvFiledConsults.Location = new System.Drawing.Point(0, 0);
            this.lvFiledConsults.Name = "lvFiledConsults";
            this.lvFiledConsults.Size = new System.Drawing.Size(400, 400);
            this.lvFiledConsults.TabIndex = 0;
            this.lvFiledConsults.UseCompatibleStateImageBehavior = false;
            this.lvFiledConsults.View = System.Windows.Forms.View.Tile;
            this.lvFiledConsults.SelectedIndexChanged += new System.EventHandler(this.lvFiledConsults_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Person_Name
            // 
            this.Person_Name.Text = "Person Name";
            // 
            // Topic
            // 
            this.Topic.Text = "Topic";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // UserControlConsultsFiled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvFiledConsults);
            this.Name = "UserControlConsultsFiled";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlConsultsFiled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFiledConsults;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Person_Name;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader State;
    }
}
