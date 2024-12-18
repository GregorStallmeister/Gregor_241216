using System.Data;
using Project = DatenAnbindungEinfach;

namespace Gregor_241216
{
    public partial class Startfenster : Form
    {
        private const string TitelTextStandard = "Gregors Programm";
        private readonly DatenAnbindungEinfach.Datenanbindung? Datenanbindung = null;
        private DataRow? DataRowAktuell = null;

        public Startfenster()
        {
            InitializeComponent();

            Datenanbindung = new DatenAnbindungEinfach.Datenanbindung();

            try
            {
                Datenanbindung.HoleTexte();

                // DataRowAktuell = Datenanbindung.GibN�chsteZeile(false);
                // textBoxZitat.Text = dataRow["Text"].ToString();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.ToString());
                // DataRowAktuell = null;
                textBoxZitat.Text = "Leider konnte kein Zitat geladen werden.";
            }
        }

        private void ButtonKlickMich_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length > 0)
            {
                MessageBox.Show("Hallo " + this.textBoxName.Text + "!", "Willkommen!");
                this.Text = TitelTextStandard + " - im Dienst f�r " + this.textBoxName.Text;
                this.textBoxName.Text = "";
            }
            else
            {
                MessageBox.Show("Hallo! Bitte sag mir, wer Du bist!", "Willkommen!");
                this.Text = TitelTextStandard;
                DataRowAktuell = null;
                textBoxZitat.Text = "";
                checkBoxZuf�llig.Checked = false;
            }
        }

        private void buttonN�chsterText_Click(object sender, EventArgs e)
        {
            if (!this.Text.Equals(TitelTextStandard))
            {
                try
                {
                    if (Datenanbindung != null)
                    {
                        DataRowAktuell = Datenanbindung.GibN�chsteZeile(checkBoxZuf�llig.Checked);
                        textBoxZitat.Text = DataRowAktuell["Text"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Es konnte kein Text geladen werden.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Es konnte kein Text geladen werden.");
                }
            }
            else
            {
                MessageBox.Show("Bitte sag mir erst, wer Du bist. Danke!");
            }
        }

        private void buttonQuelle_Click(object sender, EventArgs e)
        {
            if (DataRowAktuell != null)
            {
                MessageBox.Show(DataRowAktuell["Quelle"].ToString(), "Quelle");
            }
            else
            {
                MessageBox.Show("Bitte lade zun�chst einen Text. Danke!");
            }
        }
    }
}
