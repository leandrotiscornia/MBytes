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
            this.lbPreviousFiled = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbPreviousFiled
            // 
            this.lbPreviousFiled.AutoSize = true;
            this.lbPreviousFiled.Location = new System.Drawing.Point(10, 59);
            this.lbPreviousFiled.Name = "lbPreviousFiled";
            this.lbPreviousFiled.Size = new System.Drawing.Size(48, 13);
            this.lbPreviousFiled.TabIndex = 11;
            this.lbPreviousFiled.Text = "Previous";
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
            this.tbTopic.Enabled = false;
            this.tbTopic.Location = new System.Drawing.Point(70, 30);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(293, 20);
            this.tbTopic.TabIndex = 7;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(70, 59);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(293, 293);
            this.rtbMessages.TabIndex = 12;
            this.rtbMessages.Text = "";
            // 
            // UserControlReadFiledConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.lbPreviousFiled);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.tbTopic);
            this.Name = "UserControlReadFiledConsult";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControlReadFiledConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPreviousFiled;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}
