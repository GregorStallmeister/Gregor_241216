namespace Gregor_241216
{
    public partial class Starrtfenster : Form
    {
        public Starrtfenster()
        {
            InitializeComponent();
        }

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length > 0)
            {
                MessageBox.Show("Hallo " + this.textBoxName.Text + "!", "Willkommen!");
                this.Text = "Gregors Programm - im Dienst für " + this.textBoxName.Text;
            }
            else
            {
                MessageBox.Show("Hallo! Bitte sag mir, wer Du bist!", "Willkommen!");
                this.Text = "Gregors Programm";
            }
        }
    }
}
