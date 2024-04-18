using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutSection : Form
    {
        private DAOSection sectionDAO;

        private Utilisateur x;
        public AjoutSection(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;
            sectionDAO = new DAOSection();
        }
        
        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            string libelle = tbAELibelle.Text;

            bool ajoutReussi = DAOSection.InsertSection(libelle);

            if (ajoutReussi)
            {
                MessageBox.Show("Section ajouté avec succès.");
                reInitialisation();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la section. Assurez-vous que tous les champs sont remplis.");
            }
        }

        private void reInitialisation()
        {
            tbAELibelle.Clear();
        }
    
        

        private void boutonEffacer_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Accueil(x);
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
                    Process.GetCurrentProcess().Kill();
                    break;
            }        
        }
    }
}