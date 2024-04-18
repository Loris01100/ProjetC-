namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutSection
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
            this.lLibelle = new System.Windows.Forms.Label();
            this.tbAELibelle = new System.Windows.Forms.TextBox();
            this.boutonEffacer = new System.Windows.Forms.Button();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lLibelle.Location = new System.Drawing.Point(298, 164);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(90, 31);
            this.lLibelle.TabIndex = 0;
            this.lLibelle.Text = "Libelle";
            // 
            // tbAELibelle
            // 
            this.tbAELibelle.Location = new System.Drawing.Point(421, 149);
            this.tbAELibelle.Name = "tbAELibelle";
            this.tbAELibelle.Size = new System.Drawing.Size(190, 46);
            this.tbAELibelle.TabIndex = 3;
            // 
            // boutonEffacer
            // 
            this.boutonEffacer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonEffacer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonEffacer.Location = new System.Drawing.Point(561, 330);
            this.boutonEffacer.Name = "boutonEffacer";
            this.boutonEffacer.Size = new System.Drawing.Size(159, 40);
            this.boutonEffacer.TabIndex = 6;
            this.boutonEffacer.Text = "EFFACER";
            this.boutonEffacer.UseVisualStyleBackColor = false;
            this.boutonEffacer.Click += new System.EventHandler(this.boutonEffacer_Click);
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.BackColor = System.Drawing.Color.Honeydew;
            this.boutonAjouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonAjouter.Location = new System.Drawing.Point(235, 330);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(211, 40);
            this.boutonAjouter.TabIndex = 7;
            this.boutonAjouter.Text = "ENREGISTRER";
            this.boutonAjouter.UseVisualStyleBackColor = false;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // boutonRetour
            // 
            this.boutonRetour.BackColor = System.Drawing.Color.Honeydew;
            this.boutonRetour.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonRetour.Location = new System.Drawing.Point(410, 376);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(159, 40);
            this.boutonRetour.TabIndex = 9;
            this.boutonRetour.Text = "RETOUR";
            this.boutonRetour.UseVisualStyleBackColor = false;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // AjoutSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 442);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.boutonEffacer);
            this.Controls.Add(this.tbAELibelle);
            this.Controls.Add(this.lLibelle);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AjoutSection";
            this.Text = "AjouterSection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lLibelle;
        private System.Windows.Forms.TextBox tbAELibelle;
        private System.Windows.Forms.Button boutonEffacer;
        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boutonRetour;
        //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}