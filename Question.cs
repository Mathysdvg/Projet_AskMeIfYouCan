namespace Projet_AskMeIfYouCan
{
    public class Question
    {
        #region Propriété(s)

        #endregion
        private int numero;
        private String libelle;
        private String themeNumero;
        private String niveauDifficulteId;
        private List<Proposition> lesPropositions;

        public List<Proposition> MyProperty
        {
            get { return lesPropositions; }
            set { lesPropositions = value; }
        }




        #region Assesseur(s)

        #endregion
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
        #region Constructeur(s)

        #endregion

        #region Méthode(s)

        #endregion
    }
}
