using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.DAO;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class updateDeleteSection : Form
    {
        Utilisateur uti;
        private DAOSection sectionDAO;
        public updateDeleteSection(Utilisateur utiConnecte)
        {
            InitializeComponent();
            Utilisateur uti;
        }
    }
}