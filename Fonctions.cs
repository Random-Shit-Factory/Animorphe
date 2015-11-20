using System;

namespace DesignPatternObserver_Animorphe
{
    public class Fonctions
    {

        #region Fonction d'analyse du nom de l'animal choisi

        /// <summary>
        /// La Fonction AnalyserNom analyse le nom d'un animal choisi (par une fonction Random d'une des classes Tete,
        /// Corps ou Pattes) dans la class bibliotheque.
        /// Le nom de l'animal choisi  est passé en argument d'entrée à la fonction AnalyserNom.
        /// 
        /// L'objectif de cette fonction est de compter et "extraire" la position (index) de toutes les
        /// voyelles dans le Nom Animal pour les mettre dans un tableau "posVoyelle".
        /// 
        /// Le tableau temporaire "posVoelle" comportera toutes les voyelles du nom de l'animal.
        /// Le tableau de sortie "newPosVoyelle" sera redimensionné et comportera uniquement les 
        /// 1eres lettres contenues dans les syllabes du nom (en 3 syllabes) de l'animal.
        /// </summary>
        /// <param name="nomAnimal"></param>
        /// <returns>Tableau d'entier avec la position des voyelles significatives des syllabes</returns>
        public static int[] AnalyserNom(string nomAnimal)
        {
            //Tableau de voyelles qui servira pour comparer les lettres dans le Nom de l'animal
            char[] tabVoyelle = new char[] { 'a', 'e', 'é', 'i', 'o', 'u', 'y' };
            string nomTemp = nomAnimal.ToLower();
            //Tableau pour y placer la position ou index des voyelles trouvées
            int[] posVoyelle = new int[nomTemp.Length];
            //index de la lettre parcourue dans le nomTemp
            int indexLettre = 0;
            //Compteur de voyelles
            int i = 0;
            //recherche et comparaison des lettres pour trouver les voyelles
            foreach (var lettre in nomTemp)
            {
                //Parcours caractère par caractère du tableau de la liste de voyelles
                foreach (var item in tabVoyelle)
                {
                    //Comparaison si lettre est une voyelle
                    if (lettre == item)
                    {
                        //mettre la position de l'index de la voyelle dans un tab[]
                        posVoyelle[i] = indexLettre;
                        //incrément pour compter les voyelles            
                        i++;
                    }
                }
                //Incrément de l'Index de la lettre parcourue dans le nom de l'aninmal
                indexLettre++;
            }
            //Redimension du tableau avec toutes les voyelles (même consécutives comme dans maquereau)
            Array.Resize(ref posVoyelle, i);
            //suppression des lettres consécutives dans le nom -> mettre que la 1ere lettre significative (la premier lettre) de la syllabe dans le tableau
            int k = 0;
            string testTab = String.Empty;
            int[] newPosVoyelle = new int[posVoyelle.Length];
            for (int j = 0; j < posVoyelle.Length; j++)
            {
                /*condition qui donne les lettres consécutives et le else donne
                 *les premieres voyelles d'une suite de voyelles 
                 *(ex maquereau -> la condition donne [4]e,[7]a,[8]u et le else donne [1]a,[3]u,[6]e*/

                if (j > 0 && j < posVoyelle.Length && posVoyelle[j] - posVoyelle[j - 1] == 1)
                {
                    //une condition de valeurs consécutives non souhaitées pour générer le contraire dans le else
                }
                else
                {
                    newPosVoyelle[k] = posVoyelle[j];
                    k++;
                }
            }
            //redimension du tableau sans les voyelles consécutives
            Array.Resize(ref newPosVoyelle, k);
            return newPosVoyelle;
        }

        #endregion



        #region Fonctions d'Extraction des syllables

        /* AVERTISSEMENT !!!
         A PARTIR DE CET ENDROIT:
         CELUI QUI N'EST PAS DANS MA TETE, NE PEUT COMPRENDRE.
         CELUI QUI EST DANS MA TETE, ET BEN, IL SORT DE LA TOUT DE SUITE !!!*/


