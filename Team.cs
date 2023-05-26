using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    public class Team
    {
        public Coach Coach { get; private set; }
        public FootballPlayer[] Players { get; private set; }
        public double AverageSize { get
            {
                double sum = 0;
                int amount = Players.Length;
                foreach(FootballPlayer player in Players)
                {
                    sum = sum + player.Height;
                }

                return sum / amount;
            } 
        }

        public Team(Coach coach, FootballPlayer[] players)
        {
            if (players.Length < 11 || players.Length > 22)
                throw new ArgumentException("The amount of players must be between 11 and 22!");

            Players = players;
            Coach = coach;
        }
    }
}
