namespace _2SIO_FSI_Adminstration.Classe
{
    public class Cours
    {
        private int idCours;
        private string libelleCours;
        private string descriptionCours;

        public Cours(int idCours, string libelleCours, string descriptionCours)
        {
            this.idCours = idCours;
            this.libelleCours = libelleCours;
            this.descriptionCours = descriptionCours;
        }

        public Cours()
        {
        }

        public int IdCours
        {
            get => idCours;
            set => idCours = value;
        }

        public string LibelleCours
        {
            get => libelleCours;
            set => libelleCours = value;
        }

        public string DescriptionCours
        {
            get => descriptionCours;
            set => descriptionCours = value;
        }
    }
}