using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class updateDeleteCours : Form
    {
        private Cours cours;
        private Utilisateur uti;

        public updateDeleteCours(Cours cou, Utilisateur utiConnecte)
        {
            InitializeComponent();
            cours = cou;
            uti = utiConnecte;
            DetailCours();
            SectionCharger();
        }

        private void DetailCours()
        {
            tbAECours.Text = cours.LibelleCours;
        }

        private void SectionCharger()
        {
            DAOCours daoCours = new DAOCours();
            List<Section> mesCours = daoCours.GetSectionsByCours(cours.IdCours);

            dgvCours.Rows.Clear();
            foreach (Section sec in mesCours)
            {
                int index = dgvCours.Rows.Add();
                dgvCours.Rows[index].Cells["LibCours"].Value = sec.LibelleSection;
            }
        }
    


    private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listCours = new ListeCours(uti);
            listCours.Show();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            
            bool isUpdated = false;
            DAOCours dao = new DAOCours();


            if (tbAECours.Text != cours.LibelleCours)
            {
                dao.UpdateCours(cours.IdCours, tbAECours.Text);
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
            Form listCours = new ListeCours(uti);
            listCours.Show();
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            DAOCours dao = new DAOCours();

            try
            {
                dao.DeleteCours(cours.IdCours); 
                MessageBox.Show("Cours supprimé avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du cours: " + ex.Message);
            }
            
            this.Hide();
            Form listCours = new ListeCours(uti);
            listCours.Show();

        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listCours = new ListeCours(uti);
            listCours.Show();
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