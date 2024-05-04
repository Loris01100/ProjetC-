using System;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ConsulterEtudiant : Form
    {
        private Etudiant etudiant;
        private Utilisateur uti;
        private int idEtudiant;
        public ConsulterEtudiant(Etudiant etu, Utilisateur utiConnecte)
        {
            InitializeComponent();
            etudiant = etu;
            uti = utiConnecte;
            DetailEtudiant();
        }
        private void DetailEtudiant()
        {
            tbAENom.Text = etudiant.NomEtudiant;
            tbAEPrenom.Text = etudiant.PrenomEtudiant;
            tbAESection.Text = etudiant.IdSection.LibelleSection;
            tbAEAdresse.Text = etudiant.Adresse;
        }
        

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(uti);
            listEtudiant.Show();
        }
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(uti);
            listEtudiant.Show();
        }
        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(uti);
            listEtudiant.Show();
            
        }
        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(uti);
            listEtudiant.Show();
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