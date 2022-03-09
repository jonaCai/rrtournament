using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roundRobinTournament.Classes
{
    static class Games
    {
        public static Dictionary<int, Game> groupGames = new Dictionary<int, Game>();

        public static void seeGames()
        {
            foreach(var game in groupGames)
            {
                Console.WriteLine(game.Value.TeamA.Name+": "+game.Value.GoalsTeamA + "--" + game.Value.GoalsTeamB+" :"+ game.Value.TeamB.Name);

            }

        }
        public static void seeTeamsPoints()
        {
            var teamsOrder = Teams.groupTeams.ToList();
            teamsOrder.Sort((pair1, pair2) => pair1.Value.Score.CompareTo(pair2.Value.Score));
            teamsOrder.Reverse();
            foreach (var team in teamsOrder)
            {
                Console.WriteLine(team.Value.Name+"Score:"+team.Value.Score);
            }

        }
        public static void addPoints(Team a, Team b, int scoreA, int scoreB)
        {

            if (scoreA > scoreB)
            {
                a.Score = a.Score + 3;
            }else if(scoreA==scoreB)
            {
                a.Score = a.Score + 1;
                b.Score = b.Score + 1;
            }else
            {
                b.Score = b.Score + 3;
            }
        }

    }
}
