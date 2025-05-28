using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Projet_AskMeIfYouCan.QuestionCRUD;

namespace Projet_AskMeIfYouCan
{
    public class Quizz
    {
        #region Propriété(s)
        private QuestionCRUD questionBdd;
        private List<Question> listeQuestion;
        private int score;
        private string theme;
        private string niveauDifficulte;
        private List<Question> questionsPosees;
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

        /// <summary>
        /// Obtient la liste des questions posées
        /// </summary>
        public List<Question> QuestionsPosees
        {
            get { return questionsPosees; }
            private set { questionsPosees = value; }
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
        public Quizz(int _score, string _theme, string _niveauDifficulte)
        {
            questionBdd = new QuestionCRUD("2025_Quiz_Cyber.sqlite");
            this.listeQuestion = questionBdd.ListeQuestion(_theme,_niveauDifficulte) ;
            this.score = _score;
            this.theme = _theme;
            this.niveauDifficulte= _niveauDifficulte;
            this.QuestionsPosees = new List<Question>();
        }
        #endregion

        #region Méthode(s)
        /// <summary>
        /// Augmente le score du joueur
        /// </summary>
        public void AugmenteScore()
        {
            score++;
        }

        /// <summary>
        /// Passe à la question suivante dans le quizz
        /// </summary>
        /// <returns>La question suivante ou null s'il n'y en a plus</returns>
        public Question QuestionSuivante()
        {
            // On filtre les questions non encore posées
            List<Question> questionsRestantes = listeQuestion.Except(questionsPosees).ToList();

            if (questionsRestantes.Count == 0)
            {
                return null; // Toutes les questions ont été posées
            }

            // Choisir une question au hasard parmi celles restantes
            Random nbAlea = new Random();
            Question uneQuestion = questionsRestantes[nbAlea.Next(questionsRestantes.Count)];

            // Ajouter la question aux posées
            questionsPosees.Add(uneQuestion);

            return uneQuestion;
        }

        public void estFini()
        {
            if (QuestionsPosees.Count == 20)
            {

            }
        }
        #endregion
    }
}
