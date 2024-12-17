using System.Data;
using Project = Interfaces;

namespace DatenAnbindungEinfach
{
    public class Datenanbindung : Interfaces.InterfaceDatenanbindung
    {
        private DataSet DataSetTexte;

        public Datenanbindung()
        {
            DataSetTexte = new DataSet();
        }
        public void HoleTexte()
        {
            throw new NotImplementedException();
        }
    }
}
