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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAuthorization));
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
            resources.ApplyResources(this.dgvRequested, "dgvRequested");
            this.dgvRequested.AllowUserToAddRows = false;
            this.dgvRequested.AllowUserToDeleteRows = false;
            this.dgvRequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequested.Name = "dgvRequested";
            this.dgvRequested.ReadOnly = true;
            this.dgvRequested.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvAccepted
            // 
            resources.ApplyResources(this.dgvAccepted, "dgvAccepted");
            this.dgvAccepted.AllowUserToAddRows = false;
            this.dgvAccepted.AllowUserToDeleteRows = false;
            this.dgvAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccepted.Name = "dgvAccepted";
            this.dgvAccepted.ReadOnly = true;
            this.dgvAccepted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvDenied
            // 
            resources.ApplyResources(this.dgvDenied, "dgvDenied");
            this.dgvDenied.AllowUserToAddRows = false;
            this.dgvDenied.AllowUserToDeleteRows = false;
            this.dgvDenied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenied.Name = "dgvDenied";
            this.dgvDenied.ReadOnly = true;
            this.dgvDenied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDeny
            // 
            resources.ApplyResources(this.btnDeny, "btnDeny");
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnAccept
            // 
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRevoke
            // 
            resources.ApplyResources(this.btnRevoke, "btnRevoke");
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserControlAuthorization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.dgvDenied);
            this.Controls.Add(this.dgvAccepted);
            this.Controls.Add(this.dgvRequested);
            this.Name = "UserControlAuthorization";
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
