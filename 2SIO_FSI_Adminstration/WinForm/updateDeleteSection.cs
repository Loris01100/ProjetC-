using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class updateDeleteSection : Form
    {
        private Section section;
        private Utilisateur uti;
        private int sectionId;
        public updateDeleteSection(Section sec, Utilisateur utiConnecte, int sectionId)
        {
            InitializeComponent();
            section = sec;
            uti = utiConnecte;
            this.sectionId = sectionId;
            DetailSection();
            EtudiantCharger();
        }
        private void DetailSection()
        {
            tbAESection.Text = section.LibelleSection;
        }
        private void EtudiantCharger()
        {
            DAOEtudiant dao = new DAOEtudiant();
            List<Etudiant> mesEtudiants = dao.GetEtudiantsBySection(sectionId);

            dgvEtuSec.Rows.Clear();
            foreach (Etudiant etu in mesEtudiants)
            {
                int index = dgvEtuSec.Rows.Add();
                dgvEtuSec.Rows[index].Cells["NomEtudiant"].Value = etu.NomEtudiant;
                dgvEtuSec.Rows[index].Cells["PrenomEtudiant"].Value = etu.PrenomEtudiant;
            }
        }
        
        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listSection = new ListeSection(uti);
            listSection.Show();
        }
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            bool isUpdated = false;
            DAOSection dao = new DAOSection();


            if (tbAESection.Text != section.LibelleSection)
            {
                dao.UpdateSection(section.IdSection, tbAESection.Text);
                isUpdated = true;
            }
            
            if (isUpdated)
            {
                MessageBox.Show("Les informations ont été mises à jour avec succès.", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucune modification détectée.", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
            Form listSection = new ListeSection(uti);
            listSection.Show();
        }
        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            DAOSection dao = new DAOSection();
            try
            {
                // Étape 1 : Dissocier tous les étudiants de la section
                dao.RemoveSectionFromStudents(section.IdSection);

                // Étape 2 : Supprimer la section
                dao.DeleteSection(section.IdSection);
        
                MessageBox.Show("Section supprimée avec succès.");
        
                // Après la suppression, masquez ce formulaire et affichez la liste des sections
                this.Hide();
                Form listSection = new ListeSection(uti);
                listSection.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la section: " + ex.Message);
            }
        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listSection = new ListeSection(uti);
            listSection.Show();
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