using System.Windows.Forms;

namespace DesignPatternObserver_Animorphe
{
    public interface IObservateur
    {

        #region  Methodes

        void Update(ListView lstViewAnimaux);
        void Update(Form1 form1Objet);

        #endregion
    }
}
