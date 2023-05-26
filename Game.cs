using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    public class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public Referee AssistantReferee1 { get; private set; }
        public Referee AssistantReferee2 { get; private set; }

        private List<Goal> goals;
        public GameResult GameResult { get; private set; }
        public Team Winner { get; private set; }

        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee1, Referee assistantReferee2)
        {
            if (team1.Players.Length > 11)
                throw new ArgumentException($"Only 11 players are allowed, you passed {team1.Players.Length} players for Team 1!");

            if (team2.Players.Length > 11)
                throw new ArgumentException($"Only 11 players are allowed, you passed {team2.Players.Length} players for Team 2!");

            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;

            goals = new List<Goal>();
            GameResult = new GameResult();
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public Goal[] GetGoals()
        {
            return goals.ToArray();
        }

        public void SetTeam1Winner()
        {
            Winner = Team1;
        }

        public void SetTeam2Winner()
        {
            Winner = Team2;
        }
    }
}
