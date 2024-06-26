﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjouterUnCours : Form
    {
        Utilisateur uti;
        
        private DAOCours coursDAO;
        public AjouterUnCours(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            RemplirComboBoxSections();
        }
        
        private void RemplirComboBoxSections()
        {
            DAOSection dao = new DAOSection();
            List<Section> mesSections = dao.GetAll();

            cbSection.DisplayMember = "LibelleSection";
            cbSection.ValueMember = "IdSection";
            cbSection.DataSource = mesSections;
        }
        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            string libelle = tbAELibelle.Text;
            string descriptionCours = tbAEDescr.Text;
            Section section = cbSection.SelectedItem as Section;
            
            if (section == null)
            {
                MessageBox.Show("Veuillez sélectionner une section.");
                return;
            }
            
            bool ajoutReussi = DAOCours.InsertCours(libelle, descriptionCours, section);

            if (ajoutReussi)
            {
                MessageBox.Show("Cours ajouté avec succès.");
                reInitialisation();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la section. Assurez-vous que tous les champs sont remplis.");
            }
        }
        
        private void reInitialisation()
        {
            tbAELibelle.Clear();
            tbAEDescr.Clear();
            cbSection.SelectedIndex = -1;
            
        }
        private void boutonEffacer_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Accueil(uti);
            formAccueil.Show();
        }
        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeEtudiant = new ListeEtudiant(uti);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjouterEtudiant = new AjoutEtudiant(uti);
            formAjouterEtudiant.Show();
        }
        private void listeDesSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeSection = new ListeSection(uti);
            formListeSection.Show();
        }
        private void ajouterSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjoutSection = new AjoutSection(uti);
            formAjoutSection.Show();
        }
        private void ListeCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeCours = new ListeCours(uti);
            formListeCours.Show();
        }
        private void updateDeleteSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUpdateDeleteCours = new updateDeleteSection(null, uti, 0);
            formUpdateDeleteCours.Show();
        }
        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjouterCours = new AjouterUnCours(uti);
            formAjouterCours.Show();
        }
        private void updateDeleteCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUpdateDeleteCours = new updateDeleteCours(null, uti);
            formUpdateDeleteCours.Show();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirmer que utilisateur veut fermer
            switch (MessageBox.Show(this, "Vous êtes sur?", "Fermer en cours", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                {
                    Process.GetCurrentProcess().Kill();
                    break;
                }
            }        
        }
    }
}