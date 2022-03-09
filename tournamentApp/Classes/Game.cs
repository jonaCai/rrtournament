using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roundRobinTournament.Validations;

namespace roundRobinTournament.Classes
{
    class Game
    {
        private Team teamA{get;set;}
        private Team teamB { get; set; }
        private int goalsTeamA { get; set; }
        private int goalsTeamB { get; set; }
        public static int countGames = 0;

        public Team TeamA
        {
            get { return teamA; }
            set { teamA = value; }
        }
        public Team TeamB
        {
            get { return teamB; }
            set { teamB = value; }
        }
        public int GoalsTeamA
        {
            get { return goalsTeamA; }
            set { goalsTeamA = value; }
        }
        public int GoalsTeamB
        {
            get { return goalsTeamB; }
            set { goalsTeamB = value; }
        }
        public Game(Team a, Team b)
        {
            teamA = a;
            teamB = b;
        }
        public static void enterGame(Team a, Team b,int goalA, int goalB)
        {

            Game onlyGame = new Game(a,b);
            onlyGame.goalsTeamA = goalA;
            onlyGame.goalsTeamB = goalB;
            Games.addPoints(a,b,goalA,goalB);
            Games.groupGames.Add(countGames, onlyGame);
            countGames += 1;
        }

        public static void addGames()
        {
            int goalA=0;
            int goalB=0;
            List<Team> listTeam = new List<Team>();
                    
            foreach (var team in Teams.groupTeams)
            {                
                foreach(var team2 in Teams.groupTeams)
                {
                    if (team.Key <= team2.Key)
                    {

                    }
                    else
                    {
                            Console.WriteLine("Game n°: "+countGames);           
                            goalA = numbers.numberDomain(team.Value.Name + " Goals: ", 0, 100);
                            goalB = numbers.numberDomain(team2.Value.Name + " Goals: ", 0, 100);
                            Game.enterGame(team.Value, team2.Value, goalA, goalB);
                            Console.WriteLine();
                        
                    }


                }           

            }


        }
    }
}
