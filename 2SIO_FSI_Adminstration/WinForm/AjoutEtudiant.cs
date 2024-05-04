using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {
        private DAOEtudiant etudiantDAO;

        private Utilisateur uti;
        public AjoutEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            etudiantDAO = new DAOEtudiant();
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

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = tbAENom.Text;
            string prenom = tbAEPrenom.Text;
            Section section = cbSection.SelectedItem as Section;
            string adresse = tbAEAdresse.Text;

            if (section == null)
            {
                MessageBox.Show("Veuillez sélectionner une section.");
                return;
            }

            bool ajoutReussi = DAOEtudiant.InsertEtudiant(nom, prenom, section, adresse);

            if (ajoutReussi)
            {
                MessageBox.Show("Étudiant ajouté avec succès.");
                reInitialisation();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'étudiant. Assurez-vous que tous les champs sont remplis.");
            }
        }

        private void reInitialisation()
        {
            tbAENom.Clear();
            tbAEPrenom.Clear();
            tbAEAdresse.Clear();
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
        private void updateDeleteSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUpdateDeleteCours = new updateDeleteSection(null, uti);
            formUpdateDeleteCours.Show();
        }
        private void getCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formGetCours = new getCours(uti);
            formGetCours.Show();
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