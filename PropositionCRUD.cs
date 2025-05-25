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
        }
    }
}
