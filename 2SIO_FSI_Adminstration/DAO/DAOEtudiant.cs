using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
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




        public void UpdateEtudiant(int idetudiant, string newNom, string newPre, string newAdd)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE etudiant SET nometudiant = @nom, prenometudiant = @pre, adresse = @add WHERE idEtudiant = @id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("@nom", newNom);
                    commande.Parameters.AddWithValue("@pre", newPre);
                    commande.Parameters.AddWithValue("@add", newAdd);
                    commande.Parameters.AddWithValue("@id", idetudiant);

                    commande.ExecuteNonQuery();
                }
            }
        }
        
        public void UpdateSectionByEtudiant(int idEtudiant, string newLibelle)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requeteGetSection = "SELECT idSection FROM etudiant WHERE idEtudiant = @id;";
                int idSection = 0;
                using (var commandeGet = new NpgsqlCommand(requeteGetSection, connexion))
                {
                    commandeGet.Parameters.AddWithValue("@id", idEtudiant);
                    using (var reader = commandeGet.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idSection = reader.GetInt32(0);
                        }
                    }
                }
        
                if (idSection != 0)
                {
                    string requeteUpdateSection = "UPDATE section SET libelleSection = @libelle WHERE idSection = @idSection;";
                    using (var commandeUpdate = new NpgsqlCommand(requeteUpdateSection, connexion))
                    {
                        commandeUpdate.Parameters.AddWithValue("@libelle", newLibelle);
                        commandeUpdate.Parameters.AddWithValue("@idSection", idSection);

                        commandeUpdate.ExecuteNonQuery();
                    }
                }
            }
        }

        public int DeleteEtudiant(int idEtudiant)
        {
            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "DELETE FROM etudiant WHERE idEtudiant = :id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = idEtudiant;
                        return commande.ExecuteNonQuery();
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
                    string requete = "SELECT etudiant.idetudiant, etudiant.nomEtudiant, etudiant.prenomEtudiant, etudiant.adresse, section.idsection, section.libelleSection " +
                                     "FROM etudiant " +
                                     "LEFT JOIN section ON etudiant.idsection = section.idsection;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Section uneSection = null;
                            if (!dr.IsDBNull(4))
                            {
                                uneSection = new Section()
                                {
                                    IdSection = dr.GetInt32(4),
                                    LibelleSection = dr.IsDBNull(5) ? null : dr.GetString(5)
                                };
                            }

                            int IdEtudiant = dr.GetInt32(0);
                            string NomEtudiant = dr.GetString(1);
                            string PrenomEtudiant = dr.GetString(2);
                            string Adresse = dr.GetString(3);

                            Etudiant etudiant = new Etudiant(IdEtudiant, NomEtudiant, PrenomEtudiant, uneSection, Adresse);

                            etudiants.Add(etudiant);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return etudiants;
        }
        public List<Etudiant> GetEtudiantsBySection(int idSection)
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "SELECT e.idetudiant, e.nomEtudiant, e.prenomEtudiant, e.adresse, s.idsection, s.libelleSection " +
                                     "FROM etudiant e " +
                                     "LEFT JOIN section s ON e.idsection = s.idsection " +
                                     "WHERE e.idsection = @idSection;";

                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("@idSection", idSection);

                        using (var dr = commande.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Section uneSection = null;
                                if (!dr.IsDBNull(4))
                                {
                                    uneSection = new Section()
                                    {
                                        IdSection = dr.GetInt32(4),
                                        LibelleSection = dr.IsDBNull(5) ? null : dr.GetString(5)
                                    };
                                }

                                int IdEtudiant = dr.GetInt32(0);
                                string NomEtudiant = dr.GetString(1);
                                string PrenomEtudiant = dr.GetString(2);
                                string Adresse = dr.GetString(3);

                                Etudiant etudiant = new Etudiant(IdEtudiant, NomEtudiant, PrenomEtudiant, uneSection, Adresse);

                                etudiants.Add(etudiant);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return etudiants;
        }

        public Etudiant GetById(int etudiantId)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                var requete = @"SELECT e.idEtudiant, e.nomEtudiant, e.prenomEtudiant, e.adresse, s.idSection, s.libelleSection 
                        FROM Etudiant e 
                        LEFT JOIN Section s ON e.IdSection = s.IdSection 
                        WHERE e.IdEtudiant = @IdEtudiant";
    
                using (var command = new NpgsqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@IdEtudiant", etudiantId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Section section = null;
                            if (!reader.IsDBNull(reader.GetOrdinal("idSection")))
                            {
                                section = new Section
                                {
                                    IdSection = reader.GetInt32(reader.GetOrdinal("idSection")),
                                    LibelleSection = reader.IsDBNull(reader.GetOrdinal("libelleSection")) ? null : reader.GetString(reader.GetOrdinal("libelleSection"))
                                };
                            }

                            Etudiant etudiant = new Etudiant()
                            {
                                IdEtudiant = reader.GetInt32(reader.GetOrdinal("IdEtudiant")),
                                NomEtudiant = reader.GetString(reader.GetOrdinal("NomEtudiant")),
                                PrenomEtudiant = reader.GetString(reader.GetOrdinal("PrenomEtudiant")),
                                Adresse = reader.GetString(reader.GetOrdinal("Adresse")),
                                IdSection = section  // This will be null if the student is not linked to any section
                            };
                            return etudiant;
                        }
                    }
                }
            }
            return null;
        }
    }
}