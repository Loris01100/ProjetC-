﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Etudiant
    {
        private int idEtudiant;
        private string nomEtudiant;
        private string prenomEtudiant;
        private Section idSection;
        private string adresse;
     

        public Etudiant(int id, string nom, string prenom, Section idSection, string adresse)
        {
            this.idEtudiant = id;
            this.nomEtudiant = nom;
            this.prenomEtudiant = prenom;
            this.idSection = idSection;
            this.adresse = adresse;

        }

        public Etudiant()
        {
        }

        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }

        public Section IdSection
        {
            get => idSection;
            set => idSection = value;
        }

        public string Adresse { get => adresse; set => adresse = value; }

        public override string ToString()
        {
            return "Etudiant " + NomEtudiant;
        }
    }
}
