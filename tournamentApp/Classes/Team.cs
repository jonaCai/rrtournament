using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roundRobinTournament.Validations;

namespace roundRobinTournament.Classes
{
     class Team 
    {
        private string name { get; set; }
        private int score { get; set; }
        private static int counterTeam = 0;
        //dfd
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Team(string name)
        {
            this.name = name;
            this.score = 0;
        }
        public static void enterTeam()
        {
            string inputUser;            
            inputUser =strings.teamsNames("Name of the team?: ");
            Team teamOne = new Team(inputUser);
            Teams.groupTeams.Add(counterTeam, teamOne);
            counterTeam += 1;

        }

    }
}
