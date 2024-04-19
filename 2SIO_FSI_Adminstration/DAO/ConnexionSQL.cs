using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace _2SIO_FSI_Adminstration.DAO
{
    public class ConnexionSQL
    {
        private static NpgsqlConnection instance;
        private static readonly string Conx = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=080600;";

        private ConnexionSQL() { }

        public static NpgsqlConnection Instance
        {
            get
            {
                if (instance == null || instance.State != ConnectionState.Open)
                {
                    instance = new NpgsqlConnection(Conx);
                    instance.Open();
                }
                return instance;
            }
        }

    }

}