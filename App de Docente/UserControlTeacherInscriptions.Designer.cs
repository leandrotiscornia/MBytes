namespace App_de_Docente
{
    partial class UserControlTeacherInscriptions
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
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnRequest = new System.Windows.Forms.Button();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(43, 39);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(170, 251);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(228, 39);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(165, 251);
            this.dgvSubjects.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(262, 296);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(131, 37);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AllowUserToDeleteRows = false;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Location = new System.Drawing.Point(490, 39);
            this.dgvPending.MultiSelect = false;
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.Size = new System.Drawing.Size(271, 251);
            this.dgvPending.TabIndex = 4;
            // 
            // UserControlTeacherInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPending);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.dgvGroups);
            this.Name = "UserControlTeacherInscriptions";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlTeacherInscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView dgvPending;
    }
}
