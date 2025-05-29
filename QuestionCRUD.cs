using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AskMeIfYouCan
{
    public class QuestionCRUD
    {
        private SQLiteConnection connection;

        /// <summary>
        /// Initialise une nouvelle instance de la classe QuestionCRUD avec le nom de la base de données
        /// </summary>
        /// <param name="nomBdd">nom de la base de données</param>
        public QuestionCRUD(string nomBdd)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdd + ".sqlite;Version=3;");
            connection.Open();
            CreerTable();
        }

        /// <summary>
        /// Fonction créant la table question si elle n'existe pas 
        /// </summary>
        public void CreerTable()
        {
            //création d'une table question, elle dispose d'un numero clé primaire,
            //un libelle, un niveau de difficulté et un thème de type text
            string createTableQuery = "CREATE TABLE IF NOT EXISTS question " +
                "(Numero INTEGER PRIMARY KEY NOT NULL," +
                "Libelle TEXT NOT NULL," +
                "NiveauDifficulte_id TEXT NOT NULL," +
                "Theme_numero TEXT NOT NULL);";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Retourne la liste des questions trouvés selon le theme et la difficulté transmis en paramètre
        /// </summary>
        /// <param name="theme">theme dont on veut avoir les questions</param>
        /// <param name="difficulte">difficulte dont on veut avoir les questions</param>
        /// <returns>une liste de question</returns>
        public List<Question> ListeQuestion(string theme, string difficulte)
        {
            List<Question> listQuestion = new List<Question>();
            // Obtenir les Questions dont le theme et la difficulte contiennent les filtres
            string query = "SELECT * FROM question WHERE Theme_numero = @theme AND NiveauDifficulte_id = @difficulte";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@theme", theme);
            command.Parameters.AddWithValue("@difficulte", difficulte);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Question uneQuestion = new Question(
                    int.Parse(reader["numero"].ToString()),
                    reader["libelle"].ToString(),
                    reader["NiveauDifficulte_id"].ToString(),
                    reader["Theme_numero"].ToString()
                    );
                listQuestion.Add(uneQuestion);
            }
            return listQuestion;
        }
    }
}
