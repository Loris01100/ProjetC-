using System;
using System.Collections.Generic;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOEtudiant
    {
        public static bool InsertEtudiant(string nom, string prenom, Section section)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || section == null)
            {
                return false;
            }

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idSection) VALUES (:nom, :prenom, :idSection);";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("nom", nom);
                        commande.Parameters.AddWithValue("prenom", prenom);
                        commande.Parameters.AddWithValue("idSection", section.IdSection);
                        commande.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }




        public void UpdateEtudiant(int idetudiant, string newNom, string newPre)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE edudiant SET nometudiant =:nom, prenometudiant =:pre WHERE idEtudiant =:id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("nom", newNom);
                    commande.Parameters.AddWithValue("prenom", newPre);
                    commande.Parameters.AddWithValue("id", idetudiant);

                    commande.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEtudiant(int idEtudiant)
        {
            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "DELETE FROM etudiant WHERE idEtudiant = :id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = idEtudiant;
                        commande.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la suppression de l'étudiant", ex);
            }
        }
        
        public List<Etudiant> GetAll()
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "SELECT * FROM etudiant;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Etudiant etudiant = new Etudiant()
                            {
                                IdEtudiant = dr.GetInt32(0),
                                NomEtudiant = dr.GetString(1),
                                PrenomEtudiant = dr.GetString(2),
                                Adresse = dr.GetString(4)
                            };
                            etudiants.Add(etudiant);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la récupération des étudiants", ex);
            }

            return etudiants;
        }
        
        public Etudiant GetById(int idEtudiant)
        {
            Etudiant etudiant = null;

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "SELECT * FROM etudiant WHERE idEtudiant = :id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = idEtudiant;

                        using (var dr = commande.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                etudiant = new Etudiant
                                {
                                    IdEtudiant = dr.GetInt32(0),
                                    NomEtudiant = dr.GetString(1),
                                    PrenomEtudiant = dr.GetString(2),
                                    Adresse = dr.GetString(4)
                                    
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestion des exceptions
                throw new Exception("Erreur lors de la récupération de l'étudiant", ex);
            }

            return etudiant;
        }
    }
}