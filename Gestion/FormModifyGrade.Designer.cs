namespace Gestion
{
    partial class FormModifyGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AllowUserToDeleteRows = false;
            this.dgvGrade.AllowUserToResizeColumns = false;
            this.dgvGrade.AllowUserToResizeRows = false;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(12, 55);
            this.dgvGrade.MultiSelect = false;
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(315, 528);
            this.dgvGrade.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(333, 53);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(315, 529);
            this.dgvSubjects.TabIndex = 1;
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(12, 38);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(42, 13);
            this.lblGradeName.TabIndex = 2;
            this.lblGradeName.Text = "Grade: ";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(502, 588);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(143, 28);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign Subject";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(12, 589);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(143, 27);
            this.btnUnassign.TabIndex = 4;
            this.btnUnassign.Text = "Unassign Subject";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(467, 694);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(178, 41);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 694);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModifyGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 747);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblGradeName);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.dgvGrade);
            this.Name = "FormModifyGrade";
            this.Text = "FormModifyGrade";
            this.Load += new System.EventHandler(this.FormModifyGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
    }
}