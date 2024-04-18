using System;
using System.Collections.Generic;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOSection
    {
        public List<Section> GetAll()
        {
            List<Section> sections = new List<Section>();

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "SELECT * FROM section;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Section section = new Section()
                            {
                                IdSection = dr.GetInt32(0),
                                LibelleSection = dr.GetString(1),
                            };
                            sections.Add(section);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la récupération des sections", ex);
            }

            return sections;
        }
        public void UpdateSection(int idSection, string newLib)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE section SET libelleSection where idSection =:id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("libelleSection", newLib);
                    commande.Parameters.AddWithValue("idSection", idSection);

                    commande.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSection(int idSection)
        {
            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "DELETE FROM section WHERE idSection = :id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = idSection;
                        commande.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la suppression de la section", ex);
            }
        }
        
        public static bool InsertSection(string libelle)
        {
            if (string.IsNullOrWhiteSpace(libelle))
            {
                return false;
            }

            try
            {
                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "INSERT INTO section (libelleSection) VALUES (@libelle);";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("@libelle", libelle);
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
    }
}