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
        Utilisateur uti;
        public Connexion()
        {
            InitializeComponent();
        }


        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;

            Utilisateur uti = DAOUtilisateur.Authentifier(loginUti, mdpUti);
            if (uti != null)
            {
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
