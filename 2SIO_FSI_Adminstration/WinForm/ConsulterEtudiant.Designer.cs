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
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(267, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adresse";
            // 
            // tbAEAdresse
            // 
            this.tbAEAdresse.Location = new System.Drawing.Point(376, 233);
            this.tbAEAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAEAdresse.Name = "tbAEAdresse";
            this.tbAEAdresse.Size = new System.Drawing.Size(178, 34);
            this.tbAEAdresse.TabIndex = 24;
            // 
            // boutonRetour
            // 
            this.boutonRetour.BackColor = System.Drawing.Color.Honeydew;
            this.boutonRetour.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonRetour.Location = new System.Drawing.Point(550, 363);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
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
            this.boutonEnregistrer.Location = new System.Drawing.Point(195, 311);
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
            this.tbAEPrenom.Location = new System.Drawing.Point(376, 137);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(178, 34);
            this.tbAEPrenom.TabIndex = 18;
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(376, 89);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(178, 34);
            this.tbAENom.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(270, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Section";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(270, 149);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(87, 27);
            this.lPrenom.TabIndex = 15;
            this.lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(297, 101);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(59, 27);
            this.lNom.TabIndex = 14;
            this.lNom.Text = "Nom";
            // 
            // tbAESection
            // 
            this.tbAESection.Location = new System.Drawing.Point(376, 192);
            this.tbAESection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAESection.Name = "tbAESection";
            this.tbAESection.Size = new System.Drawing.Size(178, 34);
            this.tbAESection.TabIndex = 26;
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonSupprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonSupprimer.Location = new System.Drawing.Point(195, 416);
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
            this.boutonModifier.Location = new System.Drawing.Point(195, 363);
            this.boutonModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(197, 32);
            this.boutonModifier.TabIndex = 28;
            this.boutonModifier.Text = "MODIFIER";
            this.boutonModifier.UseVisualStyleBackColor = false;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.accueilToolStripMenuItem2, this.gestionEtudiantToolStripMenuItem1, this.gestionSectionToolStripMenuItem1, this.gestionCoursToolStripMenuItem1 });
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1300, 28);
            this.msGlobal.TabIndex = 29;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(69, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesEtudiantsToolStripMenuItem, this.ajouterUnEtudiantToolStripMenuItem });
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(130, 24);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            // 
            // gestionSectionToolStripMenuItem1
            // 
            this.gestionSectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesSectionsToolStripMenuItem, this.updateDeleteSectionToolStripMenuItem, this.ajouterSectionsToolStripMenuItem });
            this.gestionSectionToolStripMenuItem1.Name = "gestionSectionToolStripMenuItem1";
            this.gestionSectionToolStripMenuItem1.Size = new System.Drawing.Size(124, 24);
            this.gestionSectionToolStripMenuItem1.Text = "Gestion Section";
            // 
            // listeDesSectionsToolStripMenuItem
            // 
            this.listeDesSectionsToolStripMenuItem.Name = "listeDesSectionsToolStripMenuItem";
            this.listeDesSectionsToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.listeDesSectionsToolStripMenuItem.Text = "Liste des sections";
            // 
            // updateDeleteSectionToolStripMenuItem
            // 
            this.updateDeleteSectionToolStripMenuItem.Name = "updateDeleteSectionToolStripMenuItem";
            this.updateDeleteSectionToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.updateDeleteSectionToolStripMenuItem.Text = "Modification des sections";
            // 
            // ajouterSectionsToolStripMenuItem
            // 
            this.ajouterSectionsToolStripMenuItem.Name = "ajouterSectionsToolStripMenuItem";
            this.ajouterSectionsToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.ajouterSectionsToolStripMenuItem.Text = "Ajout d\'une section";
            // 
            // gestionCoursToolStripMenuItem1
            // 
            this.gestionCoursToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesCoursToolStripMenuItem, this.ajouterUnCoursToolStripMenuItem, this.updateDeleteCoursToolStripMenuItem, this.getCoursToolStripMenuItem });
            this.gestionCoursToolStripMenuItem1.Name = "gestionCoursToolStripMenuItem1";
            this.gestionCoursToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.gestionCoursToolStripMenuItem1.Text = "Gestion cours";
            // 
            // listeDesCoursToolStripMenuItem
            // 
            this.listeDesCoursToolStripMenuItem.Name = "listeDesCoursToolStripMenuItem";
            this.listeDesCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.listeDesCoursToolStripMenuItem.Text = "Liste des cours";
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter des cours";
            // 
            // updateDeleteCoursToolStripMenuItem
            // 
            this.updateDeleteCoursToolStripMenuItem.Name = "updateDeleteCoursToolStripMenuItem";
            this.updateDeleteCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.updateDeleteCoursToolStripMenuItem.Text = "Modification des cours";
            // 
            // getCoursToolStripMenuItem
            // 
            this.getCoursToolStripMenuItem.Name = "getCoursToolStripMenuItem";
            this.getCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.getCoursToolStripMenuItem.Text = "Cours";
            // 
            // ConsulterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.msGlobal);
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
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoursToolStripMenuItem;

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