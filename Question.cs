namespace Projet_AskMeIfYouCan
{
    public class Question
    {
        #region Propriété(s)
        private int numero;
        private String libelle;
        private String themeNumero;
        private String niveauDifficulteId;
        private List<Proposition> lesPropositions;
        #endregion

        #region Assesseur(s)
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public String Theme_Numero
        {
            get { return themeNumero; }
            set { themeNumero = value; }
        }

        public String Niveau_Difficulte_Id
        {
            get { return niveauDifficulteId; }
            set { niveauDifficulteId = value; }
        }

        public List<Proposition> LesPropositions
        {
            get { return lesPropositions; }
            set { lesPropositions = value; }
        }
        #endregion

        #region Constructeur(s)

        #endregion

        #region Méthode(s)

        #endregion
    }
}
