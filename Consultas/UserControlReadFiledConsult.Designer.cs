namespace Consultas
{
    partial class UserControlReadFiledConsult
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.lbxPreviousMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Previous";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Location = new System.Drawing.Point(27, 33);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(37, 13);
            this.lbTopic.TabIndex = 8;
            this.lbTopic.Text = "Topic:";
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(70, 30);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 7;
            // 
            // lbxPreviousMessages
            // 
            this.lbxPreviousMessages.FormattingEnabled = true;
            this.lbxPreviousMessages.Location = new System.Drawing.Point(70, 59);
            this.lbxPreviousMessages.Name = "lbxPreviousMessages";
            this.lbxPreviousMessages.Size = new System.Drawing.Size(293, 290);
            this.lbxPreviousMessages.TabIndex = 12;
            // 
            // UserControlReadFiledConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxPreviousMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.Name = "UserControlReadFiledConsult";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlReadFiledConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.ListBox lbxPreviousMessages;
    }
}
