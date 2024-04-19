using System.ComponentModel;

namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ConsulterEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterEtudiant));
            this.label2 = new System.Windows.Forms.Label();
            this.tbAEAdresse = new System.Windows.Forms.TextBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.tbAESection = new System.Windows.Forms.TextBox();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(267, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adresse";
            // 
            // tbAEAdresse
            // 
            this.tbAEAdresse.Location = new System.Drawing.Point(376, 197);
            this.tbAEAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAEAdresse.Name = "tbAEAdresse";
            this.tbAEAdresse.Size = new System.Drawing.Size(178, 34);
            this.tbAEAdresse.TabIndex = 24;
            // 
            // boutonRetour
            // 
            this.boutonRetour.BackColor = System.Drawing.Color.Honeydew;
            this.boutonRetour.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonRetour.Location = new System.Drawing.Point(550, 327);
            this.boutonRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(148, 32);
            this.boutonRetour.TabIndex = 22;
            this.boutonRetour.Text = "RETOUR";
            this.boutonRetour.UseVisualStyleBackColor = false;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonEnregistrer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonEnregistrer.Location = new System.Drawing.Point(195, 275);
            this.boutonEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(197, 32);
            this.boutonEnregistrer.TabIndex = 20;
            this.boutonEnregistrer.Text = "ENREGISTRER";
            this.boutonEnregistrer.UseVisualStyleBackColor = false;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(376, 101);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(178, 34);
            this.tbAEPrenom.TabIndex = 18;
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(376, 53);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(178, 34);
            this.tbAENom.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(270, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Section";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(270, 113);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(87, 27);
            this.lPrenom.TabIndex = 15;
            this.lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(297, 65);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(59, 27);
            this.lNom.TabIndex = 14;
            this.lNom.Text = "Nom";
            // 
            // tbAESection
            // 
            this.tbAESection.Location = new System.Drawing.Point(376, 156);
            this.tbAESection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAESection.Name = "tbAESection";
            this.tbAESection.Size = new System.Drawing.Size(178, 34);
            this.tbAESection.TabIndex = 26;
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonSupprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonSupprimer.Location = new System.Drawing.Point(195, 380);
            this.boutonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(197, 32);
            this.boutonSupprimer.TabIndex = 27;
            this.boutonSupprimer.Text = "SUPPRIMER";
            this.boutonSupprimer.UseVisualStyleBackColor = false;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.BackColor = System.Drawing.Color.Honeydew;
            this.boutonModifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonModifier.Location = new System.Drawing.Point(195, 327);
            this.boutonModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(197, 32);
            this.boutonModifier.TabIndex = 28;
            this.boutonModifier.Text = "MODIFIER";
            this.boutonModifier.UseVisualStyleBackColor = false;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // ConsulterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.tbAESection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAEAdresse);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConsulterEtudiant";
            this.Text = "ConsulterEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button boutonModifier;

        private System.Windows.Forms.TextBox tbAESection;
        private System.Windows.Forms.Button boutonSupprimer;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAEAdresse;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label lNom;

        #endregion
    }
}