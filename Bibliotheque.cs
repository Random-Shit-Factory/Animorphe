using System.Collections.Generic;

namespace DesignPatternObserver_Animorphe
{
    public class Bibliotheque
    {

        #region Attributs

        /// <summary>
        /// Attribution de la Liste d'Animaux à choisir
        /// </summary>
        private List<string> _listAnimaux;

        public List<string> ListAnimaux
        {
            get { return _listAnimaux; }
            set { _listAnimaux = value; }
        }

        #endregion



        #region Constructeur

        /// <summary>
        /// Création de la liste et des ajouts directs des valeurs (nom d'aniamux)
        /// </summary>
        public Bibliotheque()
        {
            _listAnimaux = new List<string>
            {
                "Albatros",//
                "Colibri",//
                "Perroquet",//
                "Dromadaire",//
                "Eléphant",//
                "Girafe",
                "Lamantin",
                "Maquereau",
                "Cachalot",
                "Otarie"
            };
        }

        #endregion
    }

}
