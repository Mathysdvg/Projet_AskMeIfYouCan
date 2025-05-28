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
    }
}
