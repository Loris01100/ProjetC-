﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {
        private DAOEtudiant etudiantDAO;

        public AjoutEtudiant()
        {
            InitializeComponent();
            etudiantDAO = new DAOEtudiant();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            List<Section> listSections = ObtenirSections(); 
            cbClasse.DisplayMember = "NomSection";
            cbClasse.ValueMember = "IdSection";
            
            cbClasse.DataSource = listSections;
            
            if (cbClasse.Items.Count > 0)
                cbClasse.SelectedIndex = 0;
        }

        private List<Section> ObtenirSections()
        {
            return new List<Section>
            {
                new Section(1, "Section A"),
                new Section(2, "Section B"),
            };
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            string nom = tbAENom.Text;
            string prenom = tbAEPrenom.Text;
            Section section = cbClasse.SelectedItem as Section;

            if (section == null)
            {
                MessageBox.Show("Veuillez sélectionner une section.");
                return;
            }

            bool ajoutReussi = DAOEtudiant.InsertEtudiant(nom, prenom, section);

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
            cbClasse.SelectedIndex = -1;
        }
    
        

        private void bouton2_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}