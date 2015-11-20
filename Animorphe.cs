
namespace DesignPatternObserver_Animorphe
{
    class Animorphe
    {

        #region Attributs
        
        /// <summary>
        /// Nom complet de l'Animorphe
        /// </summary>
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        
        /// <summary>
        /// Nom de l'animal qui compose la Tete de l'animorphe
        /// </summary>
        private string _tete;
        public string Tete
        {
            get { return _tete; }
            set { _tete = value; }
        }

        /// <summary>
        /// 1ère Syllabe issue de l'animal qui compose la Tête
        /// </summary>
        private string _syllabeNomTete;

        public string SyllabeNomTete
        {
            get { return _syllabeNomTete; }
            set { _syllabeNomTete = value; }
        }
        
        /// <summary>
        /// Nom de l'animal qui compose la Corps de l'animorphe
        /// </summary>
        private string _corps;

        public string Corps
        {
            get { return _corps; }
            set { _corps = value; }
        }

        /// <summary>
        /// 2eme Syllabe issue de l'animal qui compose le Corps
        /// </summary>
        private string _syllabeNomCorps;

        public string SyllabeNomCorps
        {
            get { return _syllabeNomCorps; }
            set { _syllabeNomCorps = value; }
        }
        
        /// <summary>
        /// Nom de l'animal qui compose les Pattes de l'animorphe
        /// </summary>
        private string _pattes;

        public string Pattes
        {
            get { return _pattes; }
            set { _pattes = value; }
        }

        /// <summary>
        /// 3eme Syllabe issue de l'animal qui compose les Pattes
        /// </summary>
        private string _syllabeNomPattes;

        public string SyllabeNomPattes
        {
            get { return _syllabeNomPattes; }
            set { _syllabeNomPattes = value; }
        }

        #endregion



        #region Constructeur
        /// <summary>
        /// Constructeur de l'Animorphe
        /// </summary>
        public Animorphe()
        {

            Tete teteChoisie = new Tete();
            Corps corpsChoisi = new Corps(teteChoisie);
            Pattes pattesChoisies = new Pattes(teteChoisie, corpsChoisi);


            this.Tete = teteChoisie.NomAnimal;
            this.SyllabeNomTete = teteChoisie.ParticuleNom;

            this.Corps = corpsChoisi.NomAnimal;
            this.SyllabeNomCorps = corpsChoisi.ParticuleNom;

            this.Pattes = pattesChoisies.NomAnimal;
            this.SyllabeNomPattes = pattesChoisies.ParticuleNom;

            this.Nom = this.SyllabeNomTete + this.SyllabeNomCorps + this.SyllabeNomPattes;
        }
        #endregion
    }
}
