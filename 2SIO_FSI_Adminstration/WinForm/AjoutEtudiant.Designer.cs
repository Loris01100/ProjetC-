namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEtudiant));
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.boutonEffacer = new System.Windows.Forms.Button();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.tbAEAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(308, 69);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(70, 31);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(279, 129);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(105, 31);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(279, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Section";
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(392, 54);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(190, 46);
            this.tbAENom.TabIndex = 3;
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(392, 114);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(190, 46);
            this.tbAEPrenom.TabIndex = 5;
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
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonEnregistrer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonEnregistrer.Location = new System.Drawing.Point(235, 330);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(211, 40);
            this.boutonEnregistrer.TabIndex = 7;
            this.boutonEnregistrer.Text = "ENREGISTRER";
            this.boutonEnregistrer.UseVisualStyleBackColor = false;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            // cbSection
            // 
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.Location = new System.Drawing.Point(392, 183);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(190, 39);
            this.cbSection.TabIndex = 10;
            // 
            // tbAEAdresse
            // 
            this.tbAEAdresse.Location = new System.Drawing.Point(392, 233);
            this.tbAEAdresse.Name = "tbAEAdresse";
            this.tbAEAdresse.Size = new System.Drawing.Size(190, 46);
            this.tbAEAdresse.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(281, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adresse";
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAEAdresse);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.boutonEffacer);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AjoutEtudiant";
            this.Text = "AjouterEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tbAEAdresse;

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Button boutonEffacer;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ComboBox cbSection;
    //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}