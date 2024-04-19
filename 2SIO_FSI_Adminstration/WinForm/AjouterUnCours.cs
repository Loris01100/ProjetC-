using System;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjouterUnCours : Form
    {
        Utilisateur uti;
        public AjouterUnCours(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
        }
        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
        
    }
}