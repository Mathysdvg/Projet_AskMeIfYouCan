using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AskMeIfYouCan
{
    public class Quizz
    {
        #region Propriété(s)

        private List<Question> listeQuestion;
        private int score;
        private string theme;
        private string niveauDifficulte;
        #endregion

        #region Accesseur(s)
        /// <summary>
        /// Obtient la liste des questions
        /// </summary>
        public List<Question> ListeQuestion
        {
            get { return listeQuestion; }
            private set { listeQuestion = value; }
        }

        /// <summary>
        /// Obtient le Score
        /// </summary>
        public int Score
        {
            get { return score; }
            private set { score = value; }
        }

        /// <summary>
        /// Obtient le thème du quizz
        /// </summary>
        public string Theme
        {
            get { return theme; }
            private set { theme = value; }
        }

        /// <summary>
        /// Obtient le niveau de difficulté du quizz
        /// </summary>
        public string NiveauDifficulte
        {
            get { return niveauDifficulte; }
            private set { niveauDifficulte = value; }
        }

        #endregion

        #region Constructeur(s)
        /// <summary>
        /// Initialise un objet de la classe quizz avec une liste de question un score un thème et un niveau de difficulté
        /// </summary>
        /// <param name="_listeQuestion">La liste des questions du quizz</param>
        /// <param name="_score">Le score du joueur</param>
        /// <param name="_theme">Le thème du quizz</param>
        /// <param name="_niveauDifficulte">Le niveau de difficulté du quizz</param>
        public Quizz(List<Question> _listeQuestion, int _score, string _theme, string _niveauDifficulte)
        {
            this.listeQuestion = _listeQuestion;
            this.score = _score;
            this.theme = _theme;
            this.niveauDifficulte= _niveauDifficulte;
        }
        #endregion

        #region Méthode(s)

        #endregion
    }
}