        /// <summary>
        /// Cette Fonction récupère la 1ère syllabe du Nom de l'Animal en se basant sur la première 
        /// voyelle indexé (via "newPosVoyelle[0]") dans le tableau de 3 voyelles significatives 
        /// des 3 syllabes du nom Animal traitées précédemment par la Fonction d'AnalyseNom.
        /// 
        /// </summary>
        /// <param name="nomAnimal"> Nom de l'animal choisi par le random </param>
        /// <param name="newPosVoyelle">Tableau de voyelles significatives</param>
        /// <returns> 1ere Syllabe </returns>
        public static string RecupererSyllabeTete(string nomAnimal, int[] newPosVoyelle)
        {
            string syllabe = String.Empty;
            switch (newPosVoyelle[1] - newPosVoyelle[0])
            {
                //
                case 1://Si ecart de 1...2 voyelles consecutives...
                    for (var i = 0; i <= newPosVoyelle[0] + 1; i++)//...prendre la voyelle placée en [n+1] après posVoyelle[n]
                    {
                        syllabe += nomAnimal[i];
                    }
                    break;
                //
                case 2://Si ecart de 2 (donc un consonne séparative)...
                    for (var i = 0; i <= newPosVoyelle[0]; i++)//...arrêter à posVoyelle[n]
                    {
                        syllabe += nomAnimal[i];
                    }
                    break;
                //
                case 3://si ecart de 3 (dc entre 2 consonnes) ...(mettre une condition pour "ph" ou "ch")...
                    for (var i = 0; i <= newPosVoyelle[0] + 1; i++)//...prendre la consonne placé en [n+1] après posVoyelle[n]
                    {
                        if (nomAnimal[i + 1] == 'p' && nomAnimal[i + 2] == 'h' || nomAnimal[i + 1] == 'c' && nomAnimal[i + 2] == 'h')
                        {
                            syllabe += nomAnimal[i];
                            break;//break pour éviter la double incrementation du type "éé" au lieu de 'é' de éléphant
                        }
                        else syllabe += nomAnimal[i];
                    }
                    break;
            }
            return syllabe;
        }

        /// <summary>
        /// Cette Fonction récupère la 2ème syllabe du Nom de l'Animal ; en se basant sur la seconde 
        /// voyelle indexé (via "newPosVoyelle[1]") dans le tableau "newPosVoyelle" de 3 voyelles 
        /// significatives des 3 syllabes du nom Animal traitées précédemment par la Fonction d'AnalyseNom.
        /// 
        /// </summary>
        /// <param name="nomAnimal"> Nom de l'animal choisi par le random </param>
        /// <param name="newPosVoyelle">Tableau de voyelles significatives</param>
        /// <returns> 2eme Syllabe </returns>
        public static string RecupererSyllabeCorps(string nomAnimal, int[] newPosVoyelle)
        {
            string syllabe = String.Empty;
            switch (newPosVoyelle[1] - newPosVoyelle[0])
            {
                //
                case 3:
                    //perroquet et albatros
                    if (nomAnimal[newPosVoyelle[1] - 2] == 'c' && nomAnimal[newPosVoyelle[1] - 1] == 'h')
                    {
                        for (var i = newPosVoyelle[0] + 1; i <= newPosVoyelle[1]; i++)
                        {
                            syllabe += nomAnimal[i];
                        }
                    }
                    else
                    {
                        for (var i = newPosVoyelle[0] + 2; i <= newPosVoyelle[1]; i++)
                        {
                            syllabe += nomAnimal[i];
                        }
                    }
                    break;
                //
                case 2:
                    //maquereau lamantin ok
                    if (nomAnimal[newPosVoyelle[1]] == 'u' || nomAnimal[newPosVoyelle[1] + 1] == 'n')
                    {
                        //pour gerer "que"
                        for (var i = newPosVoyelle[0] + 1; i <= newPosVoyelle[1] + 1; i++)
                        {
                            syllabe += nomAnimal[i];
                        }
                    }
                    else
                        for (var i = newPosVoyelle[0] + 1; i <= newPosVoyelle[1]; i++)
                        {
                            syllabe += nomAnimal[i];
                        }
                    break;
                //
                default:
                    //Fonction marchant pour cachalot colibri dromadaire éléphant girafe
                    for (var i = newPosVoyelle[0] + 1; i <= newPosVoyelle[1]; i++)
                    {
                        syllabe += nomAnimal[i];
                    }
                    break;
            }
            return syllabe;
        }

