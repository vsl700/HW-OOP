using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    public class GameResult
    {
        public int Team1Score { get; private set; }
        public int Team2Score { get; private set; }

        public void IncrementTeam1Score()
        {
            Team1Score++;
        }

        public void IncrementTeam2Score()
        {
            Team2Score++;
        }
    }
}
