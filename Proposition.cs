using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AskMeIfYouCan
{
    public class Proposition
    {
        #region Propriété(s)
        private int numero;
        private String libelle;
        #endregion

        #region Assesseur(s)
        /// <summary>
        /// Obtient le numéro de la proposition
        /// </summary>
        public int Numero
        {
            get { return numero; }
            private set { numero = value; }
        }

        /// <summary>
        /// Obtient le libelle de la proposition
        /// </summary>
        public String Libelle
        {
            get { return libelle; }
            private set { libelle = value; }
        }
        #endregion

        #region Constructeur(s)
        /// <summary>
        /// Initialise une objet de la classe Proposition avec son numéo et son libelle
        /// </summary>
        /// <param name="_numero">Le numéro de la proposition</param>
        /// <param name="_libelle">Le libelle de la proposition</param>
        public Proposition(int _numero, String _libelle)
        {
            this.Numero = _numero;
            this.Libelle = _libelle;
        }
        #endregion

        #region Méthode(s)

        #endregion
    }
}
