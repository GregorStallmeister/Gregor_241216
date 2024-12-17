using System.Data;
using System.Text.RegularExpressions;
using Project = Interfaces;

namespace DatenAnbindungEinfach
{
    public class Datenanbindung : Interfaces.InterfaceDatenanbindung
    {
        private DataTable DataTableTexte;
        private int textePosition;

        public Datenanbindung()
        {
            DataTableTexte = new DataTable();
            DataTableTexte.Columns.Add("Text");
            DataTableTexte.Columns.Add("Quelle");

            textePosition = 0;
        }
        public void HoleTexte()
        {
            string stringAlleTexteAmStrück;
            MatchCollection matchCollectionAlleTexte;

            
            stringAlleTexteAmStrück = File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + "Texte.html");
            matchCollectionAlleTexte = Regex.Matches(stringAlleTexteAmStrück, "<td>.+</td>");

            for (int i = 0; i < matchCollectionAlleTexte.Count / 2; i++)
            {
                DataRow dataRow;
                dataRow = DataTableTexte.NewRow();

                dataRow["Text"] = matchCollectionAlleTexte[i*2].ToString().Replace("<td>", "").Replace("</td>", "");
                dataRow["Quelle"] = matchCollectionAlleTexte[(i*2)+1].ToString().Replace("<td>", "").Replace("</td>", "");

                DataTableTexte.Rows.Add(dataRow);
            }
        }
    }
}
