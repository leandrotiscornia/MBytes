namespace Gestion
{
    partial class FormRegisterGrade
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
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCourses
            // 
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(103, 24);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(121, 21);
            this.cbCourses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Grade:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(567, 647);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Grade";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(11, 647);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(344, 61);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(315, 529);
            this.dgvSubjects.TabIndex = 4;
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AllowUserToDeleteRows = false;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(11, 61);
            this.dgvGrade.MultiSelect = false;
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(315, 529);
            this.dgvGrade.TabIndex = 5;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(418, 596);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(143, 28);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign Subject";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(81, 596);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(143, 28);
            this.btnUnassign.TabIndex = 7;
            this.btnUnassign.Text = "Unassign Subject";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // FormRegisterGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 693);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCourses);
            this.Name = "FormRegisterGrade";
            this.Text = "FormRegisterGrade";
            this.Load += new System.EventHandler(this.FormRegisterGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassign;
    }
}