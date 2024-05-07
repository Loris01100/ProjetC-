using System;
using System.Collections.Generic;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOCours
    {
        public void UpdateCours(int idCours, string newLib)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE cours SET libelleCours = @libelle WHERE idCours = @id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("@libelle", newLib);
                    commande.Parameters.AddWithValue("@id", idCours);

                    commande.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCours(int idCours)
        {
            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "DELETE FROM cours WHERE idCours = :id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = idCours;
                        commande.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la suppression du cours", ex);
            }
        }

        public List<Cours> GetAll()
        {
            List<Cours> cour = new List<Cours>();

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "SELECT * FROM cours;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cours cours = new Cours()
                            {
                                IdCours = dr.GetInt32(0),
                                LibelleCours = dr.GetString(1),
                                DescriptionCours = dr.GetString(2)
                            };
                            cour.Add(cours);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la récupération des cours", ex);
            }

            return cour;
        }

        public Cours GetById(int coursId)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                var requete = @"SELECT * from Cours WHERE IdCours = @IdCours";
                using (var command = new NpgsqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@IdCours", coursId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Cours cours = new Cours()
                            {
                                IdCours = reader.GetInt32(reader.GetOrdinal("IdCours")),
                                LibelleCours = reader.GetString(reader.GetOrdinal("LibelleCours")),
                                DescriptionCours = reader.GetString(reader.GetOrdinal("descriptionCours"))
                            };
                            return cours;
                        }
                    }
                }
            }

            return null;
        }

        public static bool InsertCours(string libelle, string descr, Section section)
        {
            if (string.IsNullOrWhiteSpace(libelle) || string.IsNullOrWhiteSpace(descr) || section == null)
            {
                return false;
            }

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete =
                        "INSERT INTO cours (libelleCours, descriptionCours, idSection) VALUES (:libelle, :descr, :idSection);";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("libelle", libelle);
                        commande.Parameters.AddWithValue("descr", descr);
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
        
        public List<Section> GetSectionsByCours(int idCours)
        {
            List<Section> sections = new List<Section>();

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = @"SELECT s.idsection, s.libellesection FROM section s LEFT JOIN cours c ON s.idsection = c.idsection WHERE c.idcours = @idCours;";

                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("@idCours", idCours);

                        using (var dr = commande.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Section section = new Section
                                {
                                    IdSection = dr.GetInt32(0),
                                    LibelleSection = dr.GetString(1)
                                };

                                sections.Add(section);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return sections;
        }

    }
}