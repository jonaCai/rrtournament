using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roundRobinTournament.Classes;
using roundRobinTournament.Validations;

namespace roundRobinTournament
{
    class Program
    {
     
        static void Main(string[] args)
        {
            bool flag = true;
            int pairTeams=0;
            string choice;
            string menu = @"   WELCOME!
    What do you want?
A_Enter team?
B_Enter games?
C_See results?
D_See position table?
E_Exit.
";
            while (flag)
            {
                drawBoxMenu(menu);
                Console.Write("Choice: ");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "A":
                        while (flag)
                        {
                            Team.enterTeam();
                            pairTeams += 1;
                            flag=strings.yesOrNot("Add other team? yes/not : ");
                            //if (flag==false &&(!(pairTeams % 2 == 0))) { Console.WriteLine("Must enter a pair number of teams"); flag = true; }                                                        
                        }
                        flag = true;
                        break;
                    case "B":
                        Game.addGames();
                        break;
                    case "C":
                        Games.seeGames();
                        break;
                    case "D":
                        Games.seeTeamsPoints();
                        break;
                    case "E":
                        flag = false;
                        Console.WriteLine("Good Bye Friends.");
                        break;
                    default:
                        Console.WriteLine("You must enter: A,B,C or D.");
                        break;


                }
                
            }
            Console.ReadLine();




        }

        static void drawBoxMenu(string menu)
        {
            string[] line = menu.Split('\n');
            int bigLine = 0;
            foreach (var lineBreak in line)
            {
                if (lineBreak.Length > bigLine) { bigLine = lineBreak.Length; }

            }

            for (int a = 0; a < bigLine + 2; ++a)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int a = 0; a < line.Length - 1; ++a)
            {
                Console.Write("*");

                Console.WriteLine($"{ line[a].TrimEnd().PadRight(bigLine)}*");
               
            }
            for (int a = 0; a < bigLine + 2; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
