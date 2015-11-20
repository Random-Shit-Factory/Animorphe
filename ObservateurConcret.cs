using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesignPatternObserver_Animorphe
{
    class ObservateurConcret : IObservateur
    {

        #region Attributs

        private SujetConcret _maCollectionAnimorphe;

        #endregion


        
        #region Constructeurs

        /// <summary>
        /// Constructeur de l'observer Concret
        /// </summary>
        /// <param name="sujetConcret"></param>
        public ObservateurConcret(SujetConcret sujetConcret)
        {
            _maCollectionAnimorphe = sujetConcret;
        }

        #endregion



        #region Methodes

        /// <summary>
        /// Méthode de mises à jour des données concernée par la ListView "lstViewAnimaux"
        /// </summary>
        /// <param name="lstViewAnimaux"></param>
        public void Update(ListView lstViewAnimaux)
        {
            //Création d'un objet Animorphe temporaire qui copie le dernier Animorphe créé
            Animorphe temp = _maCollectionAnimorphe.MesAnimorphes.Last();

            
            // Création d'une "ligne" du ListView par ajout d'item et subitems dans un ListViewItem (lvi)
            ListViewItem lvi = new ListViewItem(temp.Nom);
            lvi.SubItems.Add(temp.Tete);
            lvi.SubItems.Add(temp.Corps);
            lvi.SubItems.Add(temp.Pattes);

            //Afficher le lvi dans la ListView "lstViewAnimaux"
            lstViewAnimaux.Items.Add(lvi);
        }

        /// <summary>
        /// Méthode de mises à jour des données concernée par les pictureBox de la Form1
        /// </summary>
        /// <param name="form1Objet"></param>
        public void Update(Form1 form1Objet)
        {
            //Création d'un objet Animorphe temporaire qui copie le dernier Animorphe créé
            Animorphe temp = _maCollectionAnimorphe.MesAnimorphes.Last();


            //Pour la Tete
            //Creation d'un objet Tete qui prendra pour image celle mentionée dans la ressource
            Object oT = Properties.Resources.ResourceManager.GetObject(temp.Tete + "Tete");

            //Affectation de l'image avec un cast (Image) à la propriété de form1Objet.PicTete.Image
            form1Objet.PicTete.Image = (Image)oT;

            //changemenent de la propriété form1Objet.PicTete.SizeMode en mode Image Stretch
            form1Objet.PicTete.SizeMode = PictureBoxSizeMode.StretchImage;
            


            //Pour le Corps
            //Creation d'un objet Tete qui prendra pour image celle mentionée dans la ressource
            Object oC = Properties.Resources.ResourceManager.GetObject(temp.Corps + "Corps");
            //Affectation de l'image avec un cast (Image) à la propriété de form1Objet.PicTete.Image
            form1Objet.PicCorps.Image = (Image)oC;
            //changemenent de la propriété form1Objet.PicTete.SizeMode en mode Image Stretch
            form1Objet.PicCorps.SizeMode = PictureBoxSizeMode.StretchImage;



            //Pour le Corps
            //Creation d'un objet Tete qui prendra pour image celle mentionée dans la ressource
            Object oP = Properties.Resources.ResourceManager.GetObject(temp.Pattes + "Pattes");

            //Affectation de l'image avec un cast (Image) à la propriété de form1Objet.PicTete.Image
            form1Objet.PicPattes.Image = (Image)oP;

            //changemenent de la propriété form1Objet.PicTete.SizeMode en mode Image Stretch
            form1Objet.PicPattes.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion
    }
}
