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

            // Utilisation de ConnexionSQL.Instance pour la connexion
            using (var MyCnx = ConnexionSQL.Instance)
            {
                string select = "SELECT * FROM etudiant";
                using (var MyCmd = new NpgsqlCommand(select, MyCnx))
                using (var dr = MyCmd.ExecuteReader())
                {
                    List<Etudiant> mesEtudiants = new List<Etudiant>();
                    while (dr.Read())
                    {
                        int idEtudiant = dr.GetInt32(0);
                        string nomEtudiant = dr.GetString(1);
                        string prenomEtudiant = dr.GetString(2);
                        string adresse = dr.GetString(4);

                        Etudiant unEtudiant = new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant, adresse);
                        mesEtudiants.Add(unEtudiant);
                    }

                    // Affichage dans le dataGridView
                    foreach (Etudiant etu in mesEtudiants)
                    {
                        dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant, etu.Adresse);
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