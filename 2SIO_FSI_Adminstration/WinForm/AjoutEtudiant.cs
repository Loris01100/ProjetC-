using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {
        public AjoutEtudiant()
        {
            InitializeComponent();
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            string a = tbAENom.Text;
            string z = tbAEPrenom.Text;

            try
            {
                using (var maConnexion = ConnexionSQL.Instance)
                {
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idSection) values (:1, :2, 1);";
                    using (var commande = new NpgsqlCommand(pufff, maConnexion))
                    {
                        commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                        commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = z;
                        commande.Prepare();
                        commande.CommandType = CommandType.Text;
                        commande.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Etudiant ajouté");
                reInitialisation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message);
            }
        }

        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}