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
        /// <summary>
        /// Initialise un objet de la classe Question avec un numéro un libelle un thème une difficulté et les propositions
        /// </summary>
        /// <param name="_numero">Le numéro de la question</param>
        /// <param name="_libelle">Le libelle de la question</param>
        /// <param name="_themeNumero">Le thème de la question</param>
        /// <param name="_niveauDifficulteId">Le niveau de difficulté de la question</param>
        /// <param name="_lesPropositions">Les propostions de la question</param>
        public Question(int _numero, String _libelle, String _themeNumero, String _niveauDifficulteId, List<Proposition> _lesPropositions)
        {
            this.Numero = _numero;
            this.Libelle = _libelle;
            this.Theme_Numero = _themeNumero;
            this.Niveau_Difficulte_Id = _niveauDifficulteId;
            this.LesPropositions = _lesPropositions;
        }
        #endregion

        #region Méthode(s)

        #endregion
    }
}
