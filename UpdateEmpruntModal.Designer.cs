namespace BiblioAdmin
{
    partial class UpdateEmpruntModal
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
            this.textBoxDtRetour = new System.Windows.Forms.TextBox();
            this.buttonUpdateEmprunt = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDtRetour
            // 
            this.textBoxDtRetour.Location = new System.Drawing.Point(124, 147);
            this.textBoxDtRetour.Name = "textBoxDtRetour";
            this.textBoxDtRetour.Size = new System.Drawing.Size(158, 20);
            this.textBoxDtRetour.TabIndex = 8;
            this.textBoxDtRetour.Text = "date retour";
            this.textBoxDtRetour.TextChanged += new System.EventHandler(this.textBoxDtRetour_TextChanged);
            // 
            // buttonUpdateEmprunt
            // 
            this.buttonUpdateEmprunt.Location = new System.Drawing.Point(139, 205);
            this.buttonUpdateEmprunt.Name = "buttonUpdateEmprunt";
            this.buttonUpdateEmprunt.Size = new System.Drawing.Size(106, 43);
            this.buttonUpdateEmprunt.TabIndex = 10;
            this.buttonUpdateEmprunt.Text = "submit";
            this.buttonUpdateEmprunt.UseVisualStyleBackColor = true;
            this.buttonUpdateEmprunt.Click += new System.EventHandler(this.buttonUpdateEmprunt_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(124, 68);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 11;
            this.textBoxId.Text = "id";
            // 
            // UpdateEmpruntModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonUpdateEmprunt);
            this.Controls.Add(this.textBoxDtRetour);
            this.IsMdiContainer = true;
            this.Name = "UpdateEmpruntModal";
            this.Text = "UpdateEmprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDtRetour;
        private System.Windows.Forms.Button buttonUpdateEmprunt;
        private System.Windows.Forms.TextBox textBoxId;
    }
}