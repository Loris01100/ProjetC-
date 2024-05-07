using System;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeSection : Form
    {
        Utilisateur uti;
        
        public ListeSection(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            dgvSections.CellDoubleClick += dgvSections_CellDoubleClick;

            DAOSection dao = new DAOSection();
            List<Section> mesSections = dao.GetAll();
            
            dgvSections.Rows.Clear();
            foreach (Section sec in mesSections)
            {
                int index = dgvSections.Rows.Add();
                dgvSections.Rows[index].Cells["LibelleSection"].Value = sec.LibelleSection;
                dgvSections.Rows[index].Tag = sec.IdSection;
            }
        }
        private void dgvSections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int sectionId = (int)dgvSections.Rows[e.RowIndex].Tag;
                this.Hide();
                DAOSection dao = new DAOSection();
                Section section = dao.GetById(sectionId);
                Form formConsulterSection = new updateDeleteSection(section, uti, sectionId);
                formConsulterSection.Show();
            }
        }
        
        private void updateDeleteSection(int sectionId)
        {
            this.Hide();
            DAOSection dao = new DAOSection();
            Section section = dao.GetById(sectionId);
            Form formConsulterSection = new updateDeleteSection(section, uti, sectionId);
            formConsulterSection.Show();
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
        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
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
        private void ListeCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeCours = new ListeCours(uti);
            formListeCours.Show();
        }
        private void ajouterSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjoutSection = new AjoutSection(uti);
            formAjoutSection.Show();
        }
        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjouterCours = new AjouterUnCours(uti);
            formAjouterCours.Show();
        }
        private void updateDeleteSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUpdateDeleteSection = new updateDeleteSection(null ,uti, 0);
            formUpdateDeleteSection.Show();
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
                    Process.GetCurrentProcess().Kill();
                    break;
            }        
        }
    }
}