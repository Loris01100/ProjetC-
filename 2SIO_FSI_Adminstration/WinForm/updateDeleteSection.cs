using System;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class updateDeleteSection : Form
    {
        private Section section;
        private Utilisateur x;
        public updateDeleteSection(Section sec, Utilisateur utiConnecte)
        {
            InitializeComponent();
            section = sec;
            x = utiConnecte;
            DetailEtudiant();
        }
        private void DetailEtudiant()
        {
            tbAESection.Text = section.LibelleSection;
        }
        
        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(x);
            listEtudiant.Show();
        }
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(x);
            listEtudiant.Show();
        }
        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(x);
            listEtudiant.Show();
            
        }
        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listEtudiant = new ListeEtudiant(x);
            listEtudiant.Show();
        }
    }
}