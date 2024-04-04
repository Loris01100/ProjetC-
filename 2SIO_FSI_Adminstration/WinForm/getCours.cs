using System.Windows.Forms;
using _2SIO_FSI_Adminstration.Classe;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class getCours : Form
    {
        Utilisateur uti;
        public getCours(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
        }
    }
}