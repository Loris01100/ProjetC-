namespace _2SIO_FSI_Adminstration.Classe
{
    public class Section
    {
        private int idSection;
        private string libelleSection;

        public Section(int idSection, string libelleSection)
        {
            this.idSection = idSection;
            this.libelleSection = libelleSection;
        }
        
        public int IdSection { get => idSection; set => idSection = value; }
        public string LibelleSection { get => libelleSection; set => libelleSection = value; }
    }
}