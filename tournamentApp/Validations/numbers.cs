using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roundRobinTournament.Validations
{
    static class numbers
    {
        public static int numberDomain(string text, int flat, int ceiling)
        {
            string input;
            int number=0;
            bool flag=false;

            while (!flag)
            {
                Console.Write(text);
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if(number>ceiling || number < flat)
                    {
                        flag = false;
                        Console.WriteLine("You must enter a number between {0} and {1}.",flat,ceiling);
                    }else
                    {
                        flag = true;
                    }

                }
                else
                {
                    Console.WriteLine("You must enter a number.");
                    flag = false;
                }

            }

            return number;
        }

    }
}
