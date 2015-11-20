using System;

namespace DesignPatternObserver_Animorphe
{
    class Pattes
    {

        #region Attributs

        /// <summary>
        /// Affectation du Nom de l'Animal choisi par le random dans la liste de la bibliothèque.
        /// </summary>
        private string _nomAnimal;

        public string NomAnimal
        {
            get { return _nomAnimal; }
            set { _nomAnimal = value; }
        }


        /// <summary>
        /// Attribution du nom de l'animal, choisi par random dans la liste de la bibliotheque, qui constituera les pattes de l'animal.
        /// </summary>
        private string _particuleNom;

        public string ParticuleNom
        {
            get { return _particuleNom; }
            set { _particuleNom = value; }
        }


        /// <summary>
        /// Récuperation du numéro de l'index de l'animal choisi par le random dans la liste de la bibliothèque.
        /// </summary>
        private int _indexPattes;

        public int IndexPattes
        {
            get { return _indexPattes; }
            set { _indexPattes = value; }
        }

        #endregion



        #region Constructor

        /// <summary>
        /// Constructeur de la Class Pattes
        /// </summary>
        /// <param name="tete">Récupère l'objet Tete</param>
        /// <param name="corps">Récupère l'objet Corps</param>
        public Pattes(Tete tete, Corps corps)
        {
            this.RandomAnimal(tete, corps);
            this.RécupererParticuleNom();
        }

        #endregion



        #region Methodes

        /// <summary>
        /// Cette Méthode permet de choisir le nom d'un animal par random dans la liste d'animaux de la bibliotheque.
        /// Le random choisi un index du tableau (de 0 à 8).
        /// </summary>
        /// <param name="tete"></param>
        /// <param name="corps"></param>
        public void RandomAnimal(Tete tete, Corps corps)
        {
            Bibliotheque liste = new Bibliotheque();
            Random rand = new Random();
            do
            {
                _indexPattes = rand.Next(liste.ListAnimaux.Count);
            } while (_indexPattes == tete.IndexTete || _indexPattes == corps.IndexCorps);
            _nomAnimal = liste.ListAnimaux[_indexPattes];
        }

        /// <summary>
        /// Cette Méthode permet de récuperer la 3eme Syllabe de l'animal choisi.
        /// </summary>
        /// <returns></returns>
        public string RécupererParticuleNom()
        {
            int[] posVoyelle = Fonctions.AnalyserNom(NomAnimal);
            string syllabe = Fonctions.RecupererSyllabePattes(NomAnimal, posVoyelle);
            ParticuleNom = syllabe.ToLower();
            return ParticuleNom;
        }

        #endregion
    }
}
