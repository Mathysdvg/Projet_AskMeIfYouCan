using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AskMeIfYouCan
{
    internal class ReponseCRUD
    {
        private SQLiteConnection connection;

        /// <summary>
        /// Initialise une nouvelle instance de la classe ReponseCRUD avec le nom de la base de données
        /// </summary>
        /// <param name="nomBdd">nom de la base de données</param>
        public ReponseCRUD(string nomBdd)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdd + ".sqlite;Version=3;");
            connection.Open();
            CreerTable();
        }

        /// <summary>
        /// Fonction créant la table reponse si elle n'existe pas 
        /// </summary>
        public void CreerTable()
        {
            //création d'une table reponse, elle dispose d'un numero de question et d'un numero de proposition en clé primaire,
            //une bonne reponse de type int
            string createTableQuery = "CREATE TABLE IF NOT EXISTS question " +
                "(Question_numero INTEGER NOT NULL," +
                "Proposition_numero INTEGER NOT NULL," +
                "BonnRep INTEGER NOT NULL," +
                "PRIMARY KEY (Question_numero, Proposition_numero));";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);

            command.ExecuteNonQuery();
        }
    }
}
