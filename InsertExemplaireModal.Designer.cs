namespace BiblioAdmin
{
    partial class InsertExemplaireModal
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxAchatDt = new System.Windows.Forms.TextBox();
            this.textBoxIdLivre = new System.Windows.Forms.TextBox();
            this.textBoxIdBiblio = new System.Windows.Forms.TextBox();
            this.textBoxEmpruntDt = new System.Windows.Forms.TextBox();
            this.buttonExInsSumit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(83, 72);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(149, 20);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = "code";
            // 
            // textBoxAchatDt
            // 
            this.textBoxAchatDt.Location = new System.Drawing.Point(83, 115);
            this.textBoxAchatDt.Name = "textBoxAchatDt";
            this.textBoxAchatDt.Size = new System.Drawing.Size(149, 20);
            this.textBoxAchatDt.TabIndex = 3;
            this.textBoxAchatDt.Text = "date d\'achat";
            // 
            // textBoxIdLivre
            // 
            this.textBoxIdLivre.Location = new System.Drawing.Point(83, 257);
            this.textBoxIdLivre.Name = "textBoxIdLivre";
            this.textBoxIdLivre.Size = new System.Drawing.Size(149, 20);
            this.textBoxIdLivre.TabIndex = 5;
            this.textBoxIdLivre.Text = "id livre";
            // 
            // textBoxIdBiblio
            // 
            this.textBoxIdBiblio.Location = new System.Drawing.Point(83, 207);
            this.textBoxIdBiblio.Name = "textBoxIdBiblio";
            this.textBoxIdBiblio.Size = new System.Drawing.Size(149, 20);
            this.textBoxIdBiblio.TabIndex = 6;
            this.textBoxIdBiblio.Text = "id biblio";
            // 
            // textBoxEmpruntDt
            // 
            this.textBoxEmpruntDt.Location = new System.Drawing.Point(83, 165);
            this.textBoxEmpruntDt.Name = "textBoxEmpruntDt";
            this.textBoxEmpruntDt.Size = new System.Drawing.Size(149, 20);
            this.textBoxEmpruntDt.TabIndex = 7;
            this.textBoxEmpruntDt.Text = "date d\'emprunt";
            // 
            // buttonExInsSumit
            // 
            this.buttonExInsSumit.Location = new System.Drawing.Point(103, 334);
            this.buttonExInsSumit.Name = "buttonExInsSumit";
            this.buttonExInsSumit.Size = new System.Drawing.Size(93, 48);
            this.buttonExInsSumit.TabIndex = 8;
            this.buttonExInsSumit.Text = "submit";
            this.buttonExInsSumit.UseVisualStyleBackColor = true;
            this.buttonExInsSumit.Click += new System.EventHandler(this.buttonExInsSumit_Click);
            // 
            // InsertExemplaireModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 423);
            this.Controls.Add(this.buttonExInsSumit);
            this.Controls.Add(this.textBoxEmpruntDt);
            this.Controls.Add(this.textBoxIdBiblio);
            this.Controls.Add(this.textBoxIdLivre);
            this.Controls.Add(this.textBoxAchatDt);
            this.Controls.Add(this.textBoxCode);
            this.IsMdiContainer = true;
            this.Name = "InsertExemplaireModal";
            this.Text = "InsertExemplaireModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxAchatDt;
        private System.Windows.Forms.TextBox textBoxIdLivre;
        private System.Windows.Forms.TextBox textBoxIdBiblio;
        private System.Windows.Forms.TextBox textBoxEmpruntDt;
        private System.Windows.Forms.Button buttonExInsSumit;
    }
}