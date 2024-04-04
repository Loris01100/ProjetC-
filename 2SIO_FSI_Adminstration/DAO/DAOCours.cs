using System;
using System.Collections.Generic;
using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOCours
    {
        public void UpdateCours(int idCours, string newLibe, string newDesc)
        {
            using (var connexion = ConnexionSQL.Instance)
            {
                string requete = "UPDATE edudiant SET libelleCours =:libe, descriptionCours =:desc WHERE idCours =:id;";
                using (var commande = new NpgsqlCommand(requete, connexion))
                {
                    commande.Parameters.AddWithValue("libe", newLibe);
                    commande.Parameters.AddWithValue("desc", newDesc);
                    commande.Parameters.AddWithValue("id", idCours);

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
        
    }
}