﻿namespace Consultas
{
    partial class UserControlConsultsMade
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
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Person_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvConsultsMade
            // 
            this.lvConsultsMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Topic,
            this.Person_Name,
            this.State});
            this.lvConsultsMade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsultsMade.HideSelection = false;
            this.lvConsultsMade.Location = new System.Drawing.Point(0, 0);
            this.lvConsultsMade.Name = "lvConsultsMade";
            this.lvConsultsMade.Size = new System.Drawing.Size(400, 400);
            this.lvConsultsMade.TabIndex = 0;
            this.lvConsultsMade.UseCompatibleStateImageBehavior = false;
            this.lvConsultsMade.View = System.Windows.Forms.View.Tile;
            this.lvConsultsMade.SelectedIndexChanged += new System.EventHandler(this.lvConsultsMade_SelectedIndexChanged);
            // 
            // Topic
            // 
            this.Topic.DisplayIndex = 0;
            this.Topic.Text = "Topic";
            // 
            // Person_Name
            // 
            this.Person_Name.DisplayIndex = 1;
            this.Person_Name.Text = "Person_Name";
            // 
            // ID
            // 
            this.ID.DisplayIndex = 2;
            this.ID.Text = "ID";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // UserControlConsultsMade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvConsultsMade);
            this.Name = "UserControlConsultsMade";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultsMade;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Person_Name;
        private System.Windows.Forms.ColumnHeader State;
    }
}
