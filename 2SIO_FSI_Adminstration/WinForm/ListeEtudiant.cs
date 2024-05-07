using System;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeEtudiant : Form
    {
        Utilisateur uti;
       

        public ListeEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            dgvEtudiants.CellDoubleClick += dgvEtudiants_CellDoubleClick;

            DAOEtudiant dao = new DAOEtudiant();
            List<Etudiant> mesEtudiants = dao.GetAll();
    
            dgvEtudiants.Rows.Clear();
            foreach (Etudiant etu in mesEtudiants)
            {
                int index = dgvEtudiants.Rows.Add();
                dgvEtudiants.Rows[index].Cells["NomEtudiant"].Value = etu.NomEtudiant;
                dgvEtudiants.Rows[index].Cells["PrenomEtudiant"].Value = etu.PrenomEtudiant;
                dgvEtudiants.Rows[index].Cells["LibelleSection"].Value = etu.IdSection?.LibelleSection ?? "Non assigné";  // Gérer les sections nulles
                dgvEtudiants.Rows[index].Tag = etu.IdEtudiant;
            }
        }
        private void dgvEtudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int etudiantId = (int)dgvEtudiants.Rows[e.RowIndex].Tag;
                ConsulterEtudiant(etudiantId);
            }
        }
        
        private void ConsulterEtudiant(int etudiantId)
        {
            this.Hide();
            DAOEtudiant dao = new DAOEtudiant();
            Etudiant etudiant = dao.GetById(etudiantId);
            Form formConsulterEtudiant = new ConsulterEtudiant(etudiant, uti);
            formConsulterEtudiant.Show();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
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