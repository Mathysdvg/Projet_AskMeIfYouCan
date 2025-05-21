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
        /// <summary>
        /// Obtient le numéro de la question
        /// </summary>
        public int Numero
        {
            get { return numero; }
            private set { numero = value; }
        }

        /// <summary>
        /// Obtient le libelle de la question
        /// </summary>
        public String Libelle
        {
            get { return libelle; }
            private set { libelle = value; }
        }

        /// <summary>
        /// Obtient le thème de la question
        /// </summary>
        public String Theme_Numero
        {
            get { return themeNumero; }
            private set { themeNumero = value; }
        }

        /// <summary>
        /// Obtient le niveau de difficulté de la question
        /// </summary>
        public String Niveau_Difficulte_Id
        {
            get { return niveauDifficulteId; }
            private set { niveauDifficulteId = value; }
        }

        /// <summary>
        /// Obtient la liste des propositions de la question
        /// </summary>
        public List<Proposition> LesPropositions
        {
            get { return lesPropositions; }
            private set { lesPropositions = value; }
        }
        #endregion

        #region Constructeur(s)

        #endregion

        #region Méthode(s)

        #endregion
    }
}
