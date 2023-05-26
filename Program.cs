using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer[] team1Players = {
                new Goalkeeper("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185)
            };

            FootballPlayer[] team2Players = {
                new Goalkeeper("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Defender("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Midfield("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185),
                new Striker("Pen4o", 23, 46, 185)
            };

            Coach coach1 = new Coach("Gan4o", 58);
            Coach coach2 = new Coach("Gan4o", 58);

            Team team1 = new Team(coach1, team1Players);
            Team team2 = new Team(coach2, team2Players);

            Referee referee = new Referee("Go6o", 40);
            Referee assistantReferee1 = new Referee("Go6o", 40);
            Referee assistantReferee2 = new Referee("Go6o", 40);

            Game game = new Game(team1, team2, referee, assistantReferee1, assistantReferee2);
            game.AddGoal(new Goal(40, team1Players[3]));
            game.GameResult.IncrementTeam1Score();
            game.AddGoal(new Goal(63, team2Players[1]));
            game.GameResult.IncrementTeam2Score();
            game.AddGoal(new Goal(65, team2Players[1]));
            game.GameResult.IncrementTeam2Score();
            foreach (Goal goal in game.GetGoals())
            {
                Console.WriteLine($"Goal scored in the {goal.Minute} by {goal.Player.Name}!");
            }
            game.SetTeam1Winner();

            Console.WriteLine($"Game result: {game.GameResult.Team1Score}-{game.GameResult.Team2Score}");

            Console.ReadKey();
        }
    }
}
