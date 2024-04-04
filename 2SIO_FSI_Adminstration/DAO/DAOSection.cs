using System;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOSection
    {
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
    }
}