        /// <summary>
        /// Cette Fonction récupère la 3ème (et dernière) syllabe du Nom de l'Animal ; en se basant
        /// sur la troisième voyelle indexé (via "newPosVoyelle[2]") dans le tableau "newPosVoyelle"
        /// de 3 voyelles significatives 
        /// des 3 syllabes du nom Animal traitées précédemment par la Fonction d'AnalyseNom.
        /// 
        /// </summary>
        /// <param name="nomAnimal"> Nom de l'animal choisi par le random </param>
        /// <param name="newPosVoyelle">Tableau de voyelles significatives</param>
        /// <returns> 1ere Syllabe </returns>
        public static string RecupererSyllabePattes(string nomAnimal, int[] newPosVoyelle)
        {
            string syllabe = String.Empty;
            switch (newPosVoyelle[2] - newPosVoyelle[1])
            {
                case 3:
                    if (nomAnimal[newPosVoyelle[2] - 2] == 'n')
                    {
                        //...prendre la voyelle placée en [n-1] après posVoyelle[n]
                        for (int i = newPosVoyelle[2] - 1; i < nomAnimal.Length; i++)
                        {
                            syllabe += nomAnimal[i];
                        }
                    }
                    else
                    {
                        // gestion de 'ph' 
                        //il faut verifier aussi si newPosVoyelle[2] - 2 n'est pas une voyelle sinon autre condition
                        //Tableau de voyelle qui servira pour comparer avec les lettres du Nom
                        char[] tabVoyelle = new char[] { 'a', 'e', 'é', 'i', 'o', 'u', 'y' };
                        bool isVoyelle = false;
                        //Parcours caractères par caractère du tableau de voyelles
                        foreach (var item in tabVoyelle)
                        {
                            //Comparaison si lettre est une voyelle
                            if (nomAnimal[newPosVoyelle[2] - 2] == item)
                            {
                                //incrément si voyelle
                                isVoyelle = true;
                            }
                        }

                        switch (isVoyelle)
                        {
                            //si n-2 eme lettre à partir de la voyelle-syllabe est un p comme avec "phant" de l'elephant
                            case false:
                                //...prendre la voyelle placée en [n-2] après posVoyelle[n] pour les syllabes en 'ph'
                                for (int i = newPosVoyelle[2] - 2; i < nomAnimal.Length; i++)
                                {
                                    syllabe += nomAnimal[i];
                                }
                                break;
                            //si n-2 eme lettre  à partir de la voyelle-syllabe est une voyelle comme le "ereau" de manquereau
                            case true:
                                //...prendre la voyelle placée en [n-2] après posVoyelle[n] pour les syllabes en 'ph'
                                for (int i = newPosVoyelle[2] - 1; i < nomAnimal.Length; i++)
                                {
                                    syllabe += nomAnimal[i];
                                }
                                break;
                        }
                    }
                    break;
                //
                default:
                    //...prendre la voyelle placée en [n-1] dans nomTemp après posVoyelle[n]
                    for (int i = newPosVoyelle[2] - 1; i < nomAnimal.Length; i++)
                    {
                        syllabe += nomAnimal[i];
                    }
                    break;
            }
            return syllabe;
        }

        #endregion
    }
}
