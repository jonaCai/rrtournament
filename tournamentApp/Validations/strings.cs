using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roundRobinTournament.Classes;
namespace roundRobinTournament.Validations
{
    static class strings
    {
        public static bool yesOrNot(string text)
        {
            bool flag=false;
            string choice= "tryAgain";
            while (choice == "tryAgain")
            {
                Console.Write(text);
                choice = Console.ReadLine();

                if (choice.ToUpper() == "N" || choice.ToUpper() == "NO" || choice.ToUpper() == "NOT")
                { flag = false; }
                else if (choice.ToUpper() == "Y" || choice.ToUpper() == "YES" || choice.ToUpper() == "YEAH") { flag = true; }
                else { Console.WriteLine("You must enter yes or not.");choice = "tryAgain"; }
            }

            return flag;
            
        }
        public static string teamsNames(string text)
        {
            bool flag = false;
            List<string> namesTeams = new List<string> { "BOCA", "RIVER", "SAN LORENZO", "HURACAN",
            "RACING", "INDEPENDIENTE",
            "ESPORTIVO ARMENIO", "CHACARITA",
            "TIGRE","NEWELS",
            "BELGRANO","VELEZ"};
            string name = "tryAgain";
            Console.Write(text);
            while (flag== false)
            {
                
                name = Console.ReadLine();

                if (namesTeams.Contains(name.ToUpper()))
                {
                    flag = true;
                    if (Teams.groupTeams.Any(x => x.Value.Name == name))
                    {
                        Console.WriteLine("The team {0} already exists. ", name);
                        flag = false;
                        Console.Write("Try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a valid Team: ");
                    foreach (var team in namesTeams)
                    {
                        Console.Write(team + ". ");
                    }
                    flag = false;
                    Console.Write("Try again: ");
                }
            }

            return name;

        }
        
    }
}
