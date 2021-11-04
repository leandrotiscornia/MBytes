namespace Consultas
{
    partial class UserControlNewConsult
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
            this.components = new System.ComponentModel.Container();
            this.lvNewConsults = new System.Windows.Forms.ListView();
            this.CI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvNewConsults
            // 
            this.lvNewConsults.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvNewConsults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CI,
            this.PersonName,
            this.ID,
            this.NickName});
            this.lvNewConsults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewConsults.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lvNewConsults.HideSelection = false;
            this.lvNewConsults.Location = new System.Drawing.Point(0, 0);
            this.lvNewConsults.Name = "lvNewConsults";
            this.lvNewConsults.Size = new System.Drawing.Size(400, 400);
            this.lvNewConsults.TabIndex = 0;
            this.lvNewConsults.UseCompatibleStateImageBehavior = false;
            this.lvNewConsults.View = System.Windows.Forms.View.Tile;
            this.lvNewConsults.SelectedIndexChanged += new System.EventHandler(this.lvNewConsults_SelectedIndexChanged);
            // 
            // CI
            // 
            this.CI.Text = "CI";
            // 
            // PersonName
            // 
            this.PersonName.Text = "Name";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NickName
            // 
            this.NickName.Text = "NickName";
            // 
            // Icons
            // 
            this.Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Icons.ImageSize = new System.Drawing.Size(16, 16);
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UserControlNewConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvNewConsults);
            this.Name = "UserControlNewConsult";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlNewConsult_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader PersonName;
        private System.Windows.Forms.ColumnHeader NickName;
        private System.Windows.Forms.ColumnHeader CI;
        private System.Windows.Forms.ColumnHeader ID;
        public System.Windows.Forms.ListView lvNewConsults;
        private System.Windows.Forms.ImageList Icons;
    }
}
