using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
                    string requete = "SELECT * from section";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    using (var dr = commande.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int IdSection = dr.GetInt32(0);
                            string LibelleSection = dr.GetString(1);

                            Section section = new Section(IdSection, LibelleSection);

                            sections.Add(section);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return sections;
        }
        
        public void UpdateSection(int idSection, string newLib)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE section SET libelleSection = @libelle WHERE idSection = @id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("@libelle", newLib);
                    commande.Parameters.AddWithValue("@id", idSection);

                    commande.ExecuteNonQuery();
                }
            }
        }
        
        public void RemoveSectionFromStudents(int idSection)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE etudiant SET idSection = NULL WHERE idSection = @idSection;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("@idSection", idSection);
                    commande.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSection(int idSection)
        {
            try
            {
                RemoveSectionFromStudents(idSection);  // Assurez-vous que plus aucun étudiant n'est lié à cette section

                using (var connexion = ConnexionSQL.Instance)
                {
                    string requete = "DELETE FROM section WHERE idSection = @id;";
                    using (var commande = new NpgsqlCommand(requete, connexion))
                    {
                        commande.Parameters.AddWithValue("@id", idSection);
                        int rowsAffected = commande.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Aucune section trouvée avec cet ID.");
                        }
                        MessageBox.Show("Section supprimée avec succès.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la section: " + ex.Message);
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
        public Section GetById(int sectionId)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                var requete = @"SELECT * from Section WHERE IdSection = @IdSection";
                using (var command = new NpgsqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@IdSection", sectionId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Section section = new Section()
                            {
                                IdSection = reader.GetInt32(reader.GetOrdinal("IdSection")),
                                LibelleSection = reader.GetString(reader.GetOrdinal("LibelleSection"))
                            };
                            return section;
                        }
                    }
                }
            }
            return null;
        }
    }
}