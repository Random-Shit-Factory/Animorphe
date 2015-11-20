using System;

namespace DesignPatternObserver_Animorphe
{
    class Corps
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
        /// Attribution du nom de l'animal, choisi par random dans la liste de la bibliotheque, qui constituera le corps de l'animal.
        /// </summary>
        private string _particuleNom;

        public string ParticuleNom
        {
            get { return _particuleNom; }
            set { _particuleNom = value; }
        }


        /// <summary>
        /// Récuperation du numéro de l'index de l'animal choisi par le random dans la liste de la bibliothèque.
        /// L'enregistrement de cet index permettra au random de la Class Pattes afin d'eviter
        /// de re-selectionner le même animal.
        /// </summary>
        private int _indexCorps;

        public int IndexCorps
        {
            get { return _indexCorps; }
            set { _indexCorps = value; }
        }
        #endregion



        #region Constructeur

        /// <summary>
        /// Constructeur de la Class Corps.
        /// </summary>
        /// <param name="tete">Récupère l'objet Tete</param>
        public Corps(Tete tete)
        {
            this.RandomAnimal(tete);
            this.RécupererParticuleNom();
        }

        #endregion



        #region Méthodes

        /// <summary>
        /// Cette Méthode permet de choisir le nom d'un animal par random dans la liste d'animaux de la bibliotheque.
        /// Le random choisi un index du tableau (de 0 à 8).
        /// L'enregistrement de l'index de l'animal choisi pour que la Classe Pattes ne puisse plus re-selectionner le même animal.
        /// </summary>
        /// <param name="tete"></param>
        public void RandomAnimal(Tete tete)
        {
            Bibliotheque liste = new Bibliotheque();
            Random rand = new Random();
            do
            {
                _indexCorps = rand.Next(liste.ListAnimaux.Count);
            } while (_indexCorps == tete.IndexTete);
            _nomAnimal = liste.ListAnimaux[_indexCorps];
        }

        /// <summary>
        /// Cette Méthode permet de récuperer la 2eme Syllabe de l'animal choisi.
        /// </summary>
        /// <returns></returns>
        public string RécupererParticuleNom()
        {
            int[] posVoyelle = Fonctions.AnalyserNom(NomAnimal);
            string syllabe = Fonctions.RecupererSyllabeCorps(NomAnimal, posVoyelle);
            ParticuleNom = syllabe.ToLower();
            return ParticuleNom;
        }

        #endregion
    }

}
