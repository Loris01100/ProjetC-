using System.ComponentModel;

namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjouterUnCours
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
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(81, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(752, 23);
            this.PanelMenu.TabIndex = 7;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.accueilToolStripMenuItem2, this.gestionEtudiantToolStripMenuItem1, this.gestionSectionToolStripMenuItem1, this.gestionCoursToolStripMenuItem1 });
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(752, 28);
            this.msGlobal.TabIndex = 0;
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
            this.gestionSectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listeDesSectionsToolStripMenuItem, this.updateDeleteSectionToolStripMenuItem });
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
            // AjouterUnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 427);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AjouterUnCours";
            this.Text = "ACCUEIL";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
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

        //     private System.Windows.Forms.Button bDeConnexion;
        //    private System.Windows.Forms.Label lTexteBienvenue;
        //     private System.Windows.Forms.Label lBienvenue;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoursToolStripMenuItem;
    }
}