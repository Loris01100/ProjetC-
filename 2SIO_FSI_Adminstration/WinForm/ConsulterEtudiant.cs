using System;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ConsulterEtudiant : Form
    {
        private Etudiant etudiant;
        private Utilisateur x;
        private int idEtudiant;
        public ConsulterEtudiant(Etudiant etu, Utilisateur utiConnecte)
        {
            InitializeComponent();
            etudiant = etu;
            x = utiConnecte;
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