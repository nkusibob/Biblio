namespace BiblioAdmin
{
    partial class FormGestionRetour
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
            this.textBoxIdEx = new System.Windows.Forms.TextBox();
            this.buttonRetourRapide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdEx
            // 
            this.textBoxIdEx.Location = new System.Drawing.Point(95, 46);
            this.textBoxIdEx.Name = "textBoxIdEx";
            this.textBoxIdEx.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdEx.TabIndex = 0;
            // 
            // buttonRetourRapide
            // 
            this.buttonRetourRapide.Location = new System.Drawing.Point(105, 129);
            this.buttonRetourRapide.Name = "buttonRetourRapide";
            this.buttonRetourRapide.Size = new System.Drawing.Size(75, 23);
            this.buttonRetourRapide.TabIndex = 1;
            this.buttonRetourRapide.Text = "submit";
            this.buttonRetourRapide.UseVisualStyleBackColor = true;
            this.buttonRetourRapide.Click += new System.EventHandler(this.buttonRetourRapide_Click);
            // 
            // FormGestionRetour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonRetourRapide);
            this.Controls.Add(this.textBoxIdEx);
            this.IsMdiContainer = true;
            this.Name = "FormGestionRetour";
            this.Text = "FormGestionRetour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdEx;
        private System.Windows.Forms.Button buttonRetourRapide;
    }
}