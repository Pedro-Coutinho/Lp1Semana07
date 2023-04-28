using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames, wonGames;

        public float HighScore
        {
            get => highScore;
            set
            {
                if(value > highScore)
                    highScore = value;
            }
        }

        public string Name{get;}
        public float WinRate
        {
            get
            {
                if(playedGames<1) return 0;
                else return (float)wonGames/(float)playedGames;
            }
        }

        public Player(string name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }

        public void PlayGame(bool win)
        {
            playedGames++;

            if(win) wonGames++;
        }
    }
}