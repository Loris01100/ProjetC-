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
        Utilisateur x;
       

        public ListeEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;
            dgvEtudiants.CellDoubleClick += dgvEtudiants_CellDoubleClick;

            DAOEtudiant dao = new DAOEtudiant();
            List<Etudiant> mesEtudiants = dao.GetAll();
            
            dgvEtudiants.Rows.Clear();
            foreach (Etudiant etu in mesEtudiants)
            {
                int index = dgvEtudiants.Rows.Add();
                dgvEtudiants.Rows[index].Cells["NomEtudiant"].Value = etu.NomEtudiant;
                dgvEtudiants.Rows[index].Cells["PrenomEtudiant"].Value = etu.PrenomEtudiant;
                dgvEtudiants.Rows[index].Cells["LibelleSection"].Value = etu.IdSection.LibelleSection;
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
            Form formConsulterEtudiant = new ConsulterEtudiant(etudiant, x);
            formConsulterEtudiant.Show();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Accueil(x);
            formAccueil.Show();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeEtudiant = new ListeEtudiant(x);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAjouterEtudiant = new AjoutEtudiant(x);
            formAjouterEtudiant.Show();
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Accueil(x);
            formAccueil.Show();
        }
        private void listeDesSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formListeSection = new ListeSection(x);
            formListeSection.Show();
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