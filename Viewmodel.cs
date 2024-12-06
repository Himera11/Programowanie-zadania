using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin
{
    public class Viewmodel:BindableObject
    {
        private string resultShow;
        public string ResultShow
        {
            get { return resultShow; }
            set { resultShow = value; OnPropertyChanged(); }
        }
        private string resultShowAllGame;
        public string ResultShowAllGame
        {
            get { return resultShowAllGame; }
            set { resultShowAllGame = value; OnPropertyChanged(); }
        }
        private string dice1;

        public string Dice1
        {
            get { return dice1; }
            set { dice1 = value; OnPropertyChanged(); }
        }
        private string dice2;

        public string Dice2
        {
            get { return dice2; }
            set { dice2 = value; OnPropertyChanged(); }
        }
        private string dice3;

        public string Dice3
        {
            get { return dice3; }
            set { dice3 = value; OnPropertyChanged(); }
        }
        private string dice4;

        public string Dice4
        {
            get { return dice4; }
            set { dice4 = value; OnPropertyChanged(); }
        }
        private string dice5;

        public string Dice5
        {
            get { return dice5; }
            set { dice5 = value; OnPropertyChanged(); }
        }
        private Command resetCommand;

        public Command ResetCommand
        {
            get { return resetCommand; }
            set { resetCommand = value; }
        }

        private Command throwCommand;

        public Command ThrowCommand
        {
            get { return throwCommand; }
            set { throwCommand = value; }
        }
        private string[] DiceImages =
        {
            "k1.jpg",
            "k2.jpg",
            "k3.jpg",
            "k4.jpg",
            "k5.jpg",
            "k6.jpg",
        };
        
        public Viewmodel()
        {
            ThrowCommand = new Command(Throw);
            ResetCommand = new Command(Reset);
            Dice1 = "question.jpg";
            Dice2 = "question.jpg";
            Dice3 = "question.jpg";
            Dice4 = "question.jpg";
            Dice5 = "question.jpg";
        }
        int resultAllGame = 0;
        public void Throw()
        {
            Random random = new Random();
            Dice1 = DiceImages[random.Next(0,5)];
            Dice2 = DiceImages[random.Next(0, 5)];
            Dice3 = DiceImages[random.Next(0, 5)];
            Dice4 = DiceImages[random.Next(0, 5)];
            Dice5= DiceImages[random.Next(0, 5)];

            int result = 5;
            result += Array.IndexOf(DiceImages, Dice1);
            result += Array.IndexOf(DiceImages, Dice2);
            result += Array.IndexOf(DiceImages, Dice3);
            result += Array.IndexOf(DiceImages, Dice4);
            result += Array.IndexOf(DiceImages, Dice5);
            resultAllGame = resultAllGame + result;
            ResultShow = $"Wynik tego losowania {result}";
            ResultShowAllGame = $"Wynik całej gry {resultAllGame}";
        }
        public void Reset()
        {
            Dice1 = "question.jpg";
            Dice2 = "question.jpg";
            Dice3 = "question.jpg";
            Dice4 = "question.jpg";
            Dice5 = "question.jpg";
            ResultShow = $"Wynik tego losowania 0";
            resultAllGame = 0;
            ResultShowAllGame = $"Wynik całej gry 0";
        }
    }
}
