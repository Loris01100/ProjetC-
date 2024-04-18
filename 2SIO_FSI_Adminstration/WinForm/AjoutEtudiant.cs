﻿using Npgsql;
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
    public partial class AjoutEtudiant : Form
    {
        private DAOEtudiant etudiantDAO;

        private Utilisateur x;
        public AjoutEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;
            etudiantDAO = new DAOEtudiant();
            RemplirComboBoxSections();
        }
        
        private void RemplirComboBoxSections()
        {
            DAOSection dao = new DAOSection();
            List<Section> mesSections = dao.GetAll();

            cbSection.DisplayMember = "LibelleSection";
            cbSection.ValueMember = "IdSection";
            cbSection.DataSource = mesSections;
        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = tbAENom.Text;
            string prenom = tbAEPrenom.Text;
            Section section = cbSection.SelectedItem as Section;
            string adresse = tbAEAdresse.Text;

            if (section == null)
            {
                MessageBox.Show("Veuillez sélectionner une section.");
                return;
            }

            bool ajoutReussi = DAOEtudiant.InsertEtudiant(nom, prenom, section, adresse);

            if (ajoutReussi)
            {
                MessageBox.Show("Étudiant ajouté avec succès.");
                reInitialisation();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'étudiant. Assurez-vous que tous les champs sont remplis.");
            }
        }

        private void reInitialisation()
        {
            tbAENom.Clear();
            tbAEPrenom.Clear();
            tbAEAdresse.Clear();
            cbSection.SelectedIndex = -1;
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