namespace Autorizacion
{
    partial class UserControlAuthorization
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
            this.dgvRequested = new System.Windows.Forms.DataGridView();
            this.dgvAccepted = new System.Windows.Forms.DataGridView();
            this.dgvDenied = new System.Windows.Forms.DataGridView();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccepted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenied)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequested
            // 
            this.dgvRequested.AllowUserToAddRows = false;
            this.dgvRequested.AllowUserToDeleteRows = false;
            this.dgvRequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequested.Location = new System.Drawing.Point(19, 13);
            this.dgvRequested.Name = "dgvRequested";
            this.dgvRequested.ReadOnly = true;
            this.dgvRequested.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequested.Size = new System.Drawing.Size(238, 316);
            this.dgvRequested.TabIndex = 0;
            // 
            // dgvAccepted
            // 
            this.dgvAccepted.AllowUserToAddRows = false;
            this.dgvAccepted.AllowUserToDeleteRows = false;
            this.dgvAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccepted.Location = new System.Drawing.Point(276, 13);
            this.dgvAccepted.Name = "dgvAccepted";
            this.dgvAccepted.ReadOnly = true;
            this.dgvAccepted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccepted.Size = new System.Drawing.Size(241, 316);
            this.dgvAccepted.TabIndex = 1;
            // 
            // dgvDenied
            // 
            this.dgvDenied.AllowUserToAddRows = false;
            this.dgvDenied.AllowUserToDeleteRows = false;
            this.dgvDenied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenied.Location = new System.Drawing.Point(533, 13);
            this.dgvDenied.Name = "dgvDenied";
            this.dgvDenied.ReadOnly = true;
            this.dgvDenied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDenied.Size = new System.Drawing.Size(240, 316);
            this.dgvDenied.TabIndex = 2;
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(146, 335);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(111, 40);
            this.btnDeny.TabIndex = 3;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(19, 335);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(121, 40);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(328, 335);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(113, 40);
            this.btnRevoke.TabIndex = 6;
            this.btnRevoke.Text = "Revoke";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(590, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Deny";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserControlAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.dgvDenied);
            this.Controls.Add(this.dgvAccepted);
            this.Controls.Add(this.dgvRequested);
            this.Name = "UserControlAuthorization";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccepted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenied)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequested;
        private System.Windows.Forms.DataGridView dgvAccepted;
        private System.Windows.Forms.DataGridView dgvDenied;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnCancel;
    }
}
