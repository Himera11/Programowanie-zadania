namespace arkusz_inf_04_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string haslo = "";
        string duze_litery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string male_litery = "qwertyuiopasdfghjklzxcvbnm";
        string znaki_specjalne = "!@#$%^&*()_+-=";
        string cyfry = "1234567890";

        Random random = new Random();


        private void genhaslo_button_Click(object sender, EventArgs e)
        {
            haslo = "";
            int ile = Convert.ToInt32(ileznakow_textBox.Text);


            if (litery_checkBox.Checked)
            {
                haslo += duze_litery[random.Next(0, duze_litery.Length)];
            }
            if (cyfry_checkBox.Checked)
            {
                haslo += cyfry[random.Next(0, cyfry.Length)];
            }
            if (znaki_specjalne_checkBox.Checked)
            {
                haslo += znaki_specjalne[random.Next(0, znaki_specjalne.Length)];

            }

            while (haslo.Length < ile)
            {
                haslo += male_litery[random.Next(0, male_litery.Length)];
            }
            MessageBox.Show(haslo);
        }

        private void zatwierdz_button_Click(object sender, EventArgs e)
        {
            string imie = imie_textbox.Text;
            string nazwisko = nazwisko_textbox.Text;
            string stanowisko = stanowisko_comboBox.Text;

            MessageBox.Show("Dane pracownika: " + imie + "" + nazwisko + " " + stanowisko + "" + "Has³o " + haslo);
        }
    }
}