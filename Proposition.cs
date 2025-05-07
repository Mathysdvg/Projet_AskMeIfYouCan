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

        #endregion
    }
}
