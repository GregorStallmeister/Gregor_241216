using Project = DatenAnbindungEinfach;

namespace Gregor_241216
{
    public partial class Startfenster : Form
    {
        private DatenAnbindungEinfach.Datenanbindung Datenanbindung;

        public Startfenster()
        {
            InitializeComponent();

            this.Datenanbindung = new DatenAnbindungEinfach.Datenanbindung();

            // this.Datenanbindung.HoleTexte();
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
