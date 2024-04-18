namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEtudiant));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesSectinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDesSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsulterEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.dgvListeEtudiant = new System.Windows.Forms.DataGridView();
            this.bFermer = new System.Windows.Forms.Button();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Détail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelQuitter.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 90);
            this.PanelLogo.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(78, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // PanelQuitter
            // 
            this.PanelQuitter.Controls.Add(this.bQuitter);
            this.PanelQuitter.Location = new System.Drawing.Point(899, 0);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(123, 46);
            this.PanelQuitter.TabIndex = 11;
            // 
            // bQuitter
            // 
            this.bQuitter.BackColor = System.Drawing.Color.LightCyan;
            this.bQuitter.Location = new System.Drawing.Point(4, 3);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(115, 40);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(87, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(806, 29);
            this.PanelMenu.TabIndex = 12;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.accueilToolStripMenuItem2, this.gestionEtudiantToolStripMenuItem1, this.gestionSectionToolStripMenuItem, this.gestionCoursToolStripMenuItem });
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(806, 28);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(69, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click);
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
            // gestionSectionToolStripMenuItem
            // 
            this.gestionSectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesSectinosToolStripMenuItem, this.modificationDesSectionsToolStripMenuItem, this.ajoutDuneSectionToolStripMenuItem });
            this.gestionSectionToolStripMenuItem.Name = "gestionSectionToolStripMenuItem";
            this.gestionSectionToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.gestionSectionToolStripMenuItem.Text = "Gestion Section";
            this.gestionSectionToolStripMenuItem.ToolTipText = "Gestion Section";
            // 
            // listeDesSectinosToolStripMenuItem
            // 
            this.listeDesSectinosToolStripMenuItem.Name = "listeDesSectinosToolStripMenuItem";
            this.listeDesSectinosToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.listeDesSectinosToolStripMenuItem.Text = "Liste des Sections";
            // 
            // modificationDesSectionsToolStripMenuItem
            // 
            this.modificationDesSectionsToolStripMenuItem.Name = "modificationDesSectionsToolStripMenuItem";
            this.modificationDesSectionsToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.modificationDesSectionsToolStripMenuItem.Text = "Modification des Sections";
            // 
            // ajoutDuneSectionToolStripMenuItem
            // 
            this.ajoutDuneSectionToolStripMenuItem.Name = "ajoutDuneSectionToolStripMenuItem";
            this.ajoutDuneSectionToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.ajoutDuneSectionToolStripMenuItem.Text = "Ajout d\'une Section";
            // 
            // gestionCoursToolStripMenuItem
            // 
            this.gestionCoursToolStripMenuItem.Name = "gestionCoursToolStripMenuItem";
            this.gestionCoursToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.gestionCoursToolStripMenuItem.Text = "Gestion Cours";
            // 
            // gestionSectionToolStripMenuItem1
            // 
            this.gestionSectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesSectionsToolStripMenuItem, this.updateDeleteSectionToolStripMenuItem });
            this.gestionSectionToolStripMenuItem1.Name = "gestionSectionToolStripMenuItem1";
            this.gestionSectionToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionSectionToolStripMenuItem1.Text = "Gestion Section";
            // 
            // listeDesSectionsToolStripMenuItem
            // 
            this.listeDesSectionsToolStripMenuItem.Name = "listeDesSectionsToolStripMenuItem";
            this.listeDesSectionsToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.listeDesSectionsToolStripMenuItem.Text = "Liste des sections";
            this.listeDesSectionsToolStripMenuItem.Click += new System.EventHandler(this.listeDesSectionsToolStripMenuItem_Click);
            // 
            // updateDeleteSectionToolStripMenuItem
            // 
            this.updateDeleteSectionToolStripMenuItem.Name = "updateDeleteSectionToolStripMenuItem";
            this.updateDeleteSectionToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvEtudiants);
            this.PanelInterieur.Controls.Add(this.dgvListeEtudiant);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 35);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 482);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.nomEtudiant, this.prenomEtudiant, this.libelleSection, this.Détail });
            this.dgvEtudiants.Location = new System.Drawing.Point(0, 0);
            this.dgvEtudiants.MultiSelect = false;
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEtudiants.Size = new System.Drawing.Size(803, 357);
            this.dgvEtudiants.TabIndex = 1;
            // 
            // dgvListeEtudiant
            // 
            this.dgvListeEtudiant.AllowUserToOrderColumns = true;
            this.dgvListeEtudiant.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEtudiant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListeEtudiant.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvListeEtudiant.Location = new System.Drawing.Point(0, 0);
            this.dgvListeEtudiant.Name = "dgvListeEtudiant";
            this.dgvListeEtudiant.RowHeadersWidth = 51;
            this.dgvListeEtudiant.Size = new System.Drawing.Size(806, 482);
            this.dgvListeEtudiant.TabIndex = 0;
            // 
            // bFermer
            // 
            this.bFermer.BackColor = System.Drawing.Color.LightCyan;
            this.bFermer.Location = new System.Drawing.Point(899, 52);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(115, 40);
            this.bFermer.TabIndex = 13;
            this.bFermer.Text = "FERMER";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "nom";
            this.nomEtudiant.MinimumWidth = 6;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            this.nomEtudiant.Width = 89;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.HeaderText = "Prénom";
            this.prenomEtudiant.MinimumWidth = 6;
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.ReadOnly = true;
            this.prenomEtudiant.Width = 130;
            // 
            // libelleSection
            // 
            this.libelleSection.HeaderText = "Section";
            this.libelleSection.MinimumWidth = 6;
            this.libelleSection.Name = "libelleSection";
            this.libelleSection.ReadOnly = true;
            this.libelleSection.Width = 128;
            // 
            // Détail
            // 
            this.Détail.HeaderText = "Détail";
            this.Détail.MinimumWidth = 6;
            this.Détail.Name = "Détail";
            this.Détail.ReadOnly = true;
            this.Détail.Width = 92;
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 529);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelQuitter);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListeEtudiant";
            this.Text = "Liste des Etudiants";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelQuitter.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewCheckBoxColumn Détail;

        private System.Windows.Forms.ToolStripMenuItem modificationDesSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneSectionToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem listeDesSectinosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem;

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelQuitter;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsulterEtudiantToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvListeEtudiant;
        //   private P2022_Appli_AdministrationDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button bFermer;
    //    private System.Windows.Forms.DataGridViewTextBoxColumn nometudiantDataGridViewTextBoxColumn;
   //     private System.Windows.Forms.DataGridViewTextBoxColumn prenometudiantDataGridViewTextBoxColumn;
    //    private System.Windows.Forms.DataGridViewTextBoxColumn idclasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem gestionSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleSection;
    }
}