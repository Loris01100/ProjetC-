using System.ComponentModel;

namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class updateDeleteSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateDeleteSection));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAESection = new System.Windows.Forms.TextBox();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvListeEtuSec = new System.Windows.Forms.DataGridView();
            this.dgvEtuSec = new System.Windows.Forms.DataGridView();
            this.PrenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msGlobal.SuspendLayout();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtuSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtuSec)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Location = new System.Drawing.Point(87, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(806, 29);
            this.PanelMenu.TabIndex = 7;
            // 
            // boutonRetour
            // 
            this.boutonRetour.BackColor = System.Drawing.Color.Honeydew;
            this.boutonRetour.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonRetour.Location = new System.Drawing.Point(489, 175);
            this.boutonRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(148, 32);
            this.boutonRetour.TabIndex = 22;
            this.boutonRetour.Text = "RETOUR";
            this.boutonRetour.UseVisualStyleBackColor = false;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonEnregistrer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonEnregistrer.Location = new System.Drawing.Point(227, 175);
            this.boutonEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(197, 32);
            this.boutonEnregistrer.TabIndex = 20;
            this.boutonEnregistrer.Text = "ENREGISTRER";
            this.boutonEnregistrer.UseVisualStyleBackColor = false;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(302, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Section";
            // 
            // tbAESection
            // 
            this.tbAESection.Location = new System.Drawing.Point(408, 56);
            this.tbAESection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAESection.Name = "tbAESection";
            this.tbAESection.Size = new System.Drawing.Size(178, 34);
            this.tbAESection.TabIndex = 26;
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.BackColor = System.Drawing.Color.Honeydew;
            this.boutonSupprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonSupprimer.Location = new System.Drawing.Point(227, 274);
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
            this.boutonModifier.Location = new System.Drawing.Point(227, 221);
            this.boutonModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(197, 32);
            this.boutonModifier.TabIndex = 28;
            this.boutonModifier.Text = "MODIFIER";
            this.boutonModifier.UseVisualStyleBackColor = false;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.accueilToolStripMenuItem2, this.gestionEtudiantToolStripMenuItem1, this.gestionSectionToolStripMenuItem1, this.gestionCoursToolStripMenuItem1 });
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1300, 28);
            this.msGlobal.TabIndex = 30;
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
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvListeEtuSec);
            this.PanelInterieur.Location = new System.Drawing.Point(81, 28);
            this.PanelInterieur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(752, 389);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvListeEtuSec
            // 
            this.dgvListeEtuSec.AllowUserToOrderColumns = true;
            this.dgvListeEtuSec.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEtuSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEtuSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListeEtuSec.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvListeEtuSec.Location = new System.Drawing.Point(0, 0);
            this.dgvListeEtuSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListeEtuSec.Name = "dgvListeEtuSec";
            this.dgvListeEtuSec.RowHeadersWidth = 51;
            this.dgvListeEtuSec.Size = new System.Drawing.Size(752, 389);
            this.dgvListeEtuSec.TabIndex = 0;
            // 
            // dgvEtuSec
            // 
            this.dgvEtuSec.AllowUserToAddRows = false;
            this.dgvEtuSec.AllowUserToDeleteRows = false;
            this.dgvEtuSec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEtuSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtuSec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.NomEtudiant, this.PrenomEtudiant });
            this.dgvEtuSec.Location = new System.Drawing.Point(668, 63);
            this.dgvEtuSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEtuSec.MultiSelect = false;
            this.dgvEtuSec.Name = "dgvEtuSec";
            this.dgvEtuSec.ReadOnly = true;
            this.dgvEtuSec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEtuSec.Size = new System.Drawing.Size(407, 285);
            this.dgvEtuSec.TabIndex = 31;
            // 
            // PrenomEtudiant
            // 
            this.PrenomEtudiant.HeaderText = "Prénom";
            this.PrenomEtudiant.MinimumWidth = 6;
            this.PrenomEtudiant.Name = "PrenomEtudiant";
            this.PrenomEtudiant.ReadOnly = true;
            this.PrenomEtudiant.Width = 112;
            // 
            // NomEtudiant
            // 
            this.NomEtudiant.HeaderText = "Nom";
            this.NomEtudiant.MinimumWidth = 6;
            this.NomEtudiant.Name = "NomEtudiant";
            this.NomEtudiant.ReadOnly = true;
            this.NomEtudiant.Width = 112;
            // 
            // updateDeleteSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.dgvEtuSec);
            this.Controls.Add(this.msGlobal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.tbAESection);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "updateDeleteSection";
            this.Text = "ConsulterSection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtuSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtuSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvEtuSec;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button boutonModifier;

        private System.Windows.Forms.TextBox tbAESection;
        private System.Windows.Forms.Button boutonSupprimer;

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        //      private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionSectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoursToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListeEtuSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEtudiant;
        private System.Windows.Forms.ToolStripMenuItem ajouterSectionsToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInterieur;

        #endregion
    }
}