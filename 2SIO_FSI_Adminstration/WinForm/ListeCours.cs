using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeCours : Form
    {
        Utilisateur uti;
        public ListeCours(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            dgvCours.CellDoubleClick += dgvCours_CellDoubleClick;

            DAOCours dao = new DAOCours();
            List<Cours> mesCours = dao.GetAll();
            
            dgvCours.Rows.Clear();
            foreach (Cours cou in mesCours)
            {
                int index = dgvCours.Rows.Add();
                dgvCours.Rows[index].Cells["LibelleCours"].Value = cou.LibelleCours;
                dgvCours.Rows[index].Tag = cou.IdCours;
            }
        }
        private void dgvCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int coursId = (int)dgvCours.Rows[e.RowIndex].Tag;
                updateDeleteCours(coursId);
            }
        }
        
        private void updateDeleteCours(int coursId)
        {
            this.Hide();
            DAOCours dao = new DAOCours();
            Cours cours = dao.GetById(coursId);
            Form formConsulterSection = new updateDeleteCours(cours, uti);
            formConsulterSection.Show();
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
            Form formUpdateDeleteCours = new updateDeleteSection(null, uti, 0);
            formUpdateDeleteCours.Show();
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