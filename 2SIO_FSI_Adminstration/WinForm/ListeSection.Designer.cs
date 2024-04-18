using System.ComponentModel;

namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeSection
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
            this.gestionSectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.libelleSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListeSection = new System.Windows.Forms.DataGridView();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelQuitter.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSection)).BeginInit();
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
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionCoursToolStripMenuItem1});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(806, 28);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click);
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
            //
            // gestionSectionToolStripMenuItem
            //
            this.gestionSectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.listeDesSectionsToolStripMenuItem,
                this.updateDeleteSectionToolStripMenuItem
               });
            this.gestionSectionToolStripMenuItem1.Name = "gestionSectionToolStripMenuItem1";
            this.gestionSectionToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionSectionToolStripMenuItem1.Text = "Gestion Section";
            //
            // listeDesSectionsToolStripMenuItem
            //
            this.listeDesSectionsToolStripMenuItem.Name = "listeDesSectionsToolStripMenuItem";
            this.listeDesSectionsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.listeDesSectionsToolStripMenuItem.Text = "Liste des sections";
            this.listeDesSectionsToolStripMenuItem.Click += new System.EventHandler(this.listeDesSectionsToolStripMenuItem_Click);
            //
            // updateDeleteSectionsToolStripMenuItem
            //
            this.updateDeleteSectionToolStripMenuItem.Name = "listeDesSectionsToolStripMenuItem";
            this.updateDeleteSectionToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.updateDeleteSectionToolStripMenuItem.Text = "Modification des sections";
            this.updateDeleteSectionToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteSectionToolStripMenuItem_Click);
            //
            // gestionCoursToolStripMenuItem
            //
            this.gestionCoursToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.listeDesCoursToolStripMenuItem,
                this.ajouterUnCoursToolStripMenuItem,
                this.updateDeleteCoursToolStripMenuItem,
                this.getCoursToolStripMenuItem
            });
            this.gestionCoursToolStripMenuItem1.Name = "gestionCoursToolStripMenuItem1";
            this.gestionCoursToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionCoursToolStripMenuItem1.Text = "Gestion cours";
            //
            // ListeCoursToolStripMenuItem
            //
            this.listeDesCoursToolStripMenuItem.Name = "listeDesSectionsToolStripMenuItem";
            this.listeDesCoursToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.listeDesCoursToolStripMenuItem.Text = "Liste des cours";
            this.listeDesCoursToolStripMenuItem.Click += new System.EventHandler(this.ListeCoursToolStripMenuItem_Click);
            //
            // ajouterUnCoursToolStripMenuItem
            //
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter des cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click);
            //
            // updateDeleteCoursToolStripMenuItem
            //
            this.updateDeleteCoursToolStripMenuItem.Name = "updateDeleteCoursToolStripMenuItem";
            this.updateDeleteCoursToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.updateDeleteCoursToolStripMenuItem.Text = "Modification des cours";
            this.updateDeleteCoursToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteCoursToolStripMenuItem_Click);
            //
            // getCoursToolStripMenuItem
            //
            this.getCoursToolStripMenuItem.Name = "getCoursToolStripMenuItem";
            this.getCoursToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.getCoursToolStripMenuItem.Text = "Cours";
            this.getCoursToolStripMenuItem.Click += new System.EventHandler(this.getCoursToolStripMenuItem_Click);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvSections);
            this.PanelInterieur.Controls.Add(this.dgvListeSection);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 35);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 482);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvSections
            // 
            this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.AllowUserToDeleteRows = false;
            this.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelleSection});
            this.dgvSections.Location = new System.Drawing.Point(0, 3);
            this.dgvSections.MultiSelect = false;
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.ReadOnly = true;
            this.dgvSections.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSections.Size = new System.Drawing.Size(500, 335);
            this.dgvSections.TabIndex = 1;
            // 
            // libelleSection
            // 
            this.libelleSection.HeaderText = "libelle";
            this.libelleSection.MinimumWidth = 6;
            this.libelleSection.Name = "libelleSection";
            this.libelleSection.ReadOnly = true;
            this.libelleSection.Width = 93;
            // 
            // dgvListeEtudiant
            // 
            this.dgvListeSection.AllowUserToOrderColumns = true;
            this.dgvListeSection.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListeSection.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvListeSection.Location = new System.Drawing.Point(0, 0);
            this.dgvListeSection.Name = "dgvListeEtudiant";
            this.dgvListeSection.RowHeadersWidth = 51;
            this.dgvListeSection.Size = new System.Drawing.Size(806, 482);
            this.dgvListeSection.TabIndex = 0;
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
            this.Name = "ListeSection";
            this.Text = "Liste des sections";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelQuitter.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSection)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelQuitter;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesSectionsToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvListeSection;
        //   private P2022_Appli_AdministrationDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button bFermer;
        //    private System.Windows.Forms.DataGridViewTextBoxColumn nometudiantDataGridViewTextBoxColumn;
        //     private System.Windows.Forms.DataGridViewTextBoxColumn prenometudiantDataGridViewTextBoxColumn;
        //    private System.Windows.Forms.DataGridViewTextBoxColumn idclasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteCoursToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleSection;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #endregion
    }
}