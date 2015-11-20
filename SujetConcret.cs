using System.Collections.Generic;
using System.Windows.Forms;

namespace DesignPatternObserver_Animorphe
{
    class SujetConcret : Sujet
    {

        #region Attributs
        
        /// <summary>
        /// Création de la Liste d'animorphes créés
        /// </summary>
        private List<Animorphe> _mesAnimorphes;


        /// <summary>
        /// Accesseurs/Mutateurs
        /// </summary>
        public List<Animorphe> MesAnimorphes
        {
            get { return _mesAnimorphes; }
            private set { _mesAnimorphes = value; }
        }

        #endregion



        #region Constructeur

        /// <summary>
        /// Constructeur du Sujet Concret
        /// </summary>
        public SujetConcret()
        {
            _mesAnimorphes = new List<Animorphe>();
        }

        #endregion



        #region Méthodes

        /// <summary>
        /// Methode qui permet d'ajouter un abonné et de notifier une mise à jour.
        /// </summary>
        /// <param name="animorphe"></param>
        /// <param name="lstViewAnimaux"></param>
        /// <param name="Form1Objet"></param>
        public void AjouterAnimorphe(Animorphe animorphe, ListView lstViewAnimaux, Form1 Form1Objet)
        {
            _mesAnimorphes.Add(animorphe);
            base.Notify(lstViewAnimaux, Form1Objet);
        }

        #endregion
    }
}
