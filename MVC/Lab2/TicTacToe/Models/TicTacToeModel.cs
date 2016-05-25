using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class TicTacToeModel
    {
        public int[] Board { get; set; } = new int[10];
        public string Output { get; set; }
        public char Player { get; set; } = 'X';
        public char Comp { get; set; } = 'O';
        public int Moves { get; set; } = 9;
        //public bool IsGameOver { get; set; } = false;
        public List<int> Options { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public List<int> Disable { get; set; } = new List<int>();
        //public bool IsGameOn { get; set; } = true;

        
        public void Human(int choice)
        {
            Board[choice] = Player;
            Options.Remove(choice);
            Disable.Add(choice);
            Moves--;
            Computer();
            Winner(Player);       
        }

        public void Computer()
        {
            if (Moves != 0)
            {
                Random random = new Random();
                var computerChoice = Options[random.Next(Options.Count)];
                Options.Remove(computerChoice);
                Disable.Add(computerChoice);
                Board[computerChoice] = Comp;
                Moves--;
                Winner(Comp);
            }
            else
            {
                Tie();
            }
        }
        public string DisableBtn(int i)
        {
            if(Disable.Count !=0)
            {
                foreach (var nr in Disable)
                {
                    if (i==nr)
                    {
                        return "Disabled";
                    }
                }
            }
            return "";
        }
        //public void GameIsOver()
        //{
        //    IsGameOver = true;
           
        //}
        public void Winner(Char user)
        {
            if(Board[1] == user && Board[2] ==user && Board[3]==user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[4] == user && Board[5] == user && Board[6] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[7] == user && Board[8] == user && Board[9] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[1] == user && Board[4] == user && Board[7] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[2] == user && Board[5] == user && Board[8] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[3] == user && Board[6] == user && Board[9] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[1] == user && Board[5] == user && Board[9] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
            if (Board[3] == user && Board[5] == user && Board[7] == user)
            {
                Output = user + " is the WINNER";
                //GameIsOver();
            }
        }
        public void Tie()
        {
            if(Options.Count == 0)
            {
                Output = " It's a Tie";
            }
           
        }
       
    }
    
}