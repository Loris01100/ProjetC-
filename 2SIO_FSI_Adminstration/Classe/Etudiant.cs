using System;
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
     

        public Etudiant(int id, string nom, string prenom)
        {
            this.idEtudiant = id;
            this.nomEtudiant = nom;
            this.prenomEtudiant = prenom;

        }

        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }

        public override string ToString()
        {
            return "Etudiant " + NomEtudiant;
        }
    }
}
