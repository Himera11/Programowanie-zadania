namespace arkusz_inf_04_2023
{
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string haslo = "";
        string duzelitery = "QWERTYUIOPASDFGHJKLZXCwVBNM";
        string malelitery = "qwertyuiopasdfghjklzxcvbnm";
        string znakispecjalne = "!@#$%^&*()_+-=";
        string cyfry = "1234567890";

        Random random = new Random();

        int ile = Convert.ToInt32() 

        private void genhaslo_button_Click(object sender, EventArgs e)
        {
            while (haslo < ile)
            {
                if (litery_checkBox.Checked)
                {
                    haslo += duzelitery[random.Next(0, duzelitery.Length)];
                }
                if (cyfry_checkBox.Checked)
                {
                    haslo += cyfry[random.Next(0, cyfry.Length)];
                }
                if (znaki_specjalne_checkBox.Checked)
                {
                    haslo += znakispecjalne[random.Next(0, znakispecjalne.Length)];
                }
                haslo += malelitery[random.Next(0, malelitery.Length)];
            }
        }
    }
}