using System.Collections.Generic;
using System.Windows.Forms;

namespace DesignPatternObserver_Animorphe
{
    public abstract class Sujet
    {

        #region Attributs

        /// <summary>
        /// Creation de la liste d'observateurs ou abonnés
        /// </summary>
        private List<IObservateur> mesObserveurs = new List<IObservateur>();

        #endregion



        #region Méthodes

        /// <summary>
        /// Methode d'abonnement aux évênements de Sujet
        /// </summary>
        /// <param name="observeur"></param>
        public void Attach(IObservateur observeur)
        {
            mesObserveurs.Add(observeur);
        }

        /// <summary>
        /// Methode de désabonnement aux évênements de Sujet
        /// </summary>
        /// <param name="observeur"></param>
        public void Detach(IObservateur observeur)
        {
            mesObserveurs.Remove(observeur);
        }

        /// <summary>
        /// Methode qui permet de notifier aux abonnés les changements d'etat et lancer les mises à jours
        /// </summary>
        /// <param name="lstViewAnimaux"></param>
        /// <param name="Form1Objet"></param>
        public void Notify(ListView lstViewAnimaux, Form1 Form1Objet)
        {
            foreach (IObservateur o in mesObserveurs)
            {
                o.Update(lstViewAnimaux);
                o.Update(Form1Objet);
            }
        }

        #endregion
    }
}
