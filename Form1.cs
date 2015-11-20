using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace DesignPatternObserver_Animorphe
{
    
    public partial class Form1 : Form
    {
        public string AppPath = Application.StartupPath;
        //Instanciation du classe Mediaplayer pour l'alarme
        private WMPLib.WindowsMediaPlayer mplayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer playerTete = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer playerCorps = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer playerPattes = new WMPLib.WindowsMediaPlayer();


        #region Attributs de la Form1

        private SujetConcret monSujet;
        private ObservateurConcret monObservateurLV;

        /// <summary>
        /// Getter & setter pour régler des problèmes d'encapsulation dans l'update().
        /// </summary>
        public PictureBox PicTete
        {
            get { return picTete; }
            set { picTete = value; }
        }

        /// <summary>
        /// Getter & setter pour régler des problèmes d'encapsulation dans l'update().
        /// </summary>
        public PictureBox PicCorps
        {
            get { return picCorps; }
            set { picCorps = value; }
        }

        /// <summary>
        /// Getter & setter pour régler des problèmes d'encapsulation dans l'update().
        /// </summary>
        public PictureBox PicPattes
        {
            get { return picPattes; }
            set { picPattes = value; }
        }

        #endregion



        #region Constructeur

        /// <summary>
        /// Constructeur de la Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //	----------Creation du sujet concret------------
            monSujet = new SujetConcret();
            monObservateurLV = new ObservateurConcret(monSujet);
            monSujet.Attach(monObservateurLV);

        }

        #endregion



        #region Methodes

        #region btn Start / Générér

        /// <summary>
        /// Evenement btn_Start_Click qui permet la génération de l'animorphe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Task maTache = new Task(GenererDesAnimorphes);
            //maTache.Start();

            //Instanciation de la Class Anyorphe
            Animorphe hybride = new Animorphe();

            //Mise en place de l'abonnement à l'observer et du notify()
            monSujet.AjouterAnimorphe(hybride, lstViewAnimaux, this);

            //Affichage les labels dans les groupbox de la form1
            lbl_TeteNom.Text = hybride.Tete;
            lbl_CorpsNom.Text = hybride.Corps;
            lbl_PattesNom.Text = hybride.Pattes;
            lbl_AnimorpheNom.Text = hybride.Nom;
        }
        #endregion


        #region DoubleClick sur une ligne de la listView

        /// <summary>
        /// Cet Evenement MouseDoubleClick permet, lorsque l'on selectionne par DoubleCick d'une ligne dans la listview "lstViewAnimaux",
        /// d'afficher dans les pictureBox les images de l'animorphe en question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstViewAnimaux_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //recherche de l'item selectionné dans la ListView dans List<Animorphe>
            int indexSelected = monSujet.MesAnimorphes.FindIndex(x => x.Nom == lstViewAnimaux.SelectedItems[0].SubItems[0].Text);
            Animorphe SeletedAnimal = monSujet.MesAnimorphes[indexSelected];

            //réaffectation des textes des Labels de la form1
            lbl_AnimorpheNom.Text = SeletedAnimal.Nom;
            lbl_TeteNom.Text = SeletedAnimal.Tete;
            lbl_CorpsNom.Text = SeletedAnimal.Corps;
            lbl_PattesNom.Text = SeletedAnimal.Pattes;

            //Affectation des images dans les pictureBox et stretching des images
            Object oT = Properties.Resources.ResourceManager.GetObject(SeletedAnimal.Tete + "Tete");
            picTete.Image = (Image)oT;
            picTete.SizeMode = PictureBoxSizeMode.StretchImage;
            Object oC = Properties.Resources.ResourceManager.GetObject(SeletedAnimal.Corps + "Corps");
            picCorps.Image = (Image)oC;
            picCorps.SizeMode = PictureBoxSizeMode.StretchImage;
            Object oP = Properties.Resources.ResourceManager.GetObject(SeletedAnimal.Pattes + "Pattes");
            picPattes.Image = (Image)oP;
            picPattes.SizeMode = PictureBoxSizeMode.StretchImage;


            //Activation du son
            if (chkBox_SonActivation.Checked == true)
            {

                chkBox_Son.Enabled = true;
                //Selection du Mode Sonore

                //Son Synchrone /Simultané
                if (chkBox_Son.Checked == true)
                {
                    chkBox_Son.Text = @"Mode Sonore : Synchrone";
                    playerTete.URL = AppPath +"\\Sons\\"+ SeletedAnimal.Tete + "Tete.mp3";
                    playerTete.controls.play();
                    //Thread.Sleep(500);
                    playerCorps.URL = AppPath +"\\Sons\\"+ SeletedAnimal.Corps + "Corps.mp3";
                    playerCorps.controls.play();
                    //Thread.Sleep(500);
                    playerPattes.URL = AppPath + "\\Sons\\" + SeletedAnimal.Pattes + "Pattes.mp3";
                    playerPattes.controls.play();
                }

                //Son Séquencé en playlist
                else
                {
                    chkBox_Son.Text = @"Mode Sonore : Séquencé";
                    WMPLib.IWMPPlaylist playlist = mplayer.playlistCollection.newPlaylist("myplaylist");
                    WMPLib.IWMPMedia media;
                    media = mplayer.newMedia(AppPath + "\\Sons\\" + SeletedAnimal.Tete + "Tete.mp3");
                    playlist.appendItem(media);
                    media = mplayer.newMedia(AppPath + "\\Sons\\" + SeletedAnimal.Corps + "Corps.mp3");
                    playlist.appendItem(media);
                    media = mplayer.newMedia(AppPath + "\\Sons\\" + SeletedAnimal.Pattes + "Pattes.mp3");
                    playlist.appendItem(media);
                    mplayer.currentPlaylist = playlist;
                    mplayer.controls.play();
                }
            }

        }

        #endregion


        #region btn Attach & Detach

        /// <summary>
        /// Attacher un observer au sujet observé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Attach_Click(object sender, EventArgs e)
        {
            monSujet.Attach(monObservateurLV);


            //Mise à jour complète de la liste des animorphes créés et ajouter dans la liste
            lstViewAnimaux.Items.Clear();
            foreach (var item in monSujet.MesAnimorphes)
            {
                int indexAnimorphe = monSujet.MesAnimorphes.IndexOf(item);


                //Animorphe temp = monSujet.MesAnimorphes[indexAnimorphe];

                ListViewItem lvi = new ListViewItem(monSujet.MesAnimorphes[indexAnimorphe].Nom);
                lvi.SubItems.Add(monSujet.MesAnimorphes[indexAnimorphe].Tete);
                lvi.SubItems.Add(monSujet.MesAnimorphes[indexAnimorphe].Corps);
                lvi.SubItems.Add(monSujet.MesAnimorphes[indexAnimorphe].Pattes);

                //Afficher le lvi dans la ListView "lstViewAnimaux"
                lstViewAnimaux.Items.Add(lvi);
            }
            btn_Attach.Enabled = false;
            btn_Detach.Enabled = true;
            MessageBox.Show("Votre Abonnent a bien été renouvelé. Félicitations !\nLa mise à jour s'est bien déroulée", "Avertissement sur Abonnement");
        }

        /// <summary>
        /// Detacher un observateur di sujet observé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Detach_Click(object sender, EventArgs e)
        {
            monSujet.Detach(monObservateurLV);
            btn_Attach.Enabled = true;
            btn_Detach.Enabled = false;
            MessageBox.Show("Votre Abonnent a bien été résilié. Dommage !\nAu revoir !!!", "Avertissement sur Abonnement");

        }

        #endregion


        #region Checked Box status event

        /// <summary>
        /// Evenment de modification de la checked box Mode Son
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBx_Son_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Son.Checked)
            {
                chkBox_Son.Text = @"Mode Sonore : Synchrone";
            }
            else
            {
                chkBox_Son.Text = @"Mode Sonore : Séquencé";
            }
        }

        /// <summary>
        /// Evenment de modification de la checked box Activation Son
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBox_SonActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_SonActivation.Checked)
            {
                chkBox_Son.Enabled = true;
            }
            else
            {
                chkBox_Son.Enabled = false;
            }
        }

        #endregion



        //loop -> net used anymore
        //private void GenererDesAnimorphes()
        //{
        //    do
        //    {
        //        Animorphe hybride = new Animorphe();
        //        monSujet.AjouterAnimorphe(hybride, lstViewAnimaux, this);

        //        //Affichage les labels dans les groupbox de la form1
        //        lbl_TeteNom.Text = hybride.Tete;
        //        lbl_CorpsNom.Text = hybride.Corps;
        //        lbl_PattesNom.Text = hybride.Pattes;
        //        lbl_AnimorpheNom.Text = hybride.Nom;
        //        Thread.Sleep(2000);
        //    } while (true);
        //}

        #endregion
    }
}
