namespace BiblioAdmin
{
    partial class Form1
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
            this.searchExemplaire = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxLivreInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBoxImageLivre = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadSolde = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearchRetour = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonDataset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonEmprunt = new System.Windows.Forms.Button();
            this.buttonInsertEmprunt = new System.Windows.Forms.Button();
            this.buttonSoldeRetard = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCountDispoParBiblio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLivre)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchExemplaire
            // 
            this.searchExemplaire.Location = new System.Drawing.Point(36, 64);
            this.searchExemplaire.Name = "searchExemplaire";
            this.searchExemplaire.Size = new System.Drawing.Size(98, 44);
            this.searchExemplaire.TabIndex = 0;
            this.searchExemplaire.Text = "search";
            this.searchExemplaire.UseVisualStyleBackColor = true;
            this.searchExemplaire.Click += new System.EventHandler(this.searchExemplaire_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(19, 19);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(124, 20);
            this.textBoxCode.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Controls.Add(this.searchExemplaire);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 136);
            this.panel1.TabIndex = 5;
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridData.Location = new System.Drawing.Point(26, 46);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(630, 260);
            this.gridData.TabIndex = 6;
            this.gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.richTextBoxLivreInfo);
            this.panel2.Controls.Add(this.pictureBoxImageLivre);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.gridData);
            this.panel2.Location = new System.Drawing.Point(230, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 484);
            this.panel2.TabIndex = 7;
            // 
            // richTextBoxLivreInfo
            // 
            this.richTextBoxLivreInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxLivreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLivreInfo.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLivreInfo.Location = new System.Drawing.Point(676, 211);
            this.richTextBoxLivreInfo.Name = "richTextBoxLivreInfo";
            this.richTextBoxLivreInfo.Size = new System.Drawing.Size(146, 95);
            this.richTextBoxLivreInfo.TabIndex = 23;
            this.richTextBoxLivreInfo.Text = "";
            // 
            // pictureBoxImageLivre
            // 
            this.pictureBoxImageLivre.Location = new System.Drawing.Point(677, 46);
            this.pictureBoxImageLivre.Name = "pictureBoxImageLivre";
            this.pictureBoxImageLivre.Size = new System.Drawing.Size(145, 102);
            this.pictureBoxImageLivre.TabIndex = 22;
            this.pictureBoxImageLivre.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.buttonLoadSolde);
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.textBoxSearchRetour);
            this.panel6.Location = new System.Drawing.Point(441, 326);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 131);
            this.panel6.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Back id to Search";
            // 
            // buttonLoadSolde
            // 
            this.buttonLoadSolde.Location = new System.Drawing.Point(198, 55);
            this.buttonLoadSolde.Name = "buttonLoadSolde";
            this.buttonLoadSolde.Size = new System.Drawing.Size(109, 62);
            this.buttonLoadSolde.TabIndex = 16;
            this.buttonLoadSolde.Text = "Load Solde";
            this.buttonLoadSolde.UseVisualStyleBackColor = true;
            this.buttonLoadSolde.Click += new System.EventHandler(this.buttonLoadSolde_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(235, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "sans retards";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "search retour by id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearchRetour
            // 
            this.textBoxSearchRetour.Location = new System.Drawing.Point(115, 11);
            this.textBoxSearchRetour.Name = "textBoxSearchRetour";
            this.textBoxSearchRetour.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchRetour.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.buttonDataset);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(26, 326);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 56);
            this.panel5.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "Insert Exemplaire";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDataset
            // 
            this.buttonDataset.Location = new System.Drawing.Point(142, 3);
            this.buttonDataset.Name = "buttonDataset";
            this.buttonDataset.Size = new System.Drawing.Size(100, 50);
            this.buttonDataset.TabIndex = 8;
            this.buttonDataset.Text = "exemplaires";
            this.buttonDataset.UseVisualStyleBackColor = true;
            this.buttonDataset.Click += new System.EventHandler(this.buttonDataset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "CA_Livre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.buttonEmprunt);
            this.panel4.Controls.Add(this.buttonInsertEmprunt);
            this.panel4.Location = new System.Drawing.Point(26, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 60);
            this.panel4.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(266, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 50);
            this.button6.TabIndex = 14;
            this.button6.Text = "RetourEmprunt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonEmprunt
            // 
            this.buttonEmprunt.Location = new System.Drawing.Point(16, 6);
            this.buttonEmprunt.Name = "buttonEmprunt";
            this.buttonEmprunt.Size = new System.Drawing.Size(116, 50);
            this.buttonEmprunt.TabIndex = 10;
            this.buttonEmprunt.Text = "CustomEmprunt";
            this.buttonEmprunt.UseVisualStyleBackColor = true;
            this.buttonEmprunt.Click += new System.EventHandler(this.buttonEmprunt_Click);
            // 
            // buttonInsertEmprunt
            // 
            this.buttonInsertEmprunt.Location = new System.Drawing.Point(142, 6);
            this.buttonInsertEmprunt.Name = "buttonInsertEmprunt";
            this.buttonInsertEmprunt.Size = new System.Drawing.Size(100, 50);
            this.buttonInsertEmprunt.TabIndex = 13;
            this.buttonInsertEmprunt.Text = "InsertEmprunt";
            this.buttonInsertEmprunt.UseVisualStyleBackColor = true;
            this.buttonInsertEmprunt.Click += new System.EventHandler(this.buttonInsertEmprunt_Click);
            // 
            // buttonSoldeRetard
            // 
            this.buttonSoldeRetard.Location = new System.Drawing.Point(12, 324);
            this.buttonSoldeRetard.Name = "buttonSoldeRetard";
            this.buttonSoldeRetard.Size = new System.Drawing.Size(162, 68);
            this.buttonSoldeRetard.TabIndex = 12;
            this.buttonSoldeRetard.Text = "SoldeRetard";
            this.buttonSoldeRetard.UseVisualStyleBackColor = true;
            this.buttonSoldeRetard.Click += new System.EventHandler(this.buttonSoldeRetard_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "insertLivre";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(34, 22);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(100, 20);
            this.textBoxIsbn.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBoxIsbn);
            this.panel3.Location = new System.Drawing.Point(12, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 127);
            this.panel3.TabIndex = 11;
            // 
            // buttonCountDispoParBiblio
            // 
            this.buttonCountDispoParBiblio.Location = new System.Drawing.Point(12, 408);
            this.buttonCountDispoParBiblio.Name = "buttonCountDispoParBiblio";
            this.buttonCountDispoParBiblio.Size = new System.Drawing.Size(162, 64);
            this.buttonCountDispoParBiblio.TabIndex = 13;
            this.buttonCountDispoParBiblio.Text = "exemplaires";
            this.buttonCountDispoParBiblio.UseVisualStyleBackColor = true;
            this.buttonCountDispoParBiblio.Click += new System.EventHandler(this.buttonCountDispoParBiblio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1076, 499);
            this.Controls.Add(this.buttonCountDispoParBiblio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonSoldeRetard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Biblio Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLivre)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchExemplaire;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDataset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEmprunt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSoldeRetard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonInsertEmprunt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearchRetour;
        private System.Windows.Forms.Button buttonLoadSolde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonCountDispoParBiblio;
        private System.Windows.Forms.PictureBox pictureBoxImageLivre;
        private System.Windows.Forms.RichTextBox richTextBoxLivreInfo;
    }
}

