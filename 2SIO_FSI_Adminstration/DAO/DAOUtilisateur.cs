using _2SIO_FSI_Adminstration.Classe;
using Npgsql;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class DAOUtilisateur
    {
         public static Utilisateur Authentifier(string login, string mdp)
            {
                using (var myCnx = ConnexionSQL.Instance)
                {
                    string select = "SELECT idUtilisateur, loginUtilisateur, nomUtilisateur FROM utilisateur WHERE loginutilisateur = @login AND mdputilisateur = @mdp";
                    using (var myCmd = new NpgsqlCommand(select, myCnx))
                    {
                        myCmd.Parameters.AddWithValue("@login", login);
                        myCmd.Parameters.AddWithValue("@mdp", mdp);
        
                        using (var dr = myCmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int idUti = dr.GetInt32(0);
                                string loginRetrieved = dr.GetString(1);
                                string nomUti = dr.GetString(2);
        
                                return new Utilisateur(idUti, loginRetrieved, nomUti);
                            }
                        }
                    }
                }
                return null;
            }
    }
}