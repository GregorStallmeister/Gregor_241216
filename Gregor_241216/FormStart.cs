using Project = DatenAnbindungEinfach;

namespace Gregor_241216
{
    public partial class Startfenster : Form
    {
        private DatenAnbindungEinfach.Datenanbindung Datenanbindung;

        public Startfenster()
        {
            InitializeComponent();

            Datenanbindung = new DatenAnbindungEinfach.Datenanbindung();

            try
            {
                Datenanbindung.HoleTexte();
            }
            catch (Exception ex)
            {
               _ = MessageBox.Show(ex.ToString());
                textBoxZitat.Text = "Leider konnte kein Zitat geladen werden.";
            }            
        }

        private void ButtonKlickMich_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length > 0)
            {
                MessageBox.Show("Hallo " + this.textBoxName.Text + "!", "Willkommen!");
                this.Text = "Gregors Programm - im Dienst für " + this.textBoxName.Text;
                this.textBoxName.Text = "";
            }
            else
            {
                MessageBox.Show("Hallo! Bitte sag mir, wer Du bist!", "Willkommen!");
                this.Text = "Gregors Programm";
            }
        }
    }
}
