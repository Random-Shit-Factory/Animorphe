using System;

namespace DesignPatternObserver_Animorphe
{
    class Tete
    {
        
        #region Attributs

        /// <summary>
        /// Affectation du Nom de l'Animal choisi par le random dans la liste de la bibliothèque.
        /// </summary>
        public string NomAnimal { get; set; }


        /// <summary>
        /// Attribution du nom de l'animal, choisi par random dans la liste de la bibliotheque, qui constituera la Tête de l'animal.
        /// </summary>
        public string ParticuleNom { get; set; }


        
        /// <summary>
        /// Récuperation du numéro de l'index de l'animal choisi par le random dans la liste de la bibliothèque.
        /// L'enregistrement de cet index permettra aux 2 autres randoms des Class Corps et Pattes afin d'eviter
        /// de re-selectionner le même animal.
        /// </summary>
        public int IndexTete { get; set; }

        #endregion



        #region Constructor

        /// <summary>
        /// Constructeur de la Class Tete.
        /// </summary>
        public Tete()
        {
            IndexTete = 0;
            RandomAnimal();
            RécupererParticuleNom();
        }

        #endregion



        #region Methodes

        /// <summary>
        /// Cette Méthode permet de choisir le nom d'un animal par random dans la liste d'animaux de la bibliotheque.
        /// Le random choisi un index du tableau (de 0 à 8).
        /// L'enregistrement de l'index de l'animal choisi pour que les 2 autres Classes Corps et Pattes 
        /// ne puissent plus re-selectionner le même animal.
        /// </summary>
        public void RandomAnimal()
        {
            Bibliotheque liste = new Bibliotheque();
            Random rand = new Random();

            IndexTete = rand.Next(liste.ListAnimaux.Count);
            NomAnimal = liste.ListAnimaux[IndexTete];
        }
        
        /// <summary>
        /// Cette Méthode permet de récuperer la 1ère Syllabe de l'animal choisi.
        /// </summary>
        /// <returns></returns>
        public string RécupererParticuleNom()
        {
            int[] posVoyelle = Fonctions.AnalyserNom(NomAnimal);
            string syllabe = Fonctions.RecupererSyllabeTete(NomAnimal, posVoyelle);
            ParticuleNom = syllabe;
            return ParticuleNom;
        }

        #endregion
    }
}