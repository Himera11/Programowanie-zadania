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
        private string[] diceImages =
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
            ThrowCommand = new Command(ThrowDice);
            ResetCommand = new Command(ResetGame);
            ResetCommand.Execute(this);
            //ResetGame();
            /*
            Dice1 = "question.jpg";
            Dice2 = "question.jpg";
            Dice3 = "question.jpg";
            Dice4 = "question.jpg";
            Dice5 = "question.jpg";*/
        }
        int resultAllGame = 0;
        public void ThrowDice()
        {
            Random random = new Random();

            int [] diceValues = new int[5]
            {
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7)
            };

            Dice1 = diceImages[diceValues[0] - 1];
            Dice2 = diceImages[diceValues[1] - 1];
            Dice3 = diceImages[diceValues[2] - 1];
            Dice4 = diceImages[diceValues[3] - 1];
            Dice5 = diceImages[diceValues[4] - 1];  

            var duplicates = diceValues.GroupBy(x => x).Where(g => g.Count() > 1).SelectMany(g =>g);
            int total = duplicates.Sum();

            resultAllGame = resultAllGame + total;
            ResultShow = $"Wynik tego losowania {total}";
            ResultShowAllGame = $"Wynik całej gry {resultAllGame}";
            /*
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
            */
        }
        public void ResetGame()
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
