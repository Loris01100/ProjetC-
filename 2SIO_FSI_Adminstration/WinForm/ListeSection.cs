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

            // Utilisation de ConnexionSQL.Instance pour la connexion
            using (var myCnx = ConnexionSQL.Instance)
            {
                string select = "SELECT * FROM section";
                using (var myCmd = new NpgsqlCommand(select, myCnx))
                using (var dr = myCmd.ExecuteReader())
                {
                    List<Section> mesSections = new List<Section>();
                    while (dr.Read())
                    {
                        int idSection = dr.GetInt32(0);
                        string libelleSection = dr.GetString(1);

                        Section uneSection = new Section(idSection, libelleSection);
                        mesSections.Add(uneSection);
                    }

                    // Affichage dans le dataGridView
                    foreach (Section sec in mesSections)
                    {
                        dgvSections.Rows.Add(sec.LibelleSection);
                    }
                }
            }
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
        private void updateDeleteSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUpdateDeleteSection = new updateDeleteSection(uti);
            formUpdateDeleteSection.Show();
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
            Form formUpdateDeleteCours = new updateDeleteCours(uti);
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
                    Process.GetCurrentProcess().Kill();
                    break;
            }        
        }
    }
}