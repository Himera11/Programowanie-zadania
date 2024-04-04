namespace arkusz_inf_04_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        string duzelitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string malelitery = "qwertyuiopasdfghjklzxcvbnm";
        string znakispecjalne = "!@#$%^&*()-_=+";
        string liczby = "0123456789";
        string haslo = "";

        
        string RobHaslo(int dlugosc)
        {
            string _haslo = "";
            while (_haslo. Length < dlugosc)
            {
                if (checkBox1.Checked)
            {
                _haslo + duze [los.Next(0, duze.Length)];
            }        
            if(_haslo.Length == dlugosc) return _haslo;
            if (checkBox2.Checked)
            {
             _haslo += cyfry [los.Next(0, cyfry.Length)];
            if (_haslo.Length == dlugosc) return _haslo;
            }
            if (checkBox3.Checked)
            {
                        _haslo += specjalne [los.Next(0, specjalne.Length)];

            }
        if (_haslo.Length == dlugosc) return _haslo;
    }
return _haslo;
}
        
        private void genhaslo_button_Click(object sender, EventArgs e)
        {

        }
    }
}
