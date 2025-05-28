using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AskMeIfYouCan
{
    public class PropositionsCRUD
    {
        private SQLiteConnection connection;

        /// <summary>
        /// Initialise une nouvelle instance de la classe PropositionsCRUD avec le nom de la base de données
        /// </summary>
        /// <param name="nomBdd">nom de la base de données</param>
        public PropositionsCRUD(string nomBdd)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdd + ".sqlite;Version=3;");
            connection.Open();
            CreerTable();
        }

        /// <summary>
        /// Fonction créant la table propositions si elle n'existe pas 
        /// </summary>
        public void CreerTable()
        {
            //création d'une table propositions, elle dispose d'un numero clé primaire,
            //un libelle de type text
            string createTableQuery = "CREATE TABLE IF NOT EXISTS propositions " +
                "(Numero INTEGER PRIMARY KEY NOT NULL," +
                "Libelle TEXT NOT NULL);";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Retourne la liste des propositions trouvés selon l'id de la question transmis en paramètre
        /// </summary>
        /// <param name="idQuestion">id de la question dont on veut avoir les propositions</param>
        /// <returns>une liste de proposition</returns>
        public List<Proposition> ListProposition(string idQuestion)
        {
            List<Proposition> ListProposition = new List<Proposition>();
            // Obtenir les propositions liée a une question 
            string query = "SELECT * FROM proposition" +
                "INNER JOIN reponse ON reponse.Proposition = proposition.numero" +
                "WHERE reponse.Question_numero = @idQuestion";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@idQuestion", idQuestion);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Proposition uneProposition = new Proposition(
                    int.Parse(reader["Numero"].ToString()),
                    reader["Libelle"].ToString()
                    );
                ListProposition.Add(uneProposition);
            }
            return ListProposition;
        }
    }
}
