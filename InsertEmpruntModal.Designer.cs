namespace BiblioAdmin
{
    partial class InsertEmpruntModal
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrixEmprunt = new System.Windows.Forms.TextBox();
            this.buttonInsEmp = new System.Windows.Forms.Button();
            this.comboBoxBiblio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "nom";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(132, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(158, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "titre";
            // 
            // textBoxPrixEmprunt
            // 
            this.textBoxPrixEmprunt.Location = new System.Drawing.Point(132, 130);
            this.textBoxPrixEmprunt.Name = "textBoxPrixEmprunt";
            this.textBoxPrixEmprunt.Size = new System.Drawing.Size(158, 20);
            this.textBoxPrixEmprunt.TabIndex = 5;
            this.textBoxPrixEmprunt.Text = "prix d\'emprunt";
            // 
            // buttonInsEmp
            // 
            this.buttonInsEmp.Location = new System.Drawing.Point(168, 243);
            this.buttonInsEmp.Name = "buttonInsEmp";
            this.buttonInsEmp.Size = new System.Drawing.Size(89, 53);
            this.buttonInsEmp.TabIndex = 6;
            this.buttonInsEmp.Text = "submit";
            this.buttonInsEmp.UseVisualStyleBackColor = true;
            this.buttonInsEmp.Click += new System.EventHandler(this.buttonInsEmp_Click);
            // 
            // comboBoxBiblio
            // 
            this.comboBoxBiblio.FormattingEnabled = true;
            this.comboBoxBiblio.Location = new System.Drawing.Point(132, 182);
            this.comboBoxBiblio.Name = "comboBoxBiblio";
            this.comboBoxBiblio.Size = new System.Drawing.Size(158, 21);
            this.comboBoxBiblio.TabIndex = 8;
            this.comboBoxBiblio.SelectedIndexChanged += new System.EventHandler(this.comboBoxBiblio_SelectedIndexChanged);
            // 
            // InsertEmpruntModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 308);
            this.Controls.Add(this.comboBoxBiblio);
            this.Controls.Add(this.buttonInsEmp);
            this.Controls.Add(this.textBoxPrixEmprunt);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxName);
            this.IsMdiContainer = true;
            this.Name = "InsertEmpruntModal";
            this.Text = "InsertEmpruntModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrixEmprunt;
        private System.Windows.Forms.Button buttonInsEmp;
        private System.Windows.Forms.ComboBox comboBoxBiblio;
    }
}