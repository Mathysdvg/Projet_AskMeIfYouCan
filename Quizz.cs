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
        public List<Question> ListeQuestion
        {
            get { return listeQuestion; }
            set { listeQuestion = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

        public string NiveauDifficulte
        {
            get { return niveauDifficulte; }
            set { niveauDifficulte = value; }
        }

        #endregion

        #region Constructeur(s)

        #endregion

        #region Méthode(s)

        #endregion
    }
}
