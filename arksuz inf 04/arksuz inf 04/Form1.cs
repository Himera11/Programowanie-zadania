using System.Reflection.Emit;

namespace arksuz_inf_04
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_zatwierdz_Click(object sender, EventArgs e)
        {
            string email = textBox_mail.Text;
            if (textBox_mail.Text.Contains('@') && (textbox_haslo.Text == textBox_haslo_powtórka.Text))
            {
                label_wynik.Text = "Witaj " + email;
            }
            else if (!(textBox_mail.Text.Contains('@')))
            {
                label_wynik.Text = "Nieprawid³owy adres email";
            }
            else if (!(textbox_haslo.Text == textBox_haslo_powtórka.Text))
            {
                label_wynik.Text = "has³a siê ró¿ni¹";
            }

        }
    }
}