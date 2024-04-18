using System;
using System.Collections.Generic;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;


namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOEtudiant
    {
        public static bool InsertEtudiant(string nom, string prenom, Section section, string adresse)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || section == null)
            {
                return false;
            }

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete =
                        "INSERT INTO etudiant (nomEtudiant, prenometudiant, idSection, adresse) VALUES (:nom, :prenom, :idSection, :adresse);";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("nom", nom);
                        commande.Parameters.AddWithValue("prenom", prenom);
                        commande.Parameters.AddWithValue("idSection", section.IdSection);
                        commande.Parameters.AddWithValue("adresse", adresse);
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
                    string requete = "SELECT etudiant.idetudiant, etudiant.nomEtudiant, etudiant.prenomEtudiant, etudiant.adresse, section.idsection, section.libelleSection FROM etudiant INNER JOIN section ON etudiant.idsection = section.idsection;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Section uneSection = new Section();
                            int IdSection = dr.GetInt32(4); // idsection est un entier
                            string LibelleSection = dr.GetString(5); // libelleSection est une chaîne de caractères
                            uneSection.IdSection = IdSection;
                            uneSection.LibelleSection = LibelleSection;

                            int IdEtudiant = dr.GetInt32(0); // idetudiant est un entier
                            string NomEtudiant = dr.GetString(1); // nomEtudiant est une chaîne de caractères
                            string PrenomEtudiant = dr.GetString(2); // prenomEtudiant est une chaîne de caractères
                            string Adresse = dr.GetString(3); // adresse est une chaîne de caractères

                            Etudiant etudiant = new Etudiant(IdEtudiant, NomEtudiant, PrenomEtudiant, uneSection,
                                Adresse);

                            etudiants.Add(etudiant);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // C'est une bonne pratique de logger l'exception avant de la relancer.
                Console.WriteLine(ex.ToString());
                throw;
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
                    string requete = "SELECT etudiant.idetudiant, etudiant.nomEtudiant, etudiant.prenomEtudiant, etudiant.adresse, section.idsection, section.libelleSection FROM etudiant INNER JOIN section ON etudiant.idsection = section.idsection WHERE etudiant.idetudiant = @id;";

                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Integer)).Value = idEtudiant;

                        using (var dr = commande.ExecuteReader())
                        {
                            if (dr.Read()) 
                            {
                                Section uneSection = new Section
                                {
                                    IdSection = dr.GetInt32(4), 
                                    LibelleSection = dr.GetString(5)
                                };

                                etudiant = new Etudiant
                                {
                                    IdEtudiant = dr.GetInt32(0),
                                    NomEtudiant = dr.GetString(1),
                                    PrenomEtudiant = dr.GetString(2),
                                    Adresse = dr.GetString(3),
                                    IdSection = uneSection
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la récupération de l'étudiant avec l'ID {idEtudiant}", ex);
            }

            return etudiant; // Retourne l'objet Etudiant trouvé ou null
        }
    }
}