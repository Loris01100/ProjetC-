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
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lLibelle.Location = new System.Drawing.Point(293, 236);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(84, 26);
            this.lLibelle.TabIndex = 0;
            this.lLibelle.Text = "Libelle";
            // 
            // tbAELibelle
            // 
            this.tbAELibelle.Location = new System.Drawing.Point(408, 224);
            this.tbAELibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAELibelle.Name = "tbAELibelle";
            this.tbAELibelle.Size = new System.Drawing.Size(178, 34);
            this.tbAELibelle.TabIndex = 3;
            // 
            // boutonEffacer
            // 
            this.boutonEffacer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonEffacer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonEffacer.Location = new System.Drawing.Point(539, 370);
            this.boutonEffacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonEffacer.Name = "boutonEffacer";
            this.boutonEffacer.Size = new System.Drawing.Size(148, 32);
            this.boutonEffacer.TabIndex = 6;
            this.boutonEffacer.Text = "EFFACER";
            this.boutonEffacer.UseVisualStyleBackColor = false;
            this.boutonEffacer.Click += new System.EventHandler(this.boutonEffacer_Click);
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.BackColor = System.Drawing.Color.Honeydew;
            this.boutonAjouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonAjouter.Location = new System.Drawing.Point(234, 370);
            this.boutonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(197, 32);
            this.boutonAjouter.TabIndex = 7;
            this.boutonAjouter.Text = "ENREGISTRER";
            this.boutonAjouter.UseVisualStyleBackColor = false;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // boutonRetour
            // 
            this.boutonRetour.BackColor = System.Drawing.Color.Honeydew;
            this.boutonRetour.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonRetour.Location = new System.Drawing.Point(398, 407);
            this.boutonRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(148, 32);
            this.boutonRetour.TabIndex = 9;
            this.boutonRetour.Text = "RETOUR";
            this.boutonRetour.UseVisualStyleBackColor = false;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.accueilToolStripMenuItem2, this.gestionEtudiantToolStripMenuItem1, this.gestionSectionToolStripMenuItem1, this.gestionCoursToolStripMenuItem1 });
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1025, 28);
            this.msGlobal.TabIndex = 10;
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
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
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
            this.listeDesSectionsToolStripMenuItem.Click += new System.EventHandler(this.listeDesSectionsToolStripMenuItem_Click);
            // 
            // updateDeleteSectionToolStripMenuItem
            // 
            this.updateDeleteSectionToolStripMenuItem.Name = "updateDeleteSectionToolStripMenuItem";
            this.updateDeleteSectionToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.updateDeleteSectionToolStripMenuItem.Text = "Modification des sections";
            this.updateDeleteSectionToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteSectionToolStripMenuItem_Click);
            // 
            // ajouterSectionsToolStripMenuItem
            // 
            this.ajouterSectionsToolStripMenuItem.Name = "ajouterSectionsToolStripMenuItem";
            this.ajouterSectionsToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.ajouterSectionsToolStripMenuItem.Text = "Ajout d\'une section";
            this.ajouterSectionsToolStripMenuItem.Click += new System.EventHandler(this.ajouterSectionsToolStripMenuItem_Click);
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
            this.listeDesCoursToolStripMenuItem.Click += new System.EventHandler(this.ListeCoursToolStripMenuItem_Click);
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter des cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click);
            // 
            // updateDeleteCoursToolStripMenuItem
            // 
            this.updateDeleteCoursToolStripMenuItem.Name = "updateDeleteCoursToolStripMenuItem";
            this.updateDeleteCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.updateDeleteCoursToolStripMenuItem.Text = "Modification des cours";
            this.updateDeleteCoursToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteCoursToolStripMenuItem_Click);
            // 
            // getCoursToolStripMenuItem
            // 
            this.getCoursToolStripMenuItem.Name = "getCoursToolStripMenuItem";
            this.getCoursToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.getCoursToolStripMenuItem.Text = "Cours";
            this.getCoursToolStripMenuItem.Click += new System.EventHandler(this.getCoursToolStripMenuItem_Click);
            // 
            // AjoutSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 551);
            this.Controls.Add(this.msGlobal);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.boutonEffacer);
            this.Controls.Add(this.tbAELibelle);
            this.Controls.Add(this.lLibelle);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AjoutSection";
            this.Text = "AjouterSection";
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