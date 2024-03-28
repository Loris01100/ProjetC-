using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }


        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;

            using (var MyCnx = ConnexionSQL.Instance)
            {
                string select = "SELECT * FROM utilisateur WHERE loginutilisateur = :login AND mdputilisateur = :mdp;";
                using (var MyCmd = new NpgsqlCommand(select, MyCnx))
                {
                    MyCmd.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar)).Value = loginUti;
                    MyCmd.Parameters.Add(new NpgsqlParameter("mdp", NpgsqlDbType.Varchar)).Value = mdpUti; // Assurez-vous que mdpUti est hashé si nécessaire

                    using (var dr = MyCmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Traitement si l'utilisateur est trouvé
                            int idUti = dr.GetInt32(0);
                            loginUti = dr.GetString(1);
                            mdpUti = dr.GetString(2);
                            Utilisateur uti = new Utilisateur(idUti, loginUti, mdpUti);

                            this.Hide();
                            Form formAccueil = new Accueil(uti);
                            formAccueil.Show();
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'authentification");
                            tbLogin.Text = "";
                            tbMdp.Text = "";
                        }
                    }
                }
            }
        }
    }
}